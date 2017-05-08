using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegictrationApp.BUSINESS
{
    public static class CourseList
    {
        private static List<Course> collegeCoursesList = new List<Course>();

        public static List<Course> CollegeCoursesList
        {
            get { return collegeCoursesList; }
            set { collegeCoursesList = value; }
        }
        public static string GetPersonList()
        {
            string courseList = "";
            foreach (var current in collegeCoursesList)
                courseList += current + "\r\n";
            return courseList;
        }
        public static string DisplayCourseDescription(string courseId)
        {
            foreach (var current in collegeCoursesList)
            {
                if (current.CourseId == courseId)
                    return current.ToString();
            }
            return "No courses!";
        }

        public static void AddCourseDescription(Course newCourseDescription)
        {
            collegeCoursesList.Add(newCourseDescription);
        }
        public static void AddCourseDescription() // create predefined courses
        {
            collegeCoursesList.Add(new Course("COM101",
                                                                "INTRODUCTION TO MASS MEDIA",
                                                                "This course is an introduction to the study of mass media. Students will gain an understanding of media history, the structure of media industries (print, electronic, and digital), and their major players. ",
                                                                "none", 
                                                                75));
            collegeCoursesList.Add(new Course("COM102",
                                                                "INTERPERSONAL COMMUNICATION",
                                                                "This course is designed to increase students’ communication knowledge and skills in their relationships with others, including friends, family, coworkers, and romantic partners.",
                                                                "none",
                                                                75));
            collegeCoursesList.Add(new Course("COM150",
                                                                "PRESENTATION SKILLS",
                                                                "The presentation skills course teaches students how to research, structure, and deliver effective oral presentations.It requires active student participation in order to build both skills and confidence.",
                                                                "none",
                                                                75));
            collegeCoursesList.Add(new Course("COM204",
                                                                "INTRODUCTION TO FILM STUDIES",
                                                                "This is a survey course that serves to introduce film both as an industry and an art form.Subject matter includes film techniques, styles, traditions, and genres; the rudiments of cinematography, editing, sound, script structure, acting, and directing; and the business and economics of film production, distribution, and exhibition.",
                                                                "none",
                                                                75));
            collegeCoursesList.Add(new Course("COM205",
                                                                "COMMUNICATION THEORY AND RESEARCH",
                                                                "This course introduces students to interpersonal communication, mass communication, and persuasion theories.The nature of—and differences between—social scientific and humanistic theories will be discussed.",
                                                                "none",
                                                                75));
            collegeCoursesList.Add(new Course("COM206",
                                                                "FUNDAMENTALS OF JOURNALISM",
                                                                "This is a beginning journalism course that introduces students to basic news reporting and writing techniques across multiple platforms, including print, broadcast, and online.",
                                                                "none",
                                                                75));
            collegeCoursesList.Add(new Course("COM207",
                                                                "PRINCIPLES OF PUBLIC RELATIONS",
                                                                "Public relations has been called “the unseen power” that influences culture, business, politics, and society.This class introduces students to the wide-ranging field of public relations, the role it plays in managing organizational relationships of all kinds, and the skills required to succeed in one of the fastest-growing communication professions.",
                                                                "none",
                                                                75));
            collegeCoursesList.Add(new Course("COM208",
                                                                "VIDEO FIELD PRODUCTION",
                                                                "This course introduces students to the fundamental theories and practices of audio and video production.Students will learn how the preproduction, production, and postproduction stages apply to media. Emphasis is on storytelling, the importance of audience research and planning, scheduling, and selecting and employing proper resources.",
                                                                "none",
                                                                75));
            collegeCoursesList.Add(new Course("COM215",
                                                                "GROUP AND TEAM COMMUNICATION",
                                                                "U.S. organizations are requiring group work, including virtual teamwork, more than ever before.In addition, Americans are choosing to join service, social, and self - help groups at an unprecedented rate.",
                                                                "none",
                                                                75));
            collegeCoursesList.Add(new Course("COM267",
                                                                 "COMMUNICATION AND CONFLICT MANAGEMENT",
                                                                "Course Description: This course focuses on the nature and function of healthy and unhealthy conflict communication.Content incorporates theories of conflict and the application of effective conflict management techniques.",
                                                                "none",
                                                                75));
            collegeCoursesList.Add(new Course("COM300",
                                                                 "COMMUNICATION ETHICS",
                                                                "This course provides students with an overview of ethical standards relevant to social behavior and an in-depth study of contemporary ethical issues facing communicators.",
                                                                "none",
                                                                75));
            collegeCoursesList.Add(new Course("COM301",
                                                                "MEDIA IN AMERICA",
                                                                "With media mergers, converging technology, and 24-hour instant access, media reach has expanded immensely, making the world a smaller, more connected place.This course explores how the media industry has grown and changed through exploration of the development, economics, regulation, and impact of mass media.",
                                                                "COM 101",
                                                                75));
            collegeCoursesList.Add(new Course("COM302",
                                                                "BROADCAST JOURNALISM",
                                                                "This course entails reporting for TV and radio broadcast with an emphasis on hard news but including some feature stories.",
                                                                "COM 208",
                                                                75));
            collegeCoursesList.Add(new Course("COM319",
                                                                "ADVANCED PERSONAL AND PROFESSIONAL PRESENTATIONS",
                                                                "This course focuses on the practical application of theory and research in public, team, and interpersonal presentations.Students will prepare, deliver, and critique presentations for a variety of professional communication situations.",
                                                                "COM 150",
                                                                75));
            collegeCoursesList.Add(new Course("COM320",
                                                                "COMMUNICATION AND CULTURE ",
                                                                "Students will learn how communication practices vary across cultures. Focus will be on intercultural, cross - cultural, and interethnic communication.",
                                                                "none",
                                                                75));
        }
    }
}
