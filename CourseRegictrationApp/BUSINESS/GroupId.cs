using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegictrationApp.BUSINESS
{
    public static class GroupId
    {
        private const int lengthCourseId = 7;
        private static int groupId = 0;
        private static string coursePrefix;

        public static string CoursePrefix
        {
            get { return coursePrefix; }
            set { coursePrefix = value; }
        }

        // Check existing Group ID 
        private static int GetCurrentGroupId(string _courseId)
        {
            foreach (var group in StaticsGroupsList.GroupsList)
            {
                if ((group.CurrentGroupId).Substring(0, 6) == _courseId)
                {
                    try
                    {
                        groupId = Int32.Parse((group.CurrentGroupId).Substring(7));
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
                else groupId = 0;
            }
            return groupId;
        }
        private static int GenerateNewCourseId(string _courseId)
        {
            int id = GetCurrentGroupId(_courseId);

            if (id <= (Math.Pow(10, id) - 1))
                return ++id;
            else
                return 0;
        }

        public static string GetGroupId(string _courseId)
        {
            int id = GenerateNewCourseId(_courseId);
            if (id > 0)
            {
                string tempId = id.ToString();
                string zeros = "";
                for (int i = 0; i < (lengthCourseId - tempId.Length); i++)
                    zeros += "0";
                return _courseId + "/" + zeros + tempId;
            }
            else return "Id is out of range!";
        }
    }
}
