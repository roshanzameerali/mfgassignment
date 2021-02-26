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

/*-----------Employee Login--------------*/

create procedure proc_EmployeeLogin(@Employee_id int,@Password varchar(20))
as
begin
 select Role from tblEmployee where Employee_id = @Employee_id and Password = @Password
end


select * from tblEmployee


/*-----------Admin Dashboard Details Procedure-----------*/

create procedure GetAllEmployees
as
begin
select * from tblEmployee where Role != 'Admin' or Role = 'NULL'
end

update tblEmployee
set Role = 'developer'
where Employee_id = 1002