ecreate database dbEmployees

use dBEmployees




create table tblAdmin
(Admin_id int primary key,
Password varchar(20)
)

sp_help tblAdmin

	

insert into tblAdmin values(100,'nandhal123','nandha Kumar','Manager',44,'Male','1973-01-21',
'nandhas@yahoo.com','55,kk nagar','Salem',877000,'TamilNadu',100)


create table tblEmployee
(Employee_id int identity(1000,1) primary key,
First_Name varchar(20) NOT NULL,
Last_Name varchar(20),
Password varchar(20) NOT NULL,
Role varchar(20),
Age int NOT NULL,
Gender varchar(20),
DOB date,
Email_id varchar(50),

Address varchar(50),
City varchar(20),
Pincode int,
State varchar(20),
Department_id int references tblDepartment(Department_id),
working_under int,
Unit_id int references tblBusinessUnit(Unit_id)
)

alter table tblEmployee
add mobile_number varchar(20)

insert into tblEmployee values ('Roshan','roshan123','Software Developer',21,'Male','1999-01-29','roshanzameerali@gmail.com',
'328,Vallalar Nagar','Salem',636008,'Tamil Nadu',100,1001,111)

select * from tblEmployee

update tblEmployee
set Unit_id = 112
where Employee_id = 1001

alter table tblEmployee
add password varchar(20)

alter table tblEmployee 
drop constraint FK_DepartmentId
foreign key (Department_id) references tblDepartment(Department_id);

drop table tblEmployee 
drop column Skill_id

insert into tblEmployee(Employee_id,Name,Age) values(1003,'Sujith',23)



insert into tblEmployee values ('Deepan','Natti','roshan123','Cloud Engineer',21,'Male','1999-01-22','spchennai99@gmail.com',
'c37,shantiniketan','Salem',636008,'Tamil Nadu',100,1005,112)

sp_help tblEmployee


drop table tblEmployee


create table tblDepartment
(Department_id int primary key,
Department_name varchar(20)
)


insert into tblDepartment values(100,'Manufacturing')
insert into tblDepartment values(101,'Testing')


create table tblBusinessUnit
(Unit_id int primary key,
Unit_Name varchar(40)
)

insert into tblBusinessUnit values(111,'Honda')
insert into tblBusinessUnit values(112,'WarnerMEdia')

/*-------------Procedures---------------*/
/*-------------To get the Employee Profile-----------*/

create procedure storedproc_GetEmployeeDetails(@EmployeeId int)
as
begin
	select * from tblEmployee where Employee_id = @EmployeeId
end

select * from tblEmployee

/*----------Employee Registration----------*/

create procedure proc_validEmployeeCheck(@Placement_Id int)
as
begin
	select Placement_Id from tblPlacement where Placement_id = @Placement_Id
end

create procedure proc_CheckAlreadyExistingEmployee(@Mobile_Number varchar(20))
as
begin
	select mobile_number from tblEmployee where mobile_number = @Mobile_Number
end

create procedure proc_GenerateEmployee_id(@Employee_id int)
as
begin
	select Employee_id from tblEmployee where Employee_id = @Employee_id
end

select * from tblEmployee



/*-----------Employee Login--------------*/

create procedure proc_EmployeeLogin(@Employee_id int,@Password varchar(20))
as
begin
 select Role from tblEmployee where Employee_id = @Employee_id and Password = @Password
end






/*-----------Admin Dashboard Details Procedure-----------*/

create procedure proc_GetEmployeesForAdmin
as
begin
select * from tblEmployee where Role != 'Admin' or Role is NULL
end

update tblEmployee
set Role = 'developer'
where Employee_id = 1002

/------------Get Department and Unit Name for Employee---------/



create procedure GetDepartmentAndUnitNames(@Employee_id int)
as
begin
select BusniessUnit.Unit_Name,Department.Department_Name from tblEmployee Employee join tblBusinessUnit BusniessUnit 
on Employee.Employee_id = @Employee_id and Employee.Unit_id = BusniessUnit.Unit_id join tblDepartment Department
on Employee.Department_id = Department.Department_id
end

select * from tblDepartment

select Department_id from tblDepartment where Department_name = 'Manufacturing'

select Unit_id from tblBusinessUnit where Unit_Name = 'Honda'

/*------For Drop down options-------*/

create procedure proc_GetAllBusinessUnits
as
begin
	select * from tblBusinessUnit
end

create procedure proc_GetAllDepartments
as
begin
	select * from tblDepartment
end

select * from tblEmployee

/*------Delete Employee-----*/

select * from tblEmployee

delete from tblEmployee
where Employee_id = 1005

create procedure proc_deleteEmployee(@Employee_id int)
as
begin
	delete from tblEmployee
	where Employee_id = @Employee_id
end