namespace sqlcsdl
{
    public class DatabaseConnection
    {
        private MySqlConnection connection;
        private string connectionString;

        // Constructor, nhận tham số là chuỗi kết nối
        public DatabaseConnection()
        {
            // Chuỗi kết nối, thay YOUR_SERVER_NAME, YOUR_DATABASE_NAME, YOUR_USERNAME, YOUR_PASSWORD bằng thông tin của bạn
            connectionString = "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;User ID=YOUR_USERNAME;Password=YOUR_PASSWORD;SslMode=none;";
            connection = new MySqlConnection(connectionString);
        }

        // Phương thức mở kết nối
        public MySqlConnection GetOpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                return connection;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        // Phương thức đóng kết nối
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Phương thức thực thi câu lệnh truy vấn (SELECT)
        public MySqlDataReader ExecuteQuery(string query)
        {
            try
            {
                MySqlCommand cmd = new(query, connection);
                return cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        // Phương thức thực thi câu lệnh không trả về (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                return cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1;
            }
        }
    }
}
