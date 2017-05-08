using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace CourseRegictrationApp.BUSINESS
{
    public static class StaticsGroupsList
    {
        public static readonly string FileGroupsList = @"../../DATA/GroupList.xml";
        public static List<Group> GroupsList = new List<Group>();

        // add new group to the list
        public static void AddGroup(Group newGroup)
        {
            GroupsList.Add(newGroup);
        }

        //remove group from the list
        public static void RemoveGroup(string groupId)
        {
            foreach (var group in GroupsList)
            {
                if ((group.CurrentGroupId).ToLower() == groupId.ToLower())
                {
                    GroupsList.Remove(group);
                    break;
                }
            }
        }

       
        //write to XML file
        public static void StoreListInXML()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(FileGroupsList, settings))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Group>));
                xmlSerializer.Serialize(writer, GroupsList);
            }
        }
        // reade from XML file
        public static List<Group> ReadXML(string FileName)
        {
            List<Group> data = null;
            using (StreamReader streamReader = new StreamReader(FileName))
            {
                using (XmlReader reader = XmlReader.Create(streamReader))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Group>));
                    data = (List<Group>)xmlSerializer.Deserialize(reader);
                }
            }
            return data;
        }

    }
}
