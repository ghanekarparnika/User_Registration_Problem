



--UC1-Using MSSQL Client use create database query to create a payroll_service database
Create database PayRoll_Service;

--UC2-Use Create Table employee_payroll Query to create employee payroll table with columns id, name, salary and start date as column.
create table Employee_Payroll(Id int primary key Identity(1,1),Name varchar(20),Salary float,Start_Date Date);
