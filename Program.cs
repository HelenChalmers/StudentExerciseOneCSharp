// The learning objective of this exercise is to practice creating instances of custom types that you defined with class, establishing the relationships between them, and practicing basic data structures in C#.

// Once you have defined all of your custom types, go to your Main() method in Program.cs and implement the following logic.









using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            Exercise lists = new Exercise ("lists", "CSharp");
            Exercise loops = new Exercise ("loops", "Java Script");
            Exercise chickenMonkey = new Exercise ("Chicken Monkey", "Java Script");
            Exercise modals = new Exercise ("modals", "Bootstrap");

            // Create 3, or more, cohorts.
            Cohort Day28 = new Cohort ( "Day Cohort 28");
            Cohort Day27 = new Cohort ( "Day Cohort 27");
            Cohort Day26 = new Cohort ( "Day Cohort 26");

            // Create 4, or more, students and assign them to one of the cohorts.
            Student Dejan = new Student ( "Dejan", "Step", "dejan", Day27);
            Student Jen = new Student ( "Jen", "??", "jen", Day26);
            Student Madi = new Student ( "Madi", "Peper", "madi", Day27);
            Student Lesley = new Student ( "Lesley", "Boyd", "les", Day28);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor Jisie = new Instructor ( "Jisie", "David", "jisie", Day26);
            Instructor Meg  = new Instructor ( "Meg", "Ducharme", "meg", Day27);
            Instructor Jenna = new Instructor ( "Jenna", "Solis", "jenna", Day28);

            // Have each instructor assign 2 exercises to each of the students.
            Jisie.AssignExercise(Dejan, lists);
            Jisie.AssignExercise(Dejan, modals);
            Meg.AssignExercise(Jen, chickenMonkey);
            Meg.AssignExercise(Jen, lists);
            Jenna.AssignExercise(Madi, chickenMonkey);
            Jenna.AssignExercise(Madi, lists);
            Meg.AssignExercise(Lesley, lists);
            Meg.AssignExercise(Lesley, loops);

            // Create a list of students. Add all of the student instances to it.
            List<Student> students = new List<Student> ();
            students.Add(Dejan);
            students.Add(Jen);
            students.Add(Madi);
            students.Add(Lesley);

             // Create a list of exercises. Add all of the exercise instances to it.
            List<Exercise> exercises = new List<Exercise> ();
            exercises.Add (loops);
            exercises.Add (lists);
            exercises.Add (chickenMonkey);
            exercises.Add (modals);

            // Generate a report that displays which students are working on which exercises.
            

        }
    }
}
