using System;
using System.Collections.Generic;
using System.Text;

namespace SkullLearningGiorgio
{
    internal class GradeBook
    {
        List<Half>? grades;
        public String FirstName;
        public String LastName;
        public String Class;

        public GradeBook(String Name,String SurName)
        { 
            grades = new List<Half>();
            FirstName = new string(Name);
            LastName = new string(SurName);
            FirstName = Name;
            LastName = SurName;

        }
        public GradeBook(string firstName, string lastName, string classes,Half firstGrade)
        {
            grades = [firstGrade];
            FirstName = firstName;
            LastName = lastName;
            Class = classes;
        }

        public void addGrade(Half grade)
        {
            grades.Add(grade);
         
        }









        public override string ToString()
        {
            String result;
            result = $"[FirstName:{this.FirstName};SurName:{this.LastName};Class:{this.Class};Grades:{this.grades}";
            return result;
        }


        
    }
}
