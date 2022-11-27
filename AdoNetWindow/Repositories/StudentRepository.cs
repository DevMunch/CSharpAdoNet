using AdoNetWindow.Model;
using System.Data;

namespace Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public int Add(StudentModel model, IDbTransaction transaction = null)
        {
            throw new NotImplementedException();
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
    }
}