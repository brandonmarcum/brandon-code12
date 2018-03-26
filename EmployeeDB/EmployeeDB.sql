--EmployeeDB.sql
--Upload to repo


create database Employee


create table Department
(
	Id int primary key identity(1,1),
	[Name] nvarchar (200) not NULL,
	[Location] nvarchar(200) not Null
);

create table Employee
(
	Id int primary key identity(1,1),
	FirstName nvarchar (50) not NULL,
	LastName nvarchar (75) not NULL,
	SSN int not Null,
	DeptId int foreign key references Department(Id) not NULL
);

create table EmpDetails
(
	Id int primary key identity(1,1),
	EmployeeId int foreign key references Employee(Id) not NULL,
	Salary money not NULL,
	Address1 varchar(200) not NULL,
	Address2 varchar(200),
	[City] varchar (30) not NULL,
	[State] varchar(2) not NULL,
	[Country] nvarchar(50) not NULL
);

--Add 3 records into each table

insert into Department ([Name], [Location])
Values ('Sales', '4333 Sales Street');
insert into Department ([Name], [Location])
Values ('Management', '4045 Management Street');
insert into Department ([Name], [Location])
Values ('Communications', '4065 Comm Street');
insert into Employee (FirstName, LastName, SSN, DeptId)
Values ('John', 'Smith', '123456789', 2);
insert into Employee (FirstName, LastName, SSN, DeptId)
Values ('Jay', 'Smith', '124456789', 1);
insert into Employee (FirstName, LastName, SSN, DeptId)
Values ('Eugene', 'Smith', '123458789', 3);

insert into EmpDetails(EmployeeId, Salary, Address1, Address2, City, [State], Country)
Values (1, 900.00, 'Smith', 'Smith', 'Smith', 'SM', 'Smith');
insert into EmpDetails(EmployeeId, Salary, Address1, Address2, City, [State], Country)
Values (2, 900.00, 'Smith', 'Smith', 'Smith', 'SM', 'Smith');
insert into EmpDetails(EmployeeId, Salary, Address1, Address2, City, [State], Country)
Values (3, 900.00, 'Smith', 'Smith', 'Smith', 'SM', 'Smith');

--Add employee Tina Smith
insert into Employee (FirstName, LastName, SSN, DeptId)
Values ('Tina', 'Smith', '123456789', 4);
insert into EmpDetails(EmployeeId, Salary, Address1, Address2, City, [State], Country)
Values (4, 9.00, 'Smith', 'Smith', 'Smith', 'SM', 'Smith');

--Add department Marketing
insert into Department ([Name], [Location])
Values ('Marketing', '4055 Marketing Street');

--List all employees in Marketing
SELECT FirstName, LastName
FROM Employee
WHERE DeptId = 4;

--List total salary of Marketing
SELECT SUM(ed.salary)
FROM Employee em
inner join  EmpDetails as ed on ed.EmployeeId = em.Id
inner join  Department as de on de.Id = em.Id;

--Report Total Employees by Department
select de.[Name], COUNT(em.id)
from Department as de
left join  Employee as em on em.DeptId = de.Id
group by de.[Name]

--Increase salary of Tina Smith to $90.00
update EmpDetails
set Salary = 90000
where EmployeeId = 4;
