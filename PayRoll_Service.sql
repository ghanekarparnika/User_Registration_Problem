



--UC1-Using MSSQL Client use create database query to create a payroll_service database
Create database PayRoll_Service;

--UC2-Use Create Table employee_payroll Query to create employee payroll table with columns id, name, salary and start date as column.
create table Employee_Payroll(Id int primary key Identity(1,1),Name varchar(20),Salary float,Start_Date Date);

--UC3-Insert into Employee_Payroll
insert into Employee_Payroll values('Raj',60000.0,'2018-06-1');
insert into Employee_Payroll values('Arya',55000.0,'2020-08-03');
insert into Employee_Payroll values('Shubham',30000.0,'2023-01-10');

--UC4-Use SELECT * FROM employee_payroll to retrieve all the data from the employee_payroll table
select * from Employee_Payroll;

--UC5-Ability to retrieve salary data for a particular employee as well as all employees who have joined in a particular data range from the
--payroll service database
select salary from Employee_Payroll where Name='Parnika';
select salary from Employee_Payroll where Start_Date between cast('2018-06-1' as Date) and getdate();