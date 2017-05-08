using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegictrationApp.BUSINESS
{
    public class Group
    {
        public string CurrentGroupId { get; set; }
        public Course Course { get; set; }
        public GenericList<Student> StudentList { get; set; }
        public GenericList<Teacher> TeacherList { get; set; }

        public Group()
        {
            CurrentGroupId = "unknown";
            Course = null;
            StudentList = null;
            TeacherList = null;
        }
        public Group(   Course _course,
                        GenericList<Teacher> _teacherList,
                        GenericList<Student> _studentList
                        )
        {
            CurrentGroupId = GroupId.GetGroupId(_course.CourseId);
            Course = _course;
            TeacherList = _teacherList;
            StudentList = _studentList;
        }
    }
}
