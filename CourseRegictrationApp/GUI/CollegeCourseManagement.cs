using System;
using System.Windows.Forms;

namespace CourseRegictrationApp.GUI
{
    public partial class CollegeCourseManagement : Form
    {
        public CollegeCourseManagement()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBoxAddNewStudent_Click(object sender, EventArgs e)
        {
            TabsFormStudents newStudentForm = new TabsFormStudents();
            newStudentForm.ShowDialog();
        }

        private void pictureBoxAddNewTeacher_Click(object sender, EventArgs e)
        {
            TabsFormTeachers newTeacherForm = new TabsFormTeachers();
            newTeacherForm.ShowDialog();
        }

        private void pictureBoxCreateCourse_Click(object sender, EventArgs e)
        {
            NewCourseForm newCourseForm = new NewCourseForm();
            newCourseForm.ShowDialog();   
        }

        private void pictureBoxFillGroup_Click(object sender, EventArgs e)
        {
            TabsFormGroups newGroupForm = new TabsFormGroups();
            newGroupForm.ShowDialog();
        }
    }
}
