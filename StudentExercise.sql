INSERT INTO Cohort (Name)
VALUES ("Day Cohort 25")
;

INSERT INTO Cohort (Name)
VALUES ("Day Cohort 26")
;

INSERT INTO Cohort (Name)
VALUES ("Day Cohort 27")
;

INSERT INTO Cohort (Name)
VALUES ("Day Cohort 28")
;

INSERT INTO Exercise (Name, Language)
VALUES ("Loop", "CSHARP")
;

UPDATE Exercise 
	SET Name = "Loops"
	WHERE Id = 1
	;
	
	UPDATE Exercise
	SET Language = "Javascript"
	WHERE Id = 1
	;
	
	UPDATE Exercise
	SET Name = "Lists"
	WHERE Id = 2
	;
	
	INSERT INTO Exercise (Name, Language)
VALUES ("ChickenMonkey", "Javascript")
;

INSERT INTO Exercise (Name, Language)
VALUES ("Modals", "BootStrap")
;

--Instructor
INSERT INTO Instructor (FirstName, LastName, SlackHandle, CohortId)
VALUES("Steve", "BrownLee", "Steveo", 3)
;

UPDATE Instructor
SET FirstName = "Jenna"
WHERE ID = 2
;

UPDATE Instructor
SET LastName ="Solis"
WHERE ID = 2
;

UPDATE Instructor
SET SlackHandle = "Jenna"
WHERE ID = 2
;

UPDATE Instructor
SET CohortId = 4
WHERE ID = 2
;

INSERT INTO Instructor (FirstName, LastName, SlackHandle, CohortId)
VALUES("Jisie", "David", "Jisie", 2)
;

INSERT INTO Instructor (FirstName, LastName, SlackHandle, CohortId)
VALUES("Kimmie", "Bird", "Kimmie", 1)
;

--Student
INSERT INTO Student (FirstName, LastName, SlackHandle, CohortId)
VALUES("Kayla", "Reid", "Kayla", 3)
;

INSERT INTO Student (FirstName, LastName, SlackHandle, CohortId)
VALUES("Adelaide", "Test", "adel", 2)
;

INSERT INTO Student (FirstName, LastName, SlackHandle, CohortId)
VALUES("Cashew", "Test", "Cashew", 1)
;

UPDATE Student
SET FirstName = "Dejan"
WHERE Id = 1
;

UPDATE Student
SET LastName = "Step"
WHERE Id = 1
;

UPDATE Student
SET SlackHandle = "Dejan"
WHERE Id = 1
;

UPDATE Student
SET CohortId = 3
WHERE Id = 1
;

--StudentExercise

INSERT INTO StudentExercise (StudentId, ExerciseId)
VALUES(1, 1)
;

INSERT INTO StudentExercise (StudentId, ExerciseId)
VALUES(2, 2)
;

INSERT INTO StudentExercise (StudentId, ExerciseId)
VALUES(3, 3)
;

INSERT INTO StudentExercise (StudentId, ExerciseId)
VALUES(4, 3)
;
