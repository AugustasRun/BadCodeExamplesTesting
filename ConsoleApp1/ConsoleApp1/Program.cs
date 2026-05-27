using Microsoft.Data.SqlClient;

namespace ConsoleApp1
{
    internal sealed class Program
    {
        static async Task Main(string[] args)
        {
            UnsafeQuery("test", "test", "test");
        }

        public static object UnsafeQuery(string connection, string name, string password)
        {
            SqlConnection someConnection = new SqlConnection(connection);
            using SqlCommand someCommand = new SqlCommand();
            someCommand.Connection = someConnection;

            someCommand.CommandText = "SELECT AccountNumber FROM Users " +
               "WHERE Username='" + name +
               "' AND Password='" + password + "'";

            someConnection.Open();
            object accountNumber = someCommand.ExecuteScalar();
            someConnection.Close();
            return accountNumber;
        }
    }
}
