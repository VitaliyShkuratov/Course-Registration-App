using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegictrationApp.BUSINESS
{
    public static class StaticsPersonsList
    {
        public static readonly string FileStudentsList = @"../../DATA/StudentsList.xml";
        public static readonly string FileTeachersList = @"../../DATA/TeachersList.xml";
        public static GenericList<Student> StudentsList = new GenericList<Student>();
        public static GenericList<Teacher> TeachersList = new GenericList<Teacher>();
    }


}
