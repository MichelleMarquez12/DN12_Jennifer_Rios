namespace HangFireTest.Helper
{
    public class DBHelper
    {
        public static string connectionString = "server=localhost;port=3306;database=hangfiretest;user=root;password=ElfenSnow1212;Allow User Variables=true;";

        public static void Process(int milliseconds, string args)
        {
            Thread.Sleep(milliseconds);

            MySqlConnector.MySqlConnection mySqlConnection = new MySqlConnector.MySqlConnection(connectionString);

            mySqlConnection.Open();

            MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand(
                "insert into hangfire (date,args) values (@date,@args)");

            command.Connection = mySqlConnection;

            command.Parameters.AddWithValue("@date", DateTime.Now);

            command.Parameters.AddWithValue("@args", args);

            command.ExecuteNonQuery();
        }
    }
}
