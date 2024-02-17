CREATE DATABASE restaurant
GO

USE restaurant
GO


-- TẠO BẢNG:
---- Food
---- Table
---- FoodCategory
---- Account
---- Bill
---- BillInfo

CREATE TABLE TableFood
(
	id INT PRIMARY KEY,
	name NVARCHAR(50) NOT NULL DEFAULT N'Chưa đặt tên',
	status NVARCHAR(50) NOT NULL DEFAULT N'Trống' -- trống && có người
)
GO

CREATE TABLE Account
(
	userName NVARCHAR(100) PRIMARY KEY,
	displayName NVARCHAR(100) NOT NULL DEFAULT N'ANONYMOUS USER',
	password NVARCHAR(1000) NOT NULL DEFAULT 14072002,
	type INT NOT NULL DEFAULT 0 -- 1: Admin && 0: Staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(50) NOT NULL DEFAULT N'Chưa đặt tên',
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(50) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL,
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id) 
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	dateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	dateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0,

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO
























--Proc hiển thị danh sách Account
CREATE PROC USP_GetAccountListByUserName
@userName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM Account WHERE userName = @userName
END
GO

--Proc đăng nhập
CREATE PROC USP_Login
@username NVARCHAR(100), @password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE userName = @username AND password = @password
END
GO

--Proc hiển thị danh sách bàn ăn
CREATE PROC USP_GetTableList
AS
SELECT * FROM dbo.TableFood
GO

--Proc hiển thị Bill chưa thanh toán bằng TableID
CREATE PROC USP_GetUncheckBillByTaBleID @tableid INT
AS
SELECT * FROM dbo.Bill WHERE idTable = @tableid AND status = 0
GO

--Proc hiển thị BillInfo cụ thể của Bill (chưa thanh toán) bằng BillID
CREATE PROC USP_GetListBillInfo @idBill INT
AS
SELECT * FROM dbo.BillInfo WHERE idBill = @idBill
GO

--Proc thêm Bill
CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
INSERT INTO dbo.Bill (dateCheckIn, dateCheckOut, idTable, status, discount)
VALUES(GETDATE(), NULL, @idTable, 0, 0)
END 
GO

--Proc thêm BillInfo
CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @existBillInfo INT;
	DECLARE @foodCount INT = 1;
	SELECT @existBillInfo = id, @foodCount = count 
	FROM dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood

	IF(@existBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount > 0)
			UPDATE dbo.BillInfo SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT INTO dbo.BillInfo (idBill, idFood, count)
		VALUES (@idBill, @idFood, @count)
	END
END
GO


--SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.idTable = 86695;



--Trigger xử lí thanh toán hóa đơn (đổi thành bàn trống khi thành toán Bill, đổi thành có người khi thêm BillInfo)

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = idBill FROM Inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0 


	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill

	IF (@count > 0)
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
	ELSE
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	DECLARE @count INT = 0

	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0

	IF(@count = 0 OR @count IS NULL)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO


--Trigger cập nhật bàn
CREATE TRIGGER UTG_UpdateTable
ON dbo.TableFood FOR UPDATE
AS 
BEGIN
	DECLARE @idTable INT
	DECLARE @status NVARCHAR(100)
	
	SELECT @idTable = id, @status = Inserted.status FROM Inserted

	DECLARE @idBill INT
	SELECT @idBill = id FROM dbo.Bill WHERE idTable = @idTable AND status = 0

	DECLARE @countBillInfo INT
	SELECT @countBillInfo = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill

	IF (@countBillInfo > 0 AND @status <> N'Có người')
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
	ELSE IF (@countBillInfo <= 0 AND @status <> N'Trống')
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO




--Proc Chuyển bàn
CREATE PROC USP_SwitchTable1
@idTable1 INT, @idTable2 INT
AS
BEGIN
	DECLARE @idFirstBill INT
	DECLARE @idSecondBill INT
	DECLARE @isFirstTableEmpty INT = 1
	DECLARE @isSecondTableEmpty INT = 1

	SELECT @idSecondBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	

	IF (@idFirstBill IS NULL)
	BEGIN
		
		INSERT INTO dbo.Bill (dateCheckIn, dateCheckOut, idTable, status) 
		VALUES (GETDATE(), NULL, @idTable1, 0)

		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	END

	SELECT @isFirstTableEmpty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill

	IF (@idSecondBill IS NULL)
	BEGIN
		
		INSERT INTO dbo.Bill (dateCheckIn, dateCheckOut, idTable, status) 
		VALUES (GETDATE(), NULL, @idTable2, 0)

		SELECT @idSecondBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END

	SELECT @isSecondTableEmpty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSecondBill

	
	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSecondBill

	UPDATE dbo.BillInfo SET idBill = @idSecondBill WHERE idBill = @idFirstBill

	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)

	DROP TABLE IDBillInfoTable

	IF (@isFirstTableEmpty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2

	IF (@isSecondTableEmpty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO


--Thêm cột Tổng tiền cho Bill
CREATE TABLE dbo.Bill ADD totalPrice FLOAT

DELETE dbo.Bill
DELETE dbo.BillInfo

SELECT * FROM Bill

--Proc Hiển thị Bill theo ngày
CREATE PROC USP_GetListBillByDate
@checkIn DATE, @checkOut DATE
AS
BEGIN

	SELECT t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], dateCheckIn AS [Ngày vào], dateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE dateCheckIn >= @checkIn AND dateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable

END



--Sửa bảng Bill
CREATE TABLE dbo.Bill
ADD discount INT
GO

--Proc sửa AccountProfile
CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0

	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE userName = @userName AND password = @password

	IF (@isRightPass = 1)
	BEGIN 
		IF (@newPassword = NULL OR @newPassword ='')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE userName = @userName
		END
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, password = @newPassword WHERE userName = @userName
	END
END


--Trigger xóa BillInfo (để fix bug bàn không chuyển trạng thái khi xóa món bị ràng buộc khóa ngoại)
CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN 
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted

	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

	DECLARE @count INT = 0

	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0

	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

















--Thêm Account đăng nhập
INSERT INTO dbo.Account(userName, displayName, password, type)
VALUES (N'Administrator', N'ADMIN', N'123', 1)
INSERT INTO dbo.Account(userName, displayName, password, type)
VALUES (N'Staff1', N'Ngô Khôn Tấn', N'123', 0)

--Thêm bàn
DECLARE @i INT = 0
WHILE @i <= 21
BEGIN
	INSERT INTO dbo.TableFood  (name) VALUES (N'Bàn ' + CAST((@i+1) AS NVARCHAR(100)))
	SET @i = @i + 1
END
GO

--Thêm Category
INSERT INTO dbo.FoodCategory(name)
VALUES (N'Thủy - Hải sản')
INSERT INTO dbo.FoodCategory(name)
VALUES (N'Vùng cao')
INSERT INTO dbo.FoodCategory(name)
VALUES (N'Bình dân')
INSERT INTO dbo.FoodCategory(name)
VALUES (N'Gà - Vịt - Ngan')
INSERT INTO dbo.FoodCategory(name)
VALUES (N'Tráng miệng')
INSERT INTO dbo.FoodCategory(name)
VALUES (N'Nước giải khát')

SELECT * FROM dbo.FoodCategory


--Thêm món ăn
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Cua hấp', 1, 400000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Mực hấp lá gừng', 1, 140000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Ngao hấp cay', 1, 120000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Sò điệp nướng mỡ hành', 1, 160000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Lườn cá ngừ nướng', 1, 220000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Bạch tuộc nướng sa tế', 1, 300000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Trâu rừng gác bếp', 2, 300000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Bê chao Mộc Châu', 2, 220000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Nậm pịa', 2, 170000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Lạp xưởng Điện Biên', 2, 200000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Thịt chuột La Chí', 2, 300000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Sâu chít rang', 2, 400000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Rau muống xào tỏi', 3, 50000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Canh sườn măng', 3, 120000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Đậu tẩm hành', 3, 50000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Thịt rang cháy cạnh', 3, 100000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Bò xào cần tây', 3, 150000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Tóp mỡ Hà Đông', 3, 120000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Gà xào sả ớt', 4, 150000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Ngan cháy tỏi', 4, 200000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Gà quay lu', 4, 180000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Vịt quay Quảng Đông', 4, 220000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Vịt om sấu', 4, 200000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Sờ ting', 5, 5000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Coca Cola', 5, 10000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Mirinda', 5, 10000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Lavie', 5, 10000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Rượu táo mèo', 5, 50000)



--Thêm bill
INSERT INTO dbo.Bill (dateCheckIn, dateCheckOut, idTable, status)
VALUES(GETDATE(), NULL, 86691, 0)
INSERT INTO dbo.Bill (dateCheckIn, dateCheckOut, idTable, status)
VALUES(GETDATE(), NULL, 86695, 0)
INSERT INTO dbo.Bill (dateCheckIn, dateCheckOut, idTable, status)
VALUES(GETDATE(), GETDATE(), 86693, 1)

UPDATE dbo.Bill SET status = 0 WHERE id = 3

--Thêm bill info
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (1, 1, 2)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (1, 3, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (1, 7, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (1, 10, 2)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (2, 1, 2)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (2, 3, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (2, 7, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (2, 10, 2)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (3, 1, 2)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (3, 3, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (3, 7, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (3, 10, 2)





3a


CREATE DATABASE restaurant
GO

USE restaurant
GO


-- TẠO BẢNG:
---- Food
---- Table
---- FoodCategory
---- Account
---- Bill
---- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(50) NOT NULL DEFAULT N'Chưa đặt tên',
	status NVARCHAR(50) NOT NULL DEFAULT N'Trống' -- trống && có người
)
GO

CREATE TABLE Account
(
	userName NVARCHAR(100) PRIMARY KEY,
	displayName NVARCHAR(100) NOT NULL DEFAULT N'ANONYMOUS USER',
	password NVARCHAR(1000) NOT NULL DEFAULT 14072002,
	type INT NOT NULL DEFAULT 0 -- 1: Admin && 0: Staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(50) NOT NULL DEFAULT N'Chưa đặt tên',
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(50) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL,
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id) 
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	dateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	dateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0,

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

--Proc hiển thị danh sách Account
CREATE PROC USP_GetAccountListByUserName
@userName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM Account WHERE userName = @userName
END
GO

--Proc đăng nhập
CREATE PROC USP_Login
@username NVARCHAR(100), @password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE userName = @username AND password = @password
END
GO

--Proc hiển thị danh sách bàn ăn
CREATE PROC USP_GetTableList
AS
SELECT * FROM dbo.TableFood
GO

--Proc hiển thị Bill chưa thanh toán bằng TableID
CREATE PROC USP_GetUncheckBillByTaBleID @tableid INT
AS
SELECT * FROM dbo.Bill WHERE idTable = @tableid AND status = 0
GO

--Proc hiển thị BillInfo cụ thể của Bill (chưa thanh toán) bằng BillID
CREATE PROC USP_GetListBillInfo @idBill INT
AS
SELECT * FROM dbo.BillInfo WHERE idBill = @idBill
GO

--Sửa bảng Bill
ALTER TABLE dbo.Bill
ADD discount INT;

GO

--Proc thêm Bill
CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
INSERT INTO dbo.Bill (dateCheckIn, dateCheckOut, idTable, status, discount)
VALUES(GETDATE(), NULL, @idTable, 0, 0)
END 
GO

--Proc thêm BillInfo
CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @existBillInfo INT;
	DECLARE @foodCount INT = 1;
	SELECT @existBillInfo = id, @foodCount = count 
	FROM dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood

	IF(@existBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount > 0)
			UPDATE dbo.BillInfo SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT INTO dbo.BillInfo (idBill, idFood, count)
		VALUES (@idBill, @idFood, @count)
	END
END
GO


--SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.idTable = 86695;



--Trigger xử lí thanh toán hóa đơn (đổi thành bàn trống khi thành toán Bill, đổi thành có người khi thêm BillInfo)

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = idBill FROM Inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0 


	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill

	IF (@count > 0)
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
	ELSE
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	DECLARE @count INT = 0

	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0

	IF(@count = 0 OR @count IS NULL)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO


--Trigger cập nhật bàn
CREATE TRIGGER UTG_UpdateTable
ON dbo.TableFood FOR UPDATE
AS 
BEGIN
	DECLARE @idTable INT
	DECLARE @status NVARCHAR(100)
	
	SELECT @idTable = id, @status = Inserted.status FROM Inserted

	DECLARE @idBill INT
	SELECT @idBill = id FROM dbo.Bill WHERE idTable = @idTable AND status = 0

	DECLARE @countBillInfo INT
	SELECT @countBillInfo = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill

	IF (@countBillInfo > 0 AND @status <> N'Có người')
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
	ELSE IF (@countBillInfo <= 0 AND @status <> N'Trống')
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO




--Proc Chuyển bàn
CREATE PROC USP_SwitchTable1
@idTable1 INT, @idTable2 INT
AS
BEGIN
	DECLARE @idFirstBill INT
	DECLARE @idSecondBill INT
	DECLARE @isFirstTableEmpty INT = 1
	DECLARE @isSecondTableEmpty INT = 1

	SELECT @idSecondBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	

	IF (@idFirstBill IS NULL)
	BEGIN
		
		INSERT INTO dbo.Bill (dateCheckIn, dateCheckOut, idTable, status) 
		VALUES (GETDATE(), NULL, @idTable1, 0)

		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	END

	SELECT @isFirstTableEmpty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill

	IF (@idSecondBill IS NULL)
	BEGIN
		
		INSERT INTO dbo.Bill (dateCheckIn, dateCheckOut, idTable, status) 
		VALUES (GETDATE(), NULL, @idTable2, 0)

		SELECT @idSecondBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END

	SELECT @isSecondTableEmpty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSecondBill

	
	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSecondBill

	UPDATE dbo.BillInfo SET idBill = @idSecondBill WHERE idBill = @idFirstBill

	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)

	DROP TABLE IDBillInfoTable

	IF (@isFirstTableEmpty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2

	IF (@isSecondTableEmpty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO


--Thêm cột Tổng tiền cho Bill
ALTER TABLE dbo.Bill ADD totalPrice FLOAT

DELETE dbo.Bill
DELETE dbo.BillInfo

SELECT * FROM Bill

--Proc Hiển thị Bill theo ngày
CREATE PROC USP_GetListBillByDate
@checkIn DATE, @checkOut DATE
AS
BEGIN

	SELECT t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], dateCheckIn AS [Ngày vào], dateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE dateCheckIn >= @checkIn AND dateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable

END

--Proc sửa AccountProfile
CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0

	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE userName = @userName AND password = @password

	IF (@isRightPass = 1)
	BEGIN 
		IF (@newPassword = NULL OR @newPassword ='')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE userName = @userName
		END
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, password = @newPassword WHERE userName = @userName
	END
END


--Trigger xóa BillInfo (để fix bug bàn không chuyển trạng thái khi xóa món bị ràng buộc khóa ngoại)
CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN 
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted

	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

	DECLARE @count INT = 0

	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0

	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

--Thêm Account đăng nhập
INSERT INTO dbo.Account(userName, displayName, password, type)
VALUES (N'Administrator', N'ADMIN', N'123', 1)
INSERT INTO dbo.Account(userName, displayName, password, type)
VALUES (N'Staff1', N'Ngô Khôn Tấn', N'123', 0)

--Thêm bàn
DECLARE @i INT = 0
WHILE @i <= 21
BEGIN
	INSERT INTO dbo.TableFood  (name) VALUES (N'Bàn ' + CAST((@i+1) AS NVARCHAR(100)))
	SET @i = @i + 1
END

SELECT * FROM TableFood;

GO

--Thêm Category
INSERT INTO dbo.FoodCategory(name)
VALUES (N'Thủy - Hải sản')
INSERT INTO dbo.FoodCategory(name)
VALUES (N'Vùng cao')
INSERT INTO dbo.FoodCategory(name)
VALUES (N'Bình dân')
INSERT INTO dbo.FoodCategory(name)
VALUES (N'Gà - Vịt - Ngan')
INSERT INTO dbo.FoodCategory(name)
VALUES (N'Tráng miệng')
INSERT INTO dbo.FoodCategory(name)
VALUES (N'Nước giải khát')

SELECT * FROM dbo.FoodCategory


--Thêm món ăn
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Cua hấp', 1, 400000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Mực hấp lá gừng', 1, 140000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Ngao hấp cay', 1, 120000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Sò điệp nướng mỡ hành', 1, 160000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Lườn cá ngừ nướng', 1, 220000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Bạch tuộc nướng sa tế', 1, 300000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Trâu rừng gác bếp', 2, 300000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Bê chao Mộc Châu', 2, 220000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Nậm pịa', 2, 170000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Lạp xưởng Điện Biên', 2, 200000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Thịt chuột La Chí', 2, 300000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Sâu chít rang', 2, 400000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Rau muống xào tỏi', 3, 50000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Canh sườn măng', 3, 120000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Đậu tẩm hành', 3, 50000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Thịt rang cháy cạnh', 3, 100000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Bò xào cần tây', 3, 150000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Tóp mỡ Hà Đông', 3, 120000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Gà xào sả ớt', 4, 150000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Ngan cháy tỏi', 4, 200000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Gà quay lu', 4, 180000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Vịt quay Quảng Đông', 4, 220000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Vịt om sấu', 4, 200000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Sờ ting', 5, 5000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Coca Cola', 5, 10000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Mirinda', 5, 10000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Lavie', 5, 10000)
INSERT INTO dbo.Food (name, idCategory, price)
VALUES (N'Rượu táo mèo', 5, 50000)

--Thêm bill
INSERT INTO dbo.Bill (dateCheckIn, dateCheckOut, idTable, status)
VALUES(GETDATE(), NULL, 12, 0)
INSERT INTO dbo.Bill (dateCheckIn, dateCheckOut, idTable, status)
VALUES(GETDATE(), NULL, 22, 0)
INSERT INTO dbo.Bill (dateCheckIn, dateCheckOut, idTable, status)
VALUES(GETDATE(), GETDATE(), 10, 1)

UPDATE dbo.Bill SET status = 0 WHERE id = 3

--Thêm bill info
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (10, 1, 2)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (11, 3, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (12, 7, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (1, 10, 2)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (2, 1, 2)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (2, 3, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (2, 7, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (2, 10, 2)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (3, 1, 2)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (3, 3, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (3, 7, 1)
INSERT INTO dbo.BillInfo (idBill, idFood, count)
VALUES (3, 10, 2)