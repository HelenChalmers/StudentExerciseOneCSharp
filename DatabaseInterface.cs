using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections;
using Dapper;
using StudentExercises;

namespace StudentExercises.Data
{
    public class DatabaseInterface
    {
            public static SqliteConnection Connection
        {
            //this is the connection to the database.
            get
            {
                string connectionString = $"Data Source=./StudentExercises.db";
                return new SqliteConnection(connectionString);
            }
        }    

            public static void CheckExerciseTable()
        {
            SqliteConnection db = DatabaseInterface.Connection;

            try
            {
                /*
                    new variable that is of type List of Department.
                    Query is Dapper method to be able to query the database
                    query also has to be typed of what you expect to get back 
                    what should be created from that data you're querying? 
                    In this case, department instances from the data that comes back
                    It will create object instances based on the cs models we have created - so for example, the db has 3 departments, so we get back 3 instances of departments with the Id and DeptName back in each instance with the data from the db
                 */ 
                List<Exercise> exercise = db.Query<Exercise>
                // select = what to do on the database side 
                    ("SELECT Id FROM Exercise").ToList();
            }
            // if the database table doesn't exist, check the exception and if there is no table, create the table
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("no such table"))
                {
                    // execute statement to make a new table into database
                    db.Execute(@"CREATE TABLE `Exercise` (
                        `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
                        `Name` TEXT NOT NULL,
                        `Language` TEXT NOT NULL
                    )");

                    db.Execute(@"
                    INSERT INTO Exercise (Name, Language) VALUES ('Loops', 'Javascript);
                    INSERT INTO Exercise (Name, Language) VALUES ('Lists', 'CSharp');
                    INSERT INTO Exercise (Name, Language) VALUES ('Modals', 'Bootstrap');
                    ");
                }
            }
        }
        }

    }



