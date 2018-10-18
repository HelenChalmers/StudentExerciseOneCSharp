// You must define a type for representing an instructor in code.

// First name
// Last name
// Slack handle
// The instructor's cohort
// A method to assign an exercise to a student

using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName {
            get {
                return $"{FirstName} {LastName}";
            }
        }
        public string SlackHandle { get; set; }

        public int CohortId {get; set; }
        public Cohort Cohort { get; set; }
        // Constructor  - used to construct an object.
        public Instructor (string firstName, string lastName, string slackHandle, Cohort cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }

        // Assign an exercise to a student
        public void AssignExercise(Student student, Exercise exercise){
                student.Exercises.Add(exercise);

        }

public Instructor ()
        {

        }



    }

}