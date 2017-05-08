using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegictrationApp.BUSINESS
{
    public class Person
    {
        private const string dateFormat = "MM/dd/yyyy";
        private string personId;
        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime dateOfBirds;
        private Address currentAddress;
        private string fixedPhone;
        private string mobilePhone;
        private string email;

        public string PersonId
        {
            get { return personId; }
            set { personId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime DateOfBirds
        {
            get { return dateOfBirds; }
            set { dateOfBirds = value; }
        }

        public Address CurrentAddress
        {
            get { return currentAddress; }
            set { currentAddress = value; }
        }

        public string FixedPhone
        {
            get { return fixedPhone; }
            set { fixedPhone = value; }
        }

        public string MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Person()
        {
            this.personId = "unknown";
            this.firstName = "unknown";
            this.middleName = "unknown";
            this.lastName = "unknown";
            this.dateOfBirds = DateTime.MinValue; 
            this.fixedPhone = "unknown";
            this.mobilePhone = "unknown";
            this.email = "unknown";
            this.currentAddress = new Address();
        }

        public Person(  string _personId,
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
        {
            this.personId = _personId;
            this.firstName = _firstName;
            this.middleName = _middleName;
            this.lastName = _lastName;
            this.dateOfBirds = _dateOfBirds;
            this.fixedPhone = _fixedPhone;
            this.mobilePhone = _mobilePhone;
            this.email = _email;
            this.currentAddress = new Address(  _currentDistict,
                                                _streetName,
                                                _apparmentNumber);
        }

        public override string ToString()
        {
            return  this.personId + " " + 
                    this.firstName + " " +
                    this.middleName + " " +
                    this.lastName + " " +
                    this.dateOfBirds.ToString(dateFormat) + " " +
                    this.currentAddress + " " +
                    this.fixedPhone + " " +
                    this.mobilePhone + " " +
                    this.email;
        }
    }
}
