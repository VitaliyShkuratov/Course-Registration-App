using CourseRegictrationApp.BUSINESS;
using System;
using System.Windows.Forms;

namespace CourseRegictrationApp.GUI
{
    public partial class TabsFormTeachers : Form
    {
        private string searchTeacherId = "";
        public TabsFormTeachers()
        {
            InitializeComponent();
            SetMyCustomFormat();
            FillDistrictComboBox();
            FillTeacherStatusComboBox();
        }
        public void FillTeacherStatusComboBox()
        {
            foreach (var current in Enum.GetValues(typeof(TeacherStatus)))
            {
                cmbBoxTeacherStatus.Items.Add(current);
                cmbBoxTeacherStatusEdit.Items.Add(current);
            }
        }

        public void FillDistrictComboBox()
        {
            foreach (var district in Districts.DistricsList)
            {
                cmbBoxTeacherDistricts.Items.Add(district.Key + ", " + district.Value);
                cmbBoxTeacherDistrictsEdit.Items.Add(district.Key + ", " + district.Value);
            }
        }
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            pickerTeacherDateOfBirth.Format = DateTimePickerFormat.Custom;
            pickerTeacherDateOfBirthEdit.Format = DateTimePickerFormat.Custom;
            pickerTeacherDateOfBirthEdit.CustomFormat = "MMMM/dd/yyyy";
            pickerTeacherDateOfBirth.CustomFormat = "MMMM/dd/yyyy";
        }

        private void btnAddNewTeacher_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtTeacherFirstName.Text) &&
               !string.IsNullOrWhiteSpace(txtTeacherLastName.Text) &&
               !string.IsNullOrWhiteSpace(txtTeacherStreetName.Text) &&
               cmbBoxTeacherDistricts.SelectedItem != null &&
               cmbBoxTeacherStatus.SelectedItem != null)
            {
                string firstName = txtTeacherFirstName.Text;

                string middleName = txtTeacherMiddleName.Text;
                string lastName = txtTeacherLastName.Text;
                DateTime dateOfBirds = pickerTeacherDateOfBirth.Value;
                string fixedPhone = txtTeacherFixedPhone.Text;
                string mobilePhone = txtTeacherMobilePhone.Text;
                string email = txtTeacherEmail.Text;
                string streetName = txtTeacherStreetName.Text;
                string apparmentNumber = txtTeacherAppartmentNumber.Text;

                string currentDistict = cmbBoxTeacherDistricts.SelectedItem.ToString();

                TeacherStatus teacherStatus = (TeacherStatus)cmbBoxTeacherStatus.SelectedIndex;

                if (!StaticsPersonsList.TeachersList.CheckExistingPerson(firstName,
                                        middleName,
                                        lastName,
                                        dateOfBirds))
                {
                    string personId = PersonId.getNewTeacherId(); // Generate teacher ID
                    StaticsPersonsList.TeachersList.AddPerson(new Teacher(personId,
                                                        firstName,
                                                        middleName,
                                                        lastName,
                                                        dateOfBirds,
                                                        fixedPhone,
                                                        mobilePhone,
                                                        email,
                                                        teacherStatus,
                                                        currentDistict,
                                                        streetName,
                                                        apparmentNumber));


                    Address address = new Address(currentDistict, streetName, apparmentNumber);
                    this.dataGridAddTeacher.Rows.Add(personId.ToString(),
                                                        firstName,
                                                        middleName,
                                                        lastName,
                                                        dateOfBirds.ToString("MM/dd/yyyy"),
                                                        fixedPhone,
                                                        mobilePhone,
                                                        email,
                                                        teacherStatus,
                                                        address);
                    try
                    {
                        StaticsPersonsList.TeachersList.StoreListInXML(StaticsPersonsList.FileTeachersList);
                    }
                    catch (Exception exception)
                    {

                        MessageBox.Show(exception.Message);
                    }
                }
                else MessageBox.Show(Common.returnMessagePersonExist());
            }
            else
            {
                MessageBox.Show(Common.returnMessageEmptyValue());
            }
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

        private void btnClearTeacherForm_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
        }

        private void btnFindTeacher_Click(object sender, EventArgs e)
        {
            dataGridViewListTeachers.Rows.Clear();
            bool matches = false;
            string searchParam = txtSearchParameters.Text;
            try
            {
                StaticsPersonsList.TeachersList.CurrentPersonList = StaticsPersonsList.TeachersList.ReadXML(StaticsPersonsList.FileTeachersList);
                if (StaticsPersonsList.TeachersList.CurrentPersonList != null)
                {
                    if (!string.IsNullOrWhiteSpace(searchParam))
                    {
                        for (int i = 0; i < StaticsPersonsList.TeachersList.Count(); i++)
                        {
                            Teacher teacher = (Teacher)StaticsPersonsList.TeachersList.GetPerson(i);
                            if ((teacher.PersonId.ToLower() == searchParam.ToLower()) ||
                                (teacher.FirstName.ToLower() == searchParam.ToLower()) ||
                                (teacher.MiddleName.ToLower() == searchParam.ToLower()) ||
                                (teacher.LastName.ToLower() == searchParam.ToLower()))
                            {
                                this.dataGridViewListTeachers.Rows.Add(teacher.PersonId,
                                                                        teacher.FirstName,
                                                                        teacher.MiddleName,
                                                                        teacher.LastName,
                                                                        teacher.DateOfBirds.ToString("MM/dd/yyyy"),
                                                                        teacher.FixedPhone,
                                                                        teacher.MobilePhone,
                                                                        teacher.Email,
                                                                        teacher.TeacherStatus,
                                                                        teacher.CurrentAddress);
                                matches = true;
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
                    MessageBox.Show("The list of teachers empty!");
                }

                if (!matches)
                    MessageBox.Show("No matches found!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplayAllTeachers_Click(object sender, EventArgs e)
        {
            dataGridViewListTeachers.Rows.Clear();
            try
            {
                StaticsPersonsList.TeachersList.CurrentPersonList = StaticsPersonsList.TeachersList.ReadXML(StaticsPersonsList.FileTeachersList);
                if (StaticsPersonsList.TeachersList.CurrentPersonList != null)
                {
                    for (int i = 0; i < StaticsPersonsList.TeachersList.Count(); i++)
                    {
                        Teacher teacher = (Teacher)StaticsPersonsList.TeachersList.GetPerson(i);
                        this.dataGridViewListTeachers.Rows.Add(teacher.PersonId,
                                                              teacher.FirstName,
                                                              teacher.MiddleName,
                                                              teacher.LastName,
                                                              teacher.DateOfBirds.ToString("MM/dd/yyyy"),
                                                              teacher.FixedPhone,
                                                              teacher.MobilePhone,
                                                              teacher.Email,
                                                              teacher.TeacherStatus,
                                                              teacher.CurrentAddress);
                    }
                }
                else MessageBox.Show("The list of teachers empty!");
            }
            catch (Exception)
            {
                MessageBox.Show("Create list of teachers first of all!");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewListTeachers.Rows.Clear();
            txtSearchParameters.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridAddTeacher.Rows.Clear();
            ClearAllText(this);
        }

        private void btnFindTeacherEdit_Click(object sender, EventArgs e)
        {
            dataGridViewEditTeacher.Rows.Clear();
            bool matches = false;
            searchTeacherId = txtIdTeacherEditSearch.Text;
            try
            {
                StaticsPersonsList.TeachersList.CurrentPersonList = StaticsPersonsList.TeachersList.ReadXML(StaticsPersonsList.FileTeachersList);
                if (StaticsPersonsList.TeachersList.CurrentPersonList != null)
                {
                    if (!string.IsNullOrWhiteSpace(searchTeacherId))
                    {
                        for (int i = 0; i < StaticsPersonsList.TeachersList.Count(); i++)
                        {
                            Teacher teacher = (Teacher)StaticsPersonsList.TeachersList.GetPerson(i);

                            if (teacher.PersonId.ToLower() == searchTeacherId.ToLower())
                            {
                                txtTeacherFirstNameEdit.Text = teacher.FirstName;
                                txtTeacherMiddleNameEdit.Text = teacher.MiddleName;
                                txtTeacherLastNameEdit.Text = teacher.LastName;
                                pickerTeacherDateOfBirthEdit.Value = teacher.DateOfBirds;
                                txtTeacherFixedPhoneEdit.Text = teacher.FixedPhone;
                                txtTeacherMobilePhoneEdit.Text = teacher.MobilePhone;
                                txtTeacherEmailEdit.Text = teacher.Email;
                                txtTeacherStreetNameEdit.Text = teacher.CurrentAddress.StreetName;
                                txtTeacherAppartmentNumberEdit.Text = teacher.CurrentAddress.ApparmentNumber;

                                cmbBoxTeacherDistrictsEdit.SelectedItem = teacher.CurrentAddress.CurrentDistict;

                                cmbBoxTeacherStatusEdit.SelectedItem = teacher.TeacherStatus;

                                this.dataGridViewEditTeacher.Rows.Add(teacher.PersonId,
                                                                        teacher.FirstName,
                                                                        teacher.MiddleName,
                                                                        teacher.LastName,
                                                                        teacher.DateOfBirds.ToString("MM/dd/yyyy"),
                                                                        teacher.FixedPhone,
                                                                        teacher.MobilePhone,
                                                                        teacher.Email,
                                                                        teacher.TeacherStatus,
                                                                        teacher.CurrentAddress);
                                matches = true;
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
                    MessageBox.Show("The list of teachers empty!");
                }

                if (!matches)
                    MessageBox.Show("No matches found!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            StaticsPersonsList.TeachersList.RemovePerson(searchTeacherId);

            try
            {
                StaticsPersonsList.TeachersList.StoreListInXML(StaticsPersonsList.FileTeachersList);
                dataGridViewEditTeacher.Rows.Clear();
                ClearAllText(this);
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void btnClearTeacherForm_Click_1(object sender, EventArgs e)
        {
            ClearAllText(this);
        }

        private void btnSubmitStudentEdit_Click(object sender, EventArgs e)
        {
            dataGridViewEditTeacher.Rows.Clear();

            for (int i = 0; i < StaticsPersonsList.TeachersList.Count(); i++)
            {
                Teacher teacher = (Teacher)StaticsPersonsList.TeachersList.GetPerson(i);

                if (teacher.PersonId.ToLower() == searchTeacherId.ToLower())
                {
                    teacher.FirstName = txtTeacherFirstNameEdit.Text;
                    teacher.MiddleName = txtTeacherMiddleNameEdit.Text;
                    teacher.LastName = txtTeacherLastNameEdit.Text;
                    teacher.DateOfBirds = pickerTeacherDateOfBirthEdit.Value;
                    teacher.FixedPhone = txtTeacherFixedPhoneEdit.Text;
                    teacher.MobilePhone = txtTeacherMobilePhoneEdit.Text;
                    teacher.Email = txtTeacherEmailEdit.Text;
                    teacher.CurrentAddress.StreetName = txtTeacherStreetNameEdit.Text;
                    teacher.CurrentAddress.ApparmentNumber = txtTeacherAppartmentNumberEdit.Text;
                    teacher.CurrentAddress.CurrentDistict = cmbBoxTeacherDistrictsEdit.SelectedItem.ToString();

                    teacher.TeacherStatus = (TeacherStatus)cmbBoxTeacherStatusEdit.SelectedIndex;

                    this.dataGridViewEditTeacher.Rows.Add(teacher.PersonId,
                                                            teacher.FirstName,
                                                            teacher.MiddleName,
                                                            teacher.LastName,
                                                            teacher.DateOfBirds.ToString("MM/dd/yyyy"),
                                                            teacher.FixedPhone,
                                                            teacher.MobilePhone,
                                                            teacher.Email,
                                                            teacher.TeacherStatus,
                                                            teacher.CurrentAddress);
                }
            }

            try
            {
                StaticsPersonsList.TeachersList.StoreListInXML(StaticsPersonsList.FileTeachersList);
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }
    }
}
