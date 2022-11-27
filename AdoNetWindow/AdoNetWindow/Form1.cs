using AdoNetWindow.Model;
using Repositories;
using System.Data;

namespace AdoNetWindow
{
    //public partial class Form1 : Form
    public partial class Form1 : ApplicationRoot
    {
        IStudentRepository studentRepository;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentRepository = new StudentRepository();
            V_ShowStudent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentAdd();
            V_ShowStudent();
            
        }

        private void V_ShowStudent()
        {
            //grdStudent.DataSource = studentRepository.GetAll().Tables[0];
            grdStudent.DataSource = studentRepository.GetAll();
            grdStudent.Columns["StudentId"].HeaderText = "학생Id";
            grdStudent.Columns["StudentName"].HeaderText = "학생성명";
            grdStudent.Columns["Address"].HeaderText = "주소";
        }

        private void StudentAdd()
        {
            StudentModel studentModel = new StudentModel();
            studentModel.StudentName = txtStudentName.Text.Trim();
            studentModel.Address = txtAddress.Text.Trim();
            studentRepository.Add(studentModel);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 만일 테이블 목록이 아닌 다른 부분을 클릭했다면 리턴.
            if (grdStudent.SelectedRows.Count == 0) return;
            //StudentDelete(int.Parse(grdStudent.SelectedRows[0].Cells["StudentId"].Value.ToString()));
            StudentModel studentModel = grdStudent.SelectedRows[0].DataBoundItem as StudentModel;
            StudentDelete(studentModel.StudentId);
        }

        private void StudentDelete(int student_id)
        {
            studentRepository.Delete(student_id);
            V_ShowStudent();
        }
    }
}