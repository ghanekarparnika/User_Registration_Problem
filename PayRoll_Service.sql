



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

--UC6-Ability to add Gender to Employee Payroll Table and Update the Rows to reflect the correct Employee Gender
alter table Employee_Payroll add Gender varchar(2);
update Employee_Payroll set Gender='M' where Name='Raj' or Name= 'Shubham';
update Employee_Payroll set Gender='F' where Name='Parnika' or Name= 'Arya';

--UC7-Ability to find sum, average, min, max and number of male and female employees
--sum
select sum(salary) as Total_salary from Employee_Payroll where Gender='F' group by gender;
--Average
select AVG(salary) as Average from Employee_Payroll where Gender='M' group by gender;
--min
select MIN(salary) as Min_Salary , Name from Employee_Payroll where Gender= 'F' group by Name;
--max
select MAX(salary) as Max_Salary , Name from Employee_Payroll where Gender= 'M' group by Name;
--number of male employees
select COUNT(salary) as Count_MaleEmployees  from Employee_Payroll where Gender='M' group by gender; 
--Number of Female Employees
select COUNT(salary) as Count_FemaleEmployees  from Employee_Payroll where Gender='F' group by gender;
 
--UC8-Ability to extend employee_payroll data to store employee information like employee phone, address and department - Ensure employee department
alter table Employee_Payroll add Phone bigint;
select * from Employee_Payroll;

alter table Employee_Payroll add Address varchar(20) not null default 'Maharashtra';
select * from Employee_Payroll;

alter table Employee_Payroll add Department varchar(20) not null default 'Engineering';
