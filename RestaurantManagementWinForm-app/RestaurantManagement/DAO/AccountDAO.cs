using RestaurantManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get 
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set => instance = value; 
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = "USP_Login @username , @password ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] {userName, displayName, pass, newPass});
            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT userName, displayName, type FROM dbo.Account");
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);

            }

            return null;
        }

        public bool InsertAccount(string userName, string displayName, int type)
        {
            string query = string.Format("INSERT INTO dbo.Account(userName, displayName, type) VALUES ('{0}', N'{1}', {2})", userName, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string userName, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET displayName = N'{1}', type = {2} WHERE userName = '{0}'", userName, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string userName)
        {
            string query = string.Format("DELETE dbo.Account WHERE userName = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string userName)
        {
            string query = string.Format("UPDATE dbo.Account SET password = '14072002' WHERE userName = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
