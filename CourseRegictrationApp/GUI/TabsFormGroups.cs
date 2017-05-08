using CourseRegictrationApp.BUSINESS;
using System;
using System.Windows.Forms;

namespace CourseRegictrationApp.GUI
{
    public partial class TabsFormGroups : Form
    {
        Group newGroup = new Group();
        // use to store temporary group before submit
        MembersOfGroupsList newMemdersOfGroupsList = new MembersOfGroupsList();
        string currentGroupId = "";

        public TabsFormGroups()
        {
            InitializeComponent();
            InitializePersonsLists();
            CourseList.AddCourseDescription();
            InitializeComboBoxCourses();
            InitializeComboBoxTeacherId();
            InitializeComboBoxStudentId();
            InitializeDataGridViewGroup();
            txtCourseDescription.ScrollBars = ScrollBars.Vertical;
        }

       
        private void InitializeDataGridViewGroup()
        {


        }

        private void InitializeComboBoxStudentId()
        {
            cmbBoxStudentId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxStudentId.AutoCompleteSource = AutoCompleteSource.ListItems;

            for (int i = 0; i < StaticsPersonsList.StudentsList.Count(); i++)
            {
                Student student = (Student)StaticsPersonsList.StudentsList.GetPerson(i);
                cmbBoxStudentId.Items.Add(student);
                cmbBoxStudentIdEdit.Items.Add(student);
            }
        }

        private void cmbBoxStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var current = (Student)(cmbBoxStudentId.SelectedItem);
                if (current != null)
                {
                    cmbBoxStudentId.Text = current.PersonId;
                    txtStudentFirstName.Text = current.FirstName;
                    txtStudentMiddleName.Text = current.MiddleName;
                    txtStudentLastName.Text = current.LastName;
                    txtStudentDateOfBirth.Text = current.DateOfBirds.ToString("MM/dd/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeComboBoxTeacherId()
        {
            cmbBoxTeacherId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxTeacherId.AutoCompleteSource = AutoCompleteSource.ListItems;

            for (int i = 0; i < StaticsPersonsList.TeachersList.Count(); i++)
            {
                Teacher student = (Teacher)StaticsPersonsList.TeachersList.GetPerson(i);
                cmbBoxTeacherId.Items.Add(student);
                cmbBoxTeacherIdEdit.Items.Add(student);
            }
        }
        private void cmbBoxTeacherId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var current = (Teacher)(cmbBoxTeacherId.SelectedItem);
                if (current != null)
                {
                    cmbBoxTeacherId.Text = current.PersonId;
                    txtTeacherFirstName.Text = current.FirstName;
                    txtTeacherMiddleName.Text = current.MiddleName;
                    txtTeacherLastName.Text = current.LastName;
                    txtTeacherStatus.Text = current.TeacherStatus.ToString();
                    txtTeacherDateOfBirth.Text = current.DateOfBirds.ToString("MM/dd/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeComboBoxCourses()
        {
            cmbBoxCourseId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxCourseId.AutoCompleteSource = AutoCompleteSource.ListItems;
           
            foreach (Course course in CourseList.CollegeCoursesList)
            {
                cmbBoxCourseId.Items.Add(course);
            }
        }

        private void cmbBoxCourseId_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                var current = (Course)(cmbBoxCourseId.SelectedItem);
                if (current != null)
                {
                    cmbBoxCourseId.Text = current.CourseId.ToString();
                    txtCourseName.Text = current.CourseName;
                    txtCourseDuration.Text = current.CourseDuration.ToString();
                    txtCoursePrerequisite.Text = current.CoursePrerequisite;
                    txtCourseDescription.Text = current.CourseDescription;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddStudentToGroup_Click(object sender, EventArgs e)
        {
            if (cmbBoxStudentId.SelectedItem != null)
            {
                var student = (Student)cmbBoxStudentId.SelectedItem;

                //check if student was added already to group
                if (!newMemdersOfGroupsList.StudentList.CheckExistingPerson(student.PersonId))
                {
                    newMemdersOfGroupsList.StudentList.AddPerson(student);

                    this.dataGridAddGroup.Rows.Add(student.PersonId,
                                                        student.FirstName,
                                                        student.MiddleName,
                                                        student.LastName,
                                                        student.DateOfBirds.ToString("MM/dd/yyyy"));
                }
                else MessageBox.Show("This student has already been added!");
            }
            else MessageBox.Show("Choose a student!");
        }

        private void btnAddTeacherToGroup_Click(object sender, EventArgs e)
        {
            if (cmbBoxTeacherId.SelectedItem != null)
            {
                var teacher = (Teacher)cmbBoxTeacherId.SelectedItem;

                if (!newMemdersOfGroupsList.TeacherList.CheckExistingPerson(teacher.PersonId))
                {
                    newMemdersOfGroupsList.TeacherList.AddPerson(teacher);

                    this.dataGridAddGroup.Rows.Add(teacher.PersonId,
                                                        teacher.FirstName,
                                                        teacher.MiddleName,
                                                        teacher.LastName,
                                                        teacher.DateOfBirds.ToString("MM/dd/yyyy"));
                }
                else MessageBox.Show("This teacher has already been added!");
            }
            else MessageBox.Show("Choose a teacher!");
        }

        private void btnSubmitGroup_Click(object sender, EventArgs e)
        {
            bool exist = false;
            if (cmbBoxCourseId.SelectedItem != null)
            {
                var currentCourse = (Course)cmbBoxCourseId.SelectedItem;
                // check groups with the same parameters
                try
                {
                    StaticsGroupsList.GroupsList = StaticsGroupsList.ReadXML(StaticsGroupsList.FileGroupsList);
                }
                catch (Exception)
                {
                    exist = false;
                }

                if (StaticsGroupsList.GroupsList != null)
                {
                    foreach (var group in StaticsGroupsList.GroupsList)
                    {
                        if (group.Course.Equals(currentCourse) &&
                            group.StudentList.Equals(newMemdersOfGroupsList.StudentList) &&
                            group.TeacherList.Equals(newMemdersOfGroupsList.TeacherList))
                        {
                            exist = true;
                            break;
                        }
                    }
                }

                if (!exist)
                {
                    StaticsGroupsList.AddGroup(new Group(
                                               currentCourse,
                                               newMemdersOfGroupsList.TeacherList,
                                               newMemdersOfGroupsList.StudentList));
                    cmbBoxCourseId.Enabled = false;
                    cmbBoxTeacherId.Enabled = false;
                    cmbBoxStudentId.Enabled = false;

                    try
                    {
                        StaticsGroupsList.StoreListInXML();
                        MessageBox.Show("The group was successfully created!");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose a course!");
            }
        }

        private void btnCreateAnotherGroup_Click(object sender, EventArgs e)
        {
            newMemdersOfGroupsList = new MembersOfGroupsList();
            ClearAllText(this);
            dataGridAddGroup.Rows.Clear();

            cmbBoxCourseId.Enabled = true;
            cmbBoxTeacherId.Enabled = true;
            cmbBoxStudentId.Enabled = true;
        }

        private void btnFindGroup_Click(object sender, EventArgs e)
        {
            dataGridViewListGroups.Rows.Clear();
            bool matches = false;
            string searchParam = txtSearchParameters.Text;
            // read list of all groups from XML file
            GetListOfGroups();
            if (StaticsGroupsList.GroupsList != null)
            {
                if (!string.IsNullOrWhiteSpace(searchParam))
                {
                    // get group
                    foreach (var group in StaticsGroupsList.GroupsList)
                    {
                        if ((group.CurrentGroupId.ToLower() == searchParam.ToLower()))
                        {
                            // get teacher in group
                            for (int i = 0; i < group.TeacherList.Count(); i++)
                            {
                                var teacher = (Teacher)group.TeacherList.GetPerson(i);
                                dataGridViewListGroups.Rows.Add(group.CurrentGroupId,
                                                                teacher.PersonId,
                                                                teacher.FirstName,
                                                                teacher.MiddleName,
                                                                teacher.LastName,
                                                                teacher.DateOfBirds.ToString("MM/dd/yyyy"));
                                matches = true;
                            }
                            // get list of student in group
                            for (int i = 0; i < group.TeacherList.Count(); i++)
                            {
                                var student = (Student)group.StudentList.GetPerson(i);
                                dataGridViewListGroups.Rows.Add(group.CurrentGroupId,
                                                                student.PersonId,
                                                                student.FirstName,
                                                                student.MiddleName,
                                                                student.LastName,
                                                                student.DateOfBirds.ToString("MM/dd/yyyy"));
                                matches = true;
                            }
                        }
                    }
                }
                else
                {
                    matches = true;
                    MessageBox.Show("Enter the search parameter!");
                }
            }
            else
            {
                matches = true;
                MessageBox.Show("The list of groups empty!");
            }

            if (!matches)
                MessageBox.Show("No matches found!");
        }

        private void btnDisplayAllGroups_Click(object sender, EventArgs e)
        {
            dataGridViewListGroups.Rows.Clear();
            // read list of all groups from XML file
           GetListOfGroups();

                if (StaticsGroupsList.GroupsList != null)
                {
                    // get group
                    foreach (var group in StaticsGroupsList.GroupsList)
                    {
                        // get teacher in group
                        for (int i = 0; i < group.TeacherList.Count(); i++)
                        {
                            var teacher = (Teacher)group.TeacherList.GetPerson(i);
                            dataGridViewListGroups.Rows.Add(group.CurrentGroupId,
                                                            teacher.PersonId,
                                                            teacher.FirstName,
                                                            teacher.MiddleName,
                                                            teacher.LastName,
                                                            teacher.DateOfBirds.ToString("MM/dd/yyyy"));
                        }
                        // get list of student in group
                        for (int i = 0; i < group.StudentList.Count(); i++)
                        {
                            var student = (Student)group.StudentList.GetPerson(i);
                            dataGridViewListGroups.Rows.Add(group.CurrentGroupId,
                                                            student.PersonId,
                                                            student.FirstName,
                                                            student.MiddleName,
                                                            student.LastName,
                                                            student.DateOfBirds.ToString("MM/dd/yyyy"));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The list of groups empty!");
                }
            }

        private void btnFindGroupEdit_Click(object sender, EventArgs e)
        {
            cmbBoxTeacherIdEdit.Enabled = true;
            cmbBoxStudentIdEdit.Enabled = true;

            dataGridGroupEdit.Rows.Clear();
            string searchParam = txtIdGroupSearchEdit.Text;
            GetListOfGroups();

                if (StaticsGroupsList.GroupsList != null)
                {
                    if (!string.IsNullOrWhiteSpace(searchParam))
                    {

                        // get group
                        GetGroup(searchParam);
                    }
                    else
                        MessageBox.Show("Enter the search parameter!");
                }
                else
                    MessageBox.Show("The list of groups empty!");
         }

        private void btnRemovePersonFromGroup_Click(object sender, EventArgs e)
        {
            dataGridGroupEdit.Rows.Clear();
            newMemdersOfGroupsList.StudentList.RemovePerson(txtIdPersonSearchEdit.Text);
            newMemdersOfGroupsList.TeacherList.RemovePerson(txtIdPersonSearchEdit.Text);
            GetGroup(currentGroupId);
            MessageBox.Show("To submit deleting the person, press the button 'Submit Changes'!");

        }

        // get group by entered ID
   private void GetGroup(string groupId)
     {
       dataGridGroupEdit.Rows.Clear();
       bool matches = false;

       foreach (var group in StaticsGroupsList.GroupsList)
        {
        if ((group.CurrentGroupId.ToLower() == groupId.ToLower()))
        {
            currentGroupId = groupId;
            matches = true;

                    newMemdersOfGroupsList.TeacherList = group.TeacherList;
                    newMemdersOfGroupsList.StudentList = group.StudentList;

                    txtCourseIdEdit.Text = group.Course.CourseId;
                    txtCourseNameEdit.Text = group.Course.CourseName;
                    txtCourseDurationEdit.Text = group.Course.CourseDuration.ToString();
                    txtCoursePrerequisiteEdit.Text = group.Course.CoursePrerequisite;
                    txtCourseDescriptionEdit.Text = group.Course.CourseDescription;

           // get teacher in group
           for (int i = 0; i < group.TeacherList.Count(); i++)
            {
                var teacher = (Teacher)group.TeacherList.GetPerson(i);
                dataGridGroupEdit.Rows.Add(group.CurrentGroupId,
                                           teacher.PersonId,
                                           teacher.FirstName,
                                           teacher.MiddleName,
                                           teacher.LastName,
                                           teacher.DateOfBirds.ToString("MM/dd/yyyy"));
            }
            // get list of student in group
            for (int i = 0; i < group.StudentList.Count(); i++)
            {
                var student = (Student)group.StudentList.GetPerson(i);
                dataGridGroupEdit.Rows.Add(group.CurrentGroupId,
                                           student.PersonId,
                                           student.FirstName,
                                           student.MiddleName,
                                           student.LastName,
                                           student.DateOfBirds.ToString("MM/dd/yyyy"));
            }
        }
    }

            if (!matches)
                MessageBox.Show("No matches found!");
    }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewListGroups.Rows.Clear();
            txtSearchParameters.Clear();
        }

        private void btnSubmitGroupEdit_Click(object sender, EventArgs e)
        {
            cmbBoxTeacherIdEdit.Enabled = false;
            cmbBoxStudentIdEdit.Enabled = false;
            StaticsGroupsList.StoreListInXML();
        }

        // add teacher for existing group
        private void btnAddTeacherToGroupEdit_Click(object sender, EventArgs e)
        {
            if (cmbBoxTeacherIdEdit.SelectedItem != null)
            {
                var teacher = (Teacher)cmbBoxTeacherIdEdit.SelectedItem;

                if (!ChechExistingMemberOfGroup(teacher.PersonId))
                {
                    // add teacher to temt list
                    newMemdersOfGroupsList.TeacherList.AddPerson(teacher);

                    this.dataGridGroupEdit.Rows.Add(    currentGroupId,
                                                        teacher.PersonId,
                                                        teacher.FirstName,
                                                        teacher.MiddleName,
                                                        teacher.LastName,
                                                        teacher.DateOfBirds.ToString("MM/dd/yyyy"));
                }
                else MessageBox.Show("This teacher has already been added!");
            }
            else MessageBox.Show("Choose a teacher!");
        }

        private bool ChechExistingMemberOfGroup(string personId)
        {
            for (int i = 0; i < newMemdersOfGroupsList.TeacherList.Count(); i++)
            {
                var teacher = (Teacher)newMemdersOfGroupsList.TeacherList.GetPerson(i);
                if (teacher.PersonId == personId)
                {
                    return true;
                }
            }
            for (int i = 0; i < newMemdersOfGroupsList.StudentList.Count(); i++)
            {
                var student = (Student)newMemdersOfGroupsList.StudentList.GetPerson(i);
                if (student.PersonId == personId)
                {
                    return true;
                }
            }
            return false;
        }
        // add student for existing group
        private void btnAddStudentToGroupEdit_Click(object sender, EventArgs e)
        {

            if (cmbBoxStudentIdEdit.SelectedItem != null)
            {
                var student = (Student)cmbBoxStudentIdEdit.SelectedItem;

                if (!ChechExistingMemberOfGroup(student.PersonId))
                {
                    // add student to temt list
                    newMemdersOfGroupsList.StudentList.AddPerson(student);

                    this.dataGridGroupEdit.Rows.Add(   currentGroupId,
                                                        student.PersonId,
                                                        student.FirstName,
                                                        student.MiddleName,
                                                        student.LastName,
                                                        student.DateOfBirds.ToString("MM/dd/yyyy"));
                }
                else MessageBox.Show("This student has already been added!");
            }
            else MessageBox.Show("Choose a student!");
        }

        private void cmbBoxTeacherIdEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var current = (Teacher)(cmbBoxTeacherIdEdit.SelectedItem);
                if (current != null)
                {
                    cmbBoxTeacherIdEdit.Text = current.PersonId;
                    txtTeacherFirstNameEdit.Text = current.FirstName;
                    txtTeacherMiddleNameEdit.Text = current.MiddleName;
                    txtTeacherLastNameEdit.Text = current.LastName;
                    txtTeacherStatusEdit.Text = current.TeacherStatus.ToString();
                    txtTeacherDateOfBirthEdit.Text = current.DateOfBirds.ToString("MM/dd/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbBoxStudentIdEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var current = (Student)(cmbBoxStudentIdEdit.SelectedItem);
                if (current != null)
                {
                    cmbBoxStudentIdEdit.Text = current.PersonId;
                    txtStudentFirstNameEdit.Text = current.FirstName;
                    txtStudentMiddleNameEdit.Text = current.MiddleName;
                    txtStudentLastNameEdit.Text = current.LastName;
                    txtStudentDateOfBirthEdit.Text = current.DateOfBirds.ToString("MM/dd/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GetListOfGroups()
        {
            try
            {
                StaticsGroupsList.GroupsList = StaticsGroupsList.ReadXML(StaticsGroupsList.FileGroupsList);
            }
            catch (Exception)
            {
                MessageBox.Show("The list of group doesn't exist!");
            }
        }

        private void btnClearAllEdit_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            dataGridGroupEdit.Rows.Clear();
            cmbBoxTeacherIdEdit.Enabled = true;
            cmbBoxStudentIdEdit.Enabled = true;
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

        private void btnDeleteGroupEdit_Click(object sender, EventArgs e)
        {
            string groupId = txtIdGroupSearchEdit.Text;
            if (!string.IsNullOrWhiteSpace(groupId))
            {
                StaticsGroupsList.RemoveGroup(groupId);
                dataGridGroupEdit.Rows.Clear();
                MessageBox.Show("To submit deleting the group, press the button 'Submit Changes'!");
            }
            else MessageBox.Show("Enter group Id!");

        }
        // read all teachers and students from XML to temporary storage
        public void InitializePersonsLists()
        {
            try
            {
                StaticsPersonsList.TeachersList.CurrentPersonList = StaticsPersonsList.TeachersList.ReadXML(StaticsPersonsList.FileTeachersList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                StaticsPersonsList.StudentsList.CurrentPersonList = StaticsPersonsList.StudentsList.ReadXML(StaticsPersonsList.FileStudentsList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearCourseForm_Click_1(object sender, EventArgs e)
        {
            cmbBoxCourseId.SelectedItem = null;
            txtCourseName.Clear();
            txtCourseDuration.Clear();
            txtCoursePrerequisite.Clear();
            txtCourseDescription.Clear();
        }

        private void btnClearTeachefForm_Click_1(object sender, EventArgs e)
        {
            cmbBoxTeacherId.Text = null;
            txtTeacherFirstName.Clear();
            txtTeacherMiddleName.Clear();
            txtTeacherLastName.Clear();
            txtTeacherStatus.Clear();
            txtTeacherDateOfBirth.Clear();
        }

        private void btnClearStudentForm_Click_1(object sender, EventArgs e)
        {
            cmbBoxStudentId.Text = null;
            txtStudentFirstName.Clear();
            txtStudentMiddleName.Clear();
            txtStudentLastName.Clear();
            txtStudentDateOfBirth.Clear();
        }

        private void btnClearCourseFormEdit_Click(object sender, EventArgs e)
        {
            txtCourseIdEdit.Clear();
            txtCourseNameEdit.Clear();
            txtCourseDurationEdit.Clear();
            txtCoursePrerequisiteEdit.Clear();
            txtCourseDescriptionEdit.Clear();
        }

        private void btnClearTeachefFormEdit_Click(object sender, EventArgs e)
        {
            cmbBoxTeacherIdEdit.Text = null;
            txtTeacherFirstNameEdit.Clear();
            txtTeacherMiddleNameEdit.Clear();
            txtTeacherLastNameEdit.Clear();
            txtTeacherStatusEdit.Clear();
            txtTeacherDateOfBirthEdit.Clear();
        }

        private void btnClearStudentFormEdit_Click(object sender, EventArgs e)
        {
            cmbBoxStudentIdEdit.Text = null;
            txtStudentFirstNameEdit.Clear();
            txtStudentMiddleNameEdit.Clear();
            txtStudentLastNameEdit.Clear();
            txtStudentDateOfBirthEdit.Clear();
        }
    }
}
