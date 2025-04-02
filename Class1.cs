using System;

namespace StudentGradeManager
{
    public class Student
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
        public string Grade { get; set; }

        public Student(string studentID, string firstName, string lastName, string className, string grade)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            ClassName = className;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{StudentID} - {LastName}, {FirstName} - {ClassName} {Grade}";
        }
    }
}
