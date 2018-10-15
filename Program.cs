// The learning objective of this exercise is to practice creating instances of custom types that you defined with class, establishing the relationships between them, and practicing basic data structures in C#.

// Once you have defined all of your custom types, go to your Main() method in Program.cs and implement the following logic.









using System;
using System.Collections.Generic;
using System.Linq;

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
            Cohort Day29 = new Cohort ("Day Cohort 29");

            // Create 4, or more, students and assign them to one of the cohorts.
            Student Dejan = new Student ( "Dejan", "Step", "dejan", Day27);
            Student Jen = new Student ( "Jen", "??", "jen", Day26);
            Student Madi = new Student ( "Madi", "Peper", "madi", Day27);
            Student Lesley = new Student ( "Lesley", "Boyd", "les", Day28);
            Student avett = new Student ("Avett", "Ducharme", "avett", Day27);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor Jisie = new Instructor ( "Jisie", "David", "jisie", Day26);
            Instructor Meg  = new Instructor ( "Meg", "Ducharme", "meg", Day27);
            Instructor Jenna = new Instructor ( "Jenna", "Solis", "jenna", Day28);
            Instructor Steve = new Instructor ( "Steve", "Brownlee", "steve", Day27);

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
            students.Add(avett);

             // Create a list of exercises. Add all of the exercise instances to it.
            List<Exercise> exercises = new List<Exercise> ();
            exercises.Add (loops);
            exercises.Add (lists);
            exercises.Add (chickenMonkey);
            exercises.Add (modals);

            // Generate a report that displays which students are working on which exercises.
            

//------------------------------------------------------------------------------------------------
        //Student Exercises 2

//For this exercise, you need to create 4 new List instances to Program.cs: one to contain students, one to contain exercises, one to contain instructors, and one to contain cohorts.

// After your code where you created all of your instances, add each one to the lists.


List<Student> studentList = new List<Student>() {
    Dejan,
    Jen,
    Madi,
    Lesley,
    avett
};

List<Exercise> exerciseList = new List<Exercise>() {
    lists,
    loops,
    chickenMonkey,
    modals
};

List<Instructor> instructorList = new List<Instructor>() {
    Jisie,
    Meg,
    Jenna,
    Steve
};

List<Cohort> CohortList = new List<Cohort>() {
    Day26,
    Day27,
    Day28,
    Day29
};

//1. List exercises for the JavaScript language by using the Where() LINQ method
// var jsExercises = exerciseList.Where(a => a[1] == "Java Script").ToList();

IEnumerable<Exercise> jsExercises = from e in exerciseList
where e.Language == "Java Script"
select e;
jsExercises.ToList();
foreach(Exercise e in jsExercises)
{
    Console.WriteLine(e.Name);
}
Console.WriteLine("----------------------------------------");
//2. List students in a particular cohort by using the Where() LINQ method

IEnumerable<Student> studentCohort = from s in studentList
where s.Cohort == Day27
select s;
studentCohort.ToList();
foreach(Student f in studentCohort)
{
    Console.WriteLine(f.FullName);
}
Console.WriteLine("----------------------------------------");
//3. List instructors in a particular cohort by using the Where() LINQ method.
IEnumerable<Instructor> instructorCohort = from i in instructorList
where i.Cohort == Day27
select i;
instructorCohort.ToList();
foreach(Instructor inst in instructorCohort)
{
    Console.WriteLine(inst.FullName);
}
Console.WriteLine("----------------------------------------");
//4. Sort the students by their last name.

List<Student> studentList2 = studentList.OrderBy(n => n.LastName).ToList();

        foreach (Student s in studentList2)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }

Console.WriteLine("----------------------------------------");

//5. Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)

IEnumerable<Student> studentsNoExercis = students.Where(stu => stu.Exercises.Count() == 0).ToList();
foreach(var stud in studentsNoExercis)
{
    Console.WriteLine($"{stud.FullName}");
}


Console.WriteLine("----------------------------------------");
//6. Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
var studentwithMostExerc = (from s in students
select new {
    FirstName = s.FirstName,
    Exercises = s.Exercises.Count()

})
.OrderByDescending(s =>exercises)
.FirstOrDefault();
Console.WriteLine($"students with the most Exercises{studentwithMostExerc.FirstName} with {studentwithMostExerc.Exercises}");



Console.WriteLine("----------------------------------------");
//7. How many students in each cohort?
//groupby
var numStuPerCohort = students.GroupBy(n => n.Cohort.Name);
foreach( var s in numStuPerCohort)
{
    Console.WriteLine($"{s.Key} has {s.Count()} students");
}


        }
    }
}
