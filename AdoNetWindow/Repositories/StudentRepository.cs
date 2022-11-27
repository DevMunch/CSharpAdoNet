using AdoNetWindow.Model;
using Libs;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Repositories
{
    public class StudentRepository : ClassRoot, IStudentRepository
    {
        public int Add(StudentModel model, IDbTransaction transaction = null)
        {
            StringBuilder qry = new StringBuilder();
            qry.Append($" INSERT INTO TB_Student (StudentName,Address)");
            qry.Append($" VALUES('{model.StudentName}','{model.Address}');");

            qry.Append($" SELECT SCOPE_IDENTITY()");
            SqlCommand command = new SqlCommand(qry.ToString(), (SqlConnection)dbInstance.Connection);
            model.StudentId = int.Parse(command.ExecuteScalar().ToString());
            return model.StudentId;
        }

        public int Delete(int student_model, IDbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public List<StudentModel> GetAll(IDbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public StudentModel GetById(int student_model, IDbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public int Update(StudentModel model, IDbTransaction transaction = null)
        {
            throw new NotImplementedException();
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