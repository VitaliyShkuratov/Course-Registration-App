namespace CourseRegictrationApp.BUSINESS
{
    public class Address
    {
        private const string CountryName = "HAITI";
        private string currentDistict;
        private string streetName;
        private string apparmentNumber;

        public string getCountryName
        {
            get { return CountryName; }
        }

        public string CurrentDistict
        {
            get { return currentDistict; }
            set { currentDistict = value; }
        }

        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }
        public string ApparmentNumber
        {
            get { return apparmentNumber; }
            set { apparmentNumber = value; }
        }

        public Address()
        {
            this.currentDistict = "unknown";
            this.streetName = "unknown";
            this.apparmentNumber = "unknown";

        }
        public Address( string _currentDistict,
                        string _streetName,
                        string _apparmentNumber)
        {
            this.currentDistict = _currentDistict;
            this.streetName = _streetName;
            this.apparmentNumber = _apparmentNumber;

        }
        public override string ToString()
        {
            return this.streetName + ", " +
                   this.apparmentNumber + ", " +
                   this.currentDistict + " " + 
                   CountryName; 
        }
    }
}
