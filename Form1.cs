namespace sqlcsdl
{
    public partial class Form1 : Form
    {
        private DatabaseConnection db;

        public Form1()
        {
            InitializeComponent();
            db = new DatabaseConnection();
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Sim ORDER BY NgayKichHoat ASC";
            MySqlConnection conn = db.GetOpenConnection();
            if (conn != null)
            {
                MySqlDataAdapter adapter = new(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }
    }
}

