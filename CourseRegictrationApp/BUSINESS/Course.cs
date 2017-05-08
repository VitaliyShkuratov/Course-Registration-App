using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegictrationApp.BUSINESS
{
    public class Course
    {
        private string courseId;
        private string courseName;
        private string courseDescription;
        private double courseDuration;
        private string coursePrerequisite;

        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public string CourseDescription
        {
            get { return courseDescription; }
            set { courseDescription = value; }
        }
        public double CourseDuration
        {
            get { return courseDuration; }
            set { courseDuration = value; }
        }
        public string CoursePrerequisite
        {
            get { return coursePrerequisite; }
            set { coursePrerequisite = value; }
        }

        public Course()
        {
            this.courseId = "unknown";
            this.courseName = "unknown";
            this.courseDescription = "unknown";
            this.coursePrerequisite = "none";
            this.courseDuration = 0;
        }
        public Course(  string _courseId,
                        string _courseName,
                        string _courseDescrip,
                        string _coursePrerequisite,
                        double _courseDuration)
        {
            this.courseId = _courseId;
            this.courseName = _courseName;
            this.courseDescription = _courseDescrip;
            this.coursePrerequisite = _coursePrerequisite;
            this.courseDuration = _courseDuration;
        }
        public override string ToString()
        {
            return  this.courseId + " " +
                    this.courseName + " " +
                    this.courseDescription + " " +
                    this.coursePrerequisite + " " +
                    this.courseDuration;
        }
    }
}
