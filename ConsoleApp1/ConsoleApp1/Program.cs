using Microsoft.Data.SqlClient;

namespace ConsoleApp1
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            UnsafeQuery("test", "test", "test");
        }

        public static object? UnsafeQuery(string connection, string name, string password)
        {
            using SqlConnection someConnection = new SqlConnection(connection);
            using SqlCommand someCommand = new SqlCommand(
                "SELECT AccountNumber FROM Users WHERE Username = @Username AND Password = @Password",
                someConnection);

            someCommand.Parameters.AddWithValue("@Username", name);
            someCommand.Parameters.AddWithValue("@Password", password);

            someConnection.Open();
            return someCommand.ExecuteScalar();
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
        }
    }
}