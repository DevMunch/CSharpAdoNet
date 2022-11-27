using AdoNetWindow.Model;
using Repositories;

namespace AdoNetWindow
{
    public partial class Form1 : ApplicationRoot
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentModel studentModel = new StudentModel();
            studentModel.StudentName = txtStudentName.Text.Trim();
            studentModel.Address = txtAddress.Text.Trim();
            StudentRepository studentRepository = new StudentRepository();
            studentRepository.Add(studentModel);
        }
    }
}