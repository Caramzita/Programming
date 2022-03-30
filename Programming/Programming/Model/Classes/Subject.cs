using System;

namespace Programming.Model.Classes
{
    public class Subject
    {
        public Subject()
        {
        }

        public Subject(string name,
            string teacherName,
            double grade)
        {
            Name = name;
            TeacherName = teacherName;
            Grade = grade;
        }

        public string Name { get; set; }

        public string TeacherName { get; set; }

        public double Grade { get; set; }
    }
}
