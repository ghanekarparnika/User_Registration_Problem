--Create the Employee table with attributes
create table Employee (
    Id int primary key identity(1, 1),
    Name varchar(50) NOT NULL,
    Gender varchar(2),
    Salary float,
    Start_Date date,
    Phone bigint,
    Address varchar(100),
    Department varchar(50)
);

--Create the SalaryDetails table with attributes
create table SalaryDetails (
    EmployeeId int primary key ,
    Basic_Pay float,
    Deductions float,
    Taxable_Pay float,
    Income_Tax float,
    Net_Pay float,
    foreign key (EmployeeId) references Employee(Id)
);

--Create the Department table with attributes
create table Department (
    Id int primary key identity(1, 1),
    DepartmentName varchar(50) NOT NULL
);

--For the Many-to-Many relationship between employees and departments, create a junction table called EmployeeDepartment
create table EmployeeDepartment (
    EmployeeId int,
    DepartmentId int,
    primary key  (EmployeeId, DepartmentId),
    foreign key (EmployeeId) references Employee(Id),
    foreign key (DepartmentId) references Department(Id)
);

insert into Employee (Name, Gender, Salary, Start_Date, Phone, Address, Department)values
    ('John', 'M', 60000.0, '2018-06-01', 1234567890, 'New York', 'HR'),
    ('Alice', 'F', 55000.0, '2020-08-03', 9876543210, 'Los Angeles', 'Finance'),
    ('Bob', 'M', 65000.0, '2019-05-15', 8765432109, 'Chicago', 'IT'),
    ('Eva', 'F', 48000.0, '2021-02-20', 7654321098, 'San Francisco', 'HR');

insert into SalaryDetails (EmployeeId, Basic_Pay, Deductions, Taxable_Pay, Income_Tax, Net_Pay)values

    (1, 55000.0, 5000.0, 50000.0, 10000.0, 40000.0),
    (2, 50000.0, 4500.0, 45500.0, 9000.0, 36500.0),
    (3, 60000.0, 5500.0, 54500.0, 11000.0, 43500.0),
    (4, 48000.0, 4300.0, 43700.0, 8700.0, 35000.0);

insert into Department (DepartmentName)values

    ('HR'),
    ('Finance'),
    ('IT'),
    ('Sales');

select * from Employee; 
select * from SalaryDetails; 
select * from Department; 


--redo UC7 (calculating statistics by gender) using the new schema:
select Gender, SUM(Salary) as TotalSalary from Employee group by Gender;
 
select Gender, AVG(Salary) as AverageSalary from Employee group by Gender;

select Name, MIN(Salary) as  MinSalary from Employee where Gender = 'F' group by Name;

select Name, MAX(Salary) as  MaxSalary from Employee where Gender = 'M' group by Name;

select COUNT(*) AS MaleEmployeeCount from Employee where Gender = 'M';

select COUNT(*) AS FemaleEmployeeCount from Employee where Gender = 'F';