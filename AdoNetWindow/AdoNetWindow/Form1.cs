using AdoNet; 
using AppConfiguration;
using System.Data.SqlClient;
using System.Data;

namespace AdoNetWindow
{
    public partial class Form1 : ApplicationRoot
    {
        //MsSql msql;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlDataReader
            string sql = "select * from tb_student";
            SqlCommand command = new SqlCommand(sql, (SqlConnection)instance.Connection);

            // CommandBehavior.CloseConnection : sql ������ �� ������ Ŀ�ؼ��� ������.
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            while(reader.Read())
            {
                MessageBox.Show($"{reader["StudentId"]}:{reader["StudentName"]}:{reader["Address"]}");
            }
        }
    }
}