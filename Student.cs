using System;
using System.Collections.Generic;

namespace StudentExercises
{
     public class Student

//     Properties
// First name
// Last name
// Slack handle
// The student's cohort
// The collection of exercises that the student is currently working on
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName {
            get {
                return $"{FirstName} {LastName}";
            }
        }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();
    
        public Student (string firstName, string lastName, string slackHandle, Cohort cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }
    
    }
}
