using System.Data;

namespace sqlcsdl
{
    internal class MySqlDataAdapter
    {
        private string query;
        private MySqlConnection conn;

        public MySqlDataAdapter(string query, MySqlConnection conn)
        {
            this.query = query;
            this.conn = conn;
        }

        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}