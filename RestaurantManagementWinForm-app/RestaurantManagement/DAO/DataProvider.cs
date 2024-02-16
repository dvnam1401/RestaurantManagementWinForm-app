
using Microsoft.Data.SqlClient;
using System.Data;

namespace RestaurantManagement.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance 
        {
            get
            { 
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            } 
            set => DataProvider.instance = value; 
        }

        private DataProvider() { }

        //private string connectionString = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"].ToString();
        //private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectString"].ConnectionString;
        private string connectionString = "data source=VAN-NAM;initial catalog=restaurant;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";


        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;
                    foreach (string param in listParams)
                    {
                        if (param.Contains("@"))
                        {
                            command.Parameters.AddWithValue(param, parameter[i]);
                            i++;    
                        }
                    }
                }
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;
                    foreach (string param in listParams)
                    {
                        if (param.Contains("@"))
                        {
                            command.Parameters.AddWithValue(param, parameter[i]);
                            i++;
                        }
                    }
                }
                
                data = command.ExecuteNonQuery();
                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;
                    foreach (string param in listParams)
                    {
                        if (param.Contains("@"))
                        {
                            command.Parameters.AddWithValue(param, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }

            return data;
        }
    }
}
