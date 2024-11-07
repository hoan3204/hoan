using System.Data;

namespace sqlcsdl
{
    internal class MySqlConnection
    {
        private string connectionString;

        public MySqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ConnectionState State { get; internal set; }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}