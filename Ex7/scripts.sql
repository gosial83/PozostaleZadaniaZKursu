-- Ad 1

create database StudentsAndClass

use StudentsAndClass

create table Student
(
	Id					int identity	not null,
	[Name]				nvarchar(100)	not null,
	PESEL				nchar (11)		not null,
	Gender				nchar(1)		not null,
	IsSuspended			Bit				not null,		
	NumberOfAbsences	int				null constraint		DF_Student_NumberOfAbsences default 0,
	Comment				nvarchar (255)	null,
	Birthday			Date			not null,
	constraint		PK_Student primary key (Id),
	constraint		UQ_Student_PESEL unique (PESEL),
	constraint		CHK_Student_Gender check (Gender in ('M', 'F')),
)

-- Ad 2
create table Class
(
	Id					int identity	not null,
	[Name]				nvarchar(5)		not null,
	RoomNumber			int				not null,
	[Description]		nvarchar (255)		null,
	constraint		PK_Class primary key (Id),
	constraint		CHK_Class_RoomNumber check (RoomNumber>0 AND RoomNumber<=999 )
)

-- Ad 3
create table StudentClass
(
	StudentId	int		not null,
	ClassId		int		not null,
	constraint PK_StudentClass primary key (StudentId, ClassId),
	constraint FK_StudentClass_StudentId foreign key (StudentId) references Student(Id),
	constraint FK_StudentClass_ClassId foreign key (ClassId) references Class(Id)
)

-- Ad 4

insert into Student([Name], PESEL, Gender, IsSuspended, NumberOfAbsences, Comment, Birthday ) values
	('Jan Kowalski', 11145678902, 'M', 'True', null, null, '1987-04-04'),
	('Tommasz Nowak', 22245678902, 'M', 'True', 26, null, '1991-02-04'),
	('Alicja Wach', 33345678902, 'F', 'True', 4, null, '1979-04-04'),
	('Olga Nowak', 44445678902, 'F', 'True', 16, null, '1986-03-04'),
	('Olaf Baran', 55545678902, 'M', 'True', 22, null, '1992-02-04'),
	('Piotr Czajka', 66645678902, 'M', 'True', 12, null, '1992-02-04')


insert into Class([Name], RoomNumber, [Description] ) values
	('3c', 123, 'Math'),
	('3b', 115, 'English'),
	('3a', 117, 'Biol'),
	('2a', 112, 'Chem'),
	('1a', 119, 'Gym')


insert into StudentClass(StudentId, ClassId) values
	(1, 1),
	(2, 1),
	(3, 1),
	(4, 1),
	(5, 1),
	(1, 2),
	(1, 3),
	(3, 4),
	(4, 4),
	(5, 5)


-- Ad 5
--Zapytanie wyœwietlaj¹ce wszystkich studentów których iloœæ nieobecnoœci jest wiêksza ni¿ 24

select * from Student 
	where NumberOfAbsences>24


-- Ad 6
--Zapytanie wyœwietlaj¹ce studentów zapisanych do klasy 3C

select s.Name, c.Name from Student S
	right join StudentClass SC on S.Id=SC.StudentId
	join Class C on SC.ClassId=C.Id
	where c.Name='3c'


-- Ad 7
-- Zapytanie wyœwietlaj¹ce klasy przypisane do pokoju 123, z minimum 3 studentami o liczbie nieobecnoœci wiêkszej ni¿ 10.

select C.Name as 'Class with room 123...' from Student S
	right join StudentClass SC on S.Id=SC.StudentId
	join Class C on SC.ClassId=C.Id
	where S.NumberOfAbsences>10 and c.RoomNumber=123
	group by C.Name
	HAVING COUNT(C.Name)>=3
