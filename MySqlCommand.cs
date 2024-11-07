
namespace sqlcsdl
{
    internal class MySqlCommand
    {
        private string query;
        private MySqlConnection connection;

        public MySqlCommand(string query, MySqlConnection connection)
        {
            this.query = query;
            this.connection = connection;
        }

        internal int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        internal MySqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}