using AdoNet; 
using AppConfiguration;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using AdoNetWindow.Model;

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

            // CommandBehavior.CloseConnection : sql 실행이 다 끝나면 커넥션을 끊낸다.
            // SqlDataReader : 단방향 스트림 고성능으로 읽어온다.
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            List<StudentModel> students = new List<StudentModel>();

            while(reader.Read())
                students.Add(GetStudentModel(reader));
            foreach(StudentModel model in students)
                Console.WriteLine(model.ToString());
        }

        private StudentModel GetStudentModel(SqlDataReader rd) 
        {
            StudentModel model = new StudentModel();
            //model.StudentId = int.Parse(rd.GetString(1).ToString());
            model.StudentId = int.Parse(rd["StudentId"].ToString());
            model.StudentName = rd["StudentName"].ToString();
            model.Address = rd["Address"].ToString();
            return model;
        }
    }
}