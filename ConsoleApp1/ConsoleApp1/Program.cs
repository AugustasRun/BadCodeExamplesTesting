using Microsoft.Data.SqlClient;

namespace ConsoleApp1
{
    internal sealed class Program
    {
        static async Task Main(string[] args)
        {
            _ = UnsafeQuery("test", "test", "test");
        }

        public static object UnsafeQuery(string connection, string name, string password)
        {
            using SqlConnection someConnection = new SqlConnection(connection);
            using SqlCommand someCommand = someConnection.CreateCommand();

            someCommand.CommandText =
                "SELECT AccountNumber FROM Users WHERE Username = @Username AND Password = @Password";

            someCommand.Parameters.AddWithValue("@Username", name);
            someCommand.Parameters.AddWithValue("@Password", password);

            someConnection.Open();
            object accountNumber = someCommand.ExecuteScalar();
            return accountNumber;
        }

        public static void Math()
        {
            var number = 0;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
            number++;
        }
    }
}