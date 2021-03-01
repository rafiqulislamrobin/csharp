using System;
using System.Data.SqlClient;
namespace exam_3
{
    class Program
    {
        private const string CONNECTING_STRING = "Server=DESKTOP-97TTHJ8\\SQLEXPRESS; Database = Products; User Id = sa; Password = allahhelpme";

        static void Main(string[] args)

        {
            SqlConnection connection = new SqlConnection(CONNECTING_STRING);
            ReadMethod(connection);

        }     
        
        private static void ReadMethod (SqlConnection connection)
        {
            var selectText = "Select * from Products";
            ReadMethodExcution(connection,selectText);
        }
        private static void ReadMethodExcution (SqlConnection connection , string commandtext)
        {
            connection.Open();

            SqlCommand command = new SqlCommand(commandtext,connection);

           var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var title = (string) reader["Title"];
                var price = (decimal)reader["Price"];
                var isavailable = (bool)reader["Isavailable"];
                var createdOn = (DateTime)reader["CreatedOn"];
                var availableQuantity = (int)reader["AvailableQuantity"];

                Console.WriteLine($"Title: {title} Price: {price} ISAvailable {isavailable} createdon {createdOn} AvailableQuantity{availableQuantity} ");

            }


            connection.Close();
            command.Dispose();
            connection.Dispose();
        }
    }
}
