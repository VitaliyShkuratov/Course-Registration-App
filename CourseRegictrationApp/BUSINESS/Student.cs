using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegictrationApp.BUSINESS
{
    public class Student : Person
    {
        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public Student() : base()
        {

        }
        public Student( string _personId,
                        string _firstName,
                        string _middleName,
                        string _lastName,
                        DateTime _dateOfBirds,
                        string _fixedPhone,
                        string _mobilePhone,
                        string _email,
                        string _currentDistict,
                        string _streetName,
                        string _apparmentNumber)
                        : base (_personId,
                                _firstName,
                                _middleName,
                                _lastName,
                                _dateOfBirds,
                                _fixedPhone,
                                _mobilePhone,
                                _email,
                                _currentDistict,
                                _streetName,
                                _apparmentNumber)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
