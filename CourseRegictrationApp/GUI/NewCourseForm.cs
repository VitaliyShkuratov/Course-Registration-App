using CourseRegictrationApp.BUSINESS;
using System;
using System.Windows.Forms;

namespace CourseRegictrationApp.GUI
{
    public partial class NewCourseForm : Form
    {
        public NewCourseForm()
        {
            InitializeComponent();
        }

        private void NewCourseForm_Load(object sender, EventArgs e)
        {
            InitializeComboBoxCoursePrerequisiteId();
            txtCourseDescription.ScrollBars = ScrollBars.Vertical;
        }

        private void InitializeComboBoxCoursePrerequisiteId()
        {
            cmbBoxCoursePrerequisiteId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxCoursePrerequisiteId.AutoCompleteSource = AutoCompleteSource.ListItems;
            //cmbBoxCourseId.MaxDropDownItems = 5;
            foreach (Course course in CourseList.CollegeCoursesList)
            {
                cmbBoxCoursePrerequisiteId.Items.Add(course);
            }
        }

        private void btnClearCourseForm_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
        }

        void ClearAllText(Control contron)
        {
            foreach (Control c in contron.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
                if (c is ComboBox)
                    c.Text = String.Empty;
            }
        }

        private void btnSubmitCourse_Click(object sender, EventArgs e)
        {
            try
            {
                double duration = Double.Parse(txtCourseDuration.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Was entered wrong type of duration!","Warning");
            }
        }
    }
}
