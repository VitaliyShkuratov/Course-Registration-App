using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegictrationApp.BUSINESS
{
    public enum TeacherStatus { full_time, contract };
    public class Teacher : Person
    {
        private TeacherStatus teacherStatus;

        public TeacherStatus TeacherStatus
        {
            get { return teacherStatus; }
            set { teacherStatus = value; }
        }

        public Teacher() : base()
        {

        }
        public Teacher(string _personId,
                        string _firstName,
                        string _middleName,
                        string _lastName,
                        DateTime _dateOfBirds,
                        string _fixedPhone,
                        string _mobilePhone,
                        string _email,
                        TeacherStatus _teacherStatus,
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
            this.teacherStatus = _teacherStatus;
        }
        public override string ToString()
        {
            return base.ToString() + " " +
                    this.teacherStatus;
        }
    }
}
