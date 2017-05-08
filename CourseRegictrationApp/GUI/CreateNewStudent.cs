using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseRegictrationApp.BUSINESS;
using System.Diagnostics;
using System.Collections;

namespace CourseRegictrationApp.GUI
{
    public partial class CreateNewStudent : Form
    {
        public CreateNewStudent()
        {
            InitializeComponent();
        }

        private void CollegeCourseManagement_Load(object sender, EventArgs e)
        {
            
            SetMyCustomFormat();
            FillComboBox();
        }
        public void FillComboBox()
        {
            foreach (var district in Districts.DistricsList)
            {
                cmbBoxDistricts.Items.Add(district.Key + ", " + district.Value);
            }
        }
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            pickerStudentDateOfBirth.Format = DateTimePickerFormat.Custom;
            pickerStudentDateOfBirth.CustomFormat = "MMMM/dd/yyyy";
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
