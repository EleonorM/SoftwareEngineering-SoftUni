CREATE TABLE Students
	(StudentID INT NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,

	CONSTRAINT PK_Students_StudentID
	PRIMARY KEY (StudentID)
	)


CREATE TABLE Exams
	(ExamID INT NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,

	CONSTRAINT PK_Exams_ExamID
	PRIMARY KEY (ExamID)
	)


CREATE TABLE StudentsExams
	(StudentID INT NOT NULL,
	ExamID INT NOT NULL,

	CONSTRAINT PK_StudentsExams
	PRIMARY KEY (StudentID, ExamID),
	CONSTRAINT FK_StudentsExams_Students
	FOREIGN KEY (StudentID)
	REFERENCES Students(StudentID),
	CONSTRAINT FK_StudentsExams_Exams
	FOREIGN KEY (ExamID)
	REFERENCES Exams(ExamID)
	)


INSERT INTO Students
VALUES
(1,'Mila'),
(2,'Toni'),
(3,'Ron')


INSERT INTO Exams
VALUES
(101,'SpringMVC'),
(102,'Neo4j'),
(103,'Oracle 11g')


INSERT INTO StudentsExams
VALUES
(1,101),
(1,102),
(2,101),
(3,103),
(2,102),
(2,103)
