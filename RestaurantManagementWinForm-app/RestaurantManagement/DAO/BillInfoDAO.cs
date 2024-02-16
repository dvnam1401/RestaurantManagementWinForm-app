using RestaurantManagement.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillInfoDAO();
                return instance;
            }
            private set => BillInfoDAO.instance = value;
        }

        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            string query = "USP_GetListBillInfo @idBill";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }

        public void DeleteBillInfoByFoodID(int idFood)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("DELETE dbo.BillInfo WHERE idFood = " + idFood);

        }
    }
}
