using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CourseRegictrationApp.BUSINESS
{
    public class GenericList<T> where T:Person
    {

        private  List<T> currentPersonList ;

        public GenericList() {
            currentPersonList = new List<T>();
        }
        public  List<T> CurrentPersonList
        {
            get { return currentPersonList; }
            set { currentPersonList = value; }
        }
        
        public void AddPerson(T newPerson)
        {
            currentPersonList.Add(newPerson);
        }

        public T GetPerson(int index )
        {
            return currentPersonList[index];
        }
        public void RemovePerson(string personId)
        {
            foreach (var current in currentPersonList)
            {
                if (personId == current.PersonId)
                {
                    currentPersonList.Remove(current);
                    break;
                }
            }
        }

        public string GetPersonList()
        {
            string person = "";
            foreach (var current in currentPersonList)
            {
                person += current + "\r\n";
            }
            return person;
        }
        public int Count() {
            return this.currentPersonList.Count;
        }

        public bool CheckExistingPerson( string firstName,
                                                string middleName,
                                                string lastName,
                                                DateTime dateOfBirds)
        {
            foreach (var current in currentPersonList)
            {
                if (current.FirstName.Equals(firstName) &&
                    current.LastName.Equals(lastName) &&
                    current.MiddleName.Equals(middleName) &&
                    current.DateOfBirds.ToString("MM/dd/yyyy").Equals(dateOfBirds.ToString("MM/dd/yyyy")))
                    return true;
            }
            return false;
        }

        public bool CheckExistingPerson(string personId)
        {
            foreach (var current in currentPersonList)
            {
                if (current.PersonId == personId)
                    return true;
            }
            return false;
        }

        //write to XML file
        public void StoreListInXML(string FileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(FileName, settings))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                xmlSerializer.Serialize(writer, currentPersonList);
            }
        }
        // reade from XML file
        public  List<T> ReadXML(string FileName)
        {
            List<T> data = null;
            using (StreamReader streamReader = new StreamReader(FileName))
            {
                using (XmlReader reader = XmlReader.Create(streamReader))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                    data = (List<T>)xmlSerializer.Deserialize(reader);
                }
            }


            return data;
        }
        public override string ToString()
        {
            string person = "";
            foreach (var current in currentPersonList)
            {
                person += current + "\r\n";
            }
            return person;
        }
    }
}
