using CourseRegictrationApp.BUSINESS;
using System;
using System.Windows.Forms;

namespace CourseRegictrationApp.GUI
{
    public partial class TabsFormStudents : Form
    {
        private string searchStudentId = "";
        public TabsFormStudents()
        {
            InitializeComponent();
            SetMyCustomFormat();
            InitializeComboBoxDistricts();
            InitializeGrpStudentCreateField();
        }

        private void InitializeGrpStudentCreateField()
        {
            dataGridAddNewStudent.ScrollBars = ScrollBars.Horizontal;
            dataGridAddNewStudent.ScrollBars = ScrollBars.Vertical;
        }
        private void InitializeComboBoxDistricts()
        {
            cmbBoxDistricts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxDistricts.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbBoxDistrictsEdit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxDistrictsEdit.AutoCompleteSource = AutoCompleteSource.ListItems;

            foreach (var district in Districts.DistricsList)
            {
                cmbBoxDistricts.Items.Add(district.Key + ", " + district.Value);
                cmbBoxDistrictsEdit.Items.Add(district.Key + ", " + district.Value);
            }
        }
        private void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            pickerStudentDateOfBirth.Format = DateTimePickerFormat.Custom;
            pickerStudentDateOfBirth.CustomFormat = "MMMM/dd/yyyy";

            pickerStudentDateOfBirthEdit.Format = DateTimePickerFormat.Custom;
            pickerStudentDateOfBirthEdit.CustomFormat = "MMMM/dd/yyyy";
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtStudentFirstName.Text) &&
               !string.IsNullOrWhiteSpace(txtStudentLastName.Text) &&
               !string.IsNullOrWhiteSpace(txtStudentStreetName.Text) &&
               cmbBoxDistricts.SelectedItem != null)
            {
                string firstName = txtStudentFirstName.Text;

                string middleName = txtStudentMiddleName.Text;
                string lastName = txtStudentLastName.Text;
                DateTime dateOfBirds = pickerStudentDateOfBirth.Value;
                string fixedPhone = txtStudentFixedPhone.Text;
                string mobilePhone = txtStudentMobilePhone.Text;
                string email = txtStudentEmail.Text;
                string streetName = txtStudentStreetName.Text;
                string apparmentNumber = txtStudentAppartmentNumber.Text;
                string currentDistict = cmbBoxDistricts.SelectedItem.ToString();


                if (!StaticsPersonsList.StudentsList.CheckExistingPerson(firstName, // For generic
                                        middleName,
                                        lastName,
                                        dateOfBirds))
                {
                    string personId = PersonId.getNewStudentId(); // Generate Student ID
                    StaticsPersonsList.StudentsList.AddPerson(new Student(personId,
                                      firstName,
                                     middleName,
                                     lastName,
                                     dateOfBirds,
                                     fixedPhone,
                                     mobilePhone,
                                     email,
                                     currentDistict,
                                     streetName,
                                     apparmentNumber));

                    Address address = new Address(currentDistict, streetName, apparmentNumber);
                    this.dataGridAddNewStudent.Rows.Add(personId.ToString(),
                                                        firstName,
                                                        middleName,
                                                        lastName,
                                                        dateOfBirds.ToString("MM/dd/yyyy"),
                                                        fixedPhone,
                                                        mobilePhone,
                                                        email,
                                                        address);

                    try
                    {
                        StaticsPersonsList.StudentsList.StoreListInXML(StaticsPersonsList.FileStudentsList);
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



        private void btnClear_Click(object sender, EventArgs e)
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

        private void btnDisplayAllStudents_Click(object sender, EventArgs e)
        {
            dataGridViewListStudents.Rows.Clear();
            try
            {
                StaticsPersonsList.StudentsList.CurrentPersonList = StaticsPersonsList.StudentsList.ReadXML(StaticsPersonsList.FileStudentsList);
                if (StaticsPersonsList.StudentsList.CurrentPersonList != null)
                {
                    for (int i = 0; i < StaticsPersonsList.StudentsList.Count(); i++)
                    {
                        Student student = (Student)StaticsPersonsList.StudentsList.GetPerson(i);
                        this.dataGridViewListStudents.Rows.Add(student.PersonId,
                                                              student.FirstName,
                                                              student.MiddleName,
                                                              student.LastName,
                                                              student.DateOfBirds.ToString("MM/dd/yyyy"),
                                                              student.FixedPhone,
                                                              student.MobilePhone,
                                                              student.Email,
                                                              student.CurrentAddress);
                    }
                }
                else MessageBox.Show("The list of students empty!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearStudentForm_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            dataGridViewListStudents.Rows.Clear();
            bool matches = false;
            string searchParam = txtSearchParameters.Text;
            try
            {
                StaticsPersonsList.StudentsList.CurrentPersonList = StaticsPersonsList.StudentsList.ReadXML(StaticsPersonsList.FileStudentsList);
                if (StaticsPersonsList.StudentsList.CurrentPersonList != null)
                {
                    if (!string.IsNullOrWhiteSpace(searchParam))
                    {
                        for (int i = 0; i < StaticsPersonsList.StudentsList.Count(); i++)
                        {
                            Student student = (Student)StaticsPersonsList.StudentsList.GetPerson(i);
                            if ((student.PersonId.ToLower() == searchParam.ToLower()) ||
                                (student.FirstName.ToLower() == searchParam.ToLower()) ||
                                (student.MiddleName.ToLower() == searchParam.ToLower()) ||
                                (student.LastName.ToLower() == searchParam.ToLower()))
                            {
                                this.dataGridViewListStudents.Rows.Add(student.PersonId,
                                                                        student.FirstName,
                                                                        student.MiddleName,
                                                                        student.LastName,
                                                                        student.DateOfBirds.ToString("MM/dd/yyyy"),
                                                                        student.FixedPhone,
                                                                        student.MobilePhone,
                                                                        student.Email,
                                                                        student.CurrentAddress);
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
                    MessageBox.Show("The list of students empty!");
                }

                if (!matches)
                    MessageBox.Show("No matches found!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            dataGridViewListStudents.Rows.Clear();
            txtSearchParameters.Clear();
        }

        private void btnFindStudentEdit_Click(object sender, EventArgs e)
        {
            dataGridViewEditStudent.Rows.Clear();
            bool matches = false;
            searchStudentId = txtIdStudentEditSearch.Text;
            try
            {
                StaticsPersonsList.StudentsList.CurrentPersonList = StaticsPersonsList.StudentsList.ReadXML(StaticsPersonsList.FileStudentsList);
                if (StaticsPersonsList.StudentsList.CurrentPersonList != null)
                {
                    if (!string.IsNullOrWhiteSpace(searchStudentId))
                    {
                        for (int i = 0; i < StaticsPersonsList.StudentsList.Count(); i++)
                        {
                            Student student = (Student)StaticsPersonsList.StudentsList.GetPerson(i);

                            if (student.PersonId.ToLower() == searchStudentId.ToLower())
                            {
                                txtStudentFirstNameEdit.Text = student.FirstName;
                                txtStudentMiddleNameEdit.Text = student.MiddleName;
                                txtStudentLastNameEdit.Text = student.LastName;
                                pickerStudentDateOfBirthEdit.Value = student.DateOfBirds;
                                txtStudentFixedPhoneEdit.Text = student.FixedPhone;
                                txtStudentMobilePhoneEdit.Text = student.MobilePhone;
                                txtStudentEmailEdit.Text = student.Email;
                                txtStudentStreetNameEdit.Text = student.CurrentAddress.StreetName;
                                txtStudentAppartmentNumberEdit.Text = student.CurrentAddress.ApparmentNumber;
                                cmbBoxDistrictsEdit.SelectedItem = student.CurrentAddress.CurrentDistict;

                                this.dataGridViewEditStudent.Rows.Add(student.PersonId,
                                                                        student.FirstName,
                                                                        student.MiddleName,
                                                                        student.LastName,
                                                                        student.DateOfBirds.ToString("MM/dd/yyyy"),
                                                                        student.FixedPhone,
                                                                        student.MobilePhone,
                                                                        student.Email,
                                                                        student.CurrentAddress);
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
                    MessageBox.Show("The list of students empty!");
                }

                if (!matches)
                    MessageBox.Show("No matches found!");
            }
            catch (Exception)
            {

                MessageBox.Show("Create list of students first of all!");
            }
        }

        private void btnSubmitStudentEdit_Click(object sender, EventArgs e)
        {
            dataGridViewEditStudent.Rows.Clear();

            for (int i = 0; i < StaticsPersonsList.StudentsList.Count(); i++)
            {
                Student student = (Student)StaticsPersonsList.StudentsList.GetPerson(i);

                if (student.PersonId.ToLower() == searchStudentId.ToLower())
                {
                    student.FirstName = txtStudentFirstNameEdit.Text;
                    student.MiddleName = txtStudentMiddleNameEdit.Text;
                    student.LastName = txtStudentLastNameEdit.Text;
                    student.DateOfBirds = pickerStudentDateOfBirthEdit.Value;
                    student.FixedPhone = txtStudentFixedPhoneEdit.Text;
                    student.MobilePhone = txtStudentMobilePhoneEdit.Text;
                    student.Email = txtStudentEmailEdit.Text;
                    student.CurrentAddress.StreetName = txtStudentStreetNameEdit.Text;
                    student.CurrentAddress.ApparmentNumber = txtStudentAppartmentNumberEdit.Text;
                    student.CurrentAddress.CurrentDistict = cmbBoxDistrictsEdit.SelectedItem.ToString();

                    this.dataGridViewEditStudent.Rows.Add(student.PersonId,
                                                            student.FirstName,
                                                            student.MiddleName,
                                                            student.LastName,
                                                            student.DateOfBirds.ToString("MM/dd/yyyy"),
                                                            student.FixedPhone,
                                                            student.MobilePhone,
                                                            student.Email,
                                                            student.CurrentAddress);
                }
            }

            try
            {
                StaticsPersonsList.StudentsList.StoreListInXML(StaticsPersonsList.FileStudentsList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            StaticsPersonsList.StudentsList.RemovePerson(searchStudentId);

            try
            {
                StaticsPersonsList.StudentsList.StoreListInXML(StaticsPersonsList.FileStudentsList);
                dataGridViewEditStudent.Rows.Clear();
                ClearAllText(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearAddNewStudent_Click(object sender, EventArgs e)
        {
            dataGridAddNewStudent.Rows.Clear();
            ClearAllText(this);
        }
    }
}

