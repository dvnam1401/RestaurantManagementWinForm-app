using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.DTO
{
    public class Account
    {
        private string userName;
        private string passWord;
        private string displayName;
        private int type;

        public Account(string userName, string passWord, string displayName)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.DisplayName = displayName;
            this.Type = type;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.PassWord = row["password"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = (int)row["type"];
        }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Type { get => type; set => type = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
    }
}
