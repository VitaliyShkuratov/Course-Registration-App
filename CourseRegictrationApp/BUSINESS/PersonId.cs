using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegictrationApp.BUSINESS
{
    public static class PersonId
    {
        private const int lengthStudentId = 7;
        private const int lengthTeacherId = 7;
        private const int lengthEmployeeId = 7;
        private const string studentIdPrefix = "ST";
        private const string teacherIdPrefix = "TC";
        private const string employeeIdPrefix = "EM";
        private static int studentId = 0;
        private static int teacherId = 0;
        private static int employeeId = 0;

       private static int generateNewStudentId(int studentId)
        {
            if (studentId <= (Math.Pow(10, studentId) - 1))
                return ++studentId;
            else
            {
                return 0;
            }
        }
        private static int generateNewTeacherId(int teacherId)
        {
            if (studentId <= (Math.Pow(10, studentId) - 1))
                return ++teacherId;
            else
            {
                return 0;
            }
        }
        private static int generateNewEmployeeId(int teacherId)
        {
            if (studentId <= (Math.Pow(10, studentId) - 1))
                return ++employeeId;
            else
            {
                return 0;
            }
        }

        public static string getNewStudentId()
        {
            int id = generateNewStudentId(getLastStudentId());
            if (id > 0)
            {
                string tempId = id.ToString();
                string zeros = "";
                for (int i = 0; i < (lengthStudentId - tempId.Length); i++)
                    zeros += "0";
                return studentIdPrefix + zeros + tempId;
            }
            else return "Id is out of range!";
        }

        public static string getNewTeacherId()
        {
            int id = generateNewTeacherId(getLastTeacherId());
            if (id > 0)
            {
                string tempId = id.ToString();
                string zeros = "";
                for (int i = 0; i < (lengthStudentId - tempId.Length); i++)
                    zeros += "0";
                return teacherIdPrefix + zeros + tempId;
            }
            else return "Id is out of range!";
        }
        public static string getNewEmployeeId()
        {
            int id = generateNewEmployeeId(employeeId);
            if (id > 0)
            {
                string tempId = id.ToString();
                string zeros = "";
                for (int i = 0; i < (lengthStudentId - tempId.Length); i++)
                    zeros += "0";
                return employeeIdPrefix + zeros + tempId;
            }
            else return "Id is out of range!";
        }

        public static int getLastStudentId()
        {
            int lastStudentId = 0;
            try
            {
                StaticsPersonsList.StudentsList.CurrentPersonList = StaticsPersonsList.StudentsList.ReadXML(StaticsPersonsList.FileStudentsList);

                int lastIndex = StaticsPersonsList.StudentsList.CurrentPersonList.Count() - 1;
                string studentId = StaticsPersonsList.StudentsList.GetPerson(lastIndex).PersonId;
                try
                {
                    lastStudentId = Int32.Parse(studentId.Substring(2));
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception)
            {
                lastStudentId = 0;
            }
            return lastStudentId;
        }

        public static int getLastTeacherId()
        {
            int lastTeacherId = 0;
            try
            {
                StaticsPersonsList.TeachersList.CurrentPersonList = StaticsPersonsList.TeachersList.ReadXML(StaticsPersonsList.FileTeachersList);
 
                int lastIndex = StaticsPersonsList.TeachersList.CurrentPersonList.Count() - 1;
                string teacherId = StaticsPersonsList.TeachersList.GetPerson(lastIndex).PersonId;
                try
                {
                    lastTeacherId = Int32.Parse(teacherId.Substring(2));
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception)
            {
                lastTeacherId = 0;
            }
            return lastTeacherId;
        }

    }
}
