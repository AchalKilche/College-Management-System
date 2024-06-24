create database collegeManagement;

create table NewAdmission (
NAID int NOT NULL IDENTITY(1,1)primary key,
fname varchar(250)not null,
mname varchar(250)not null,
gender varchar(10)not null,
dob varchar(50)not null,
mobile bigint not null,
email varchar(150),
semester varchar(100)not null,
prog varchar(150)not null,
sname varchar(150)not null,
duration varchar(120)not null,
addres varchar(250)not null
)

insert into NewAdmission(fname,mname,gender,dob,mobile,email,semester,prog,sname,duration,addres)values('Achal Kilche','Ashwini','Female','22-05-2002','7775959675','kilcheachal@gmail.com','3rd sem',' C++','Shahu College latur','2020-2024 ','Manik Nagar parli')
insert into NewAdmission(fname,mname,gender,dob,mobile,email,semester,prog,sname,duration,addres)values('Vaishnavi pathak','Sneha','Female','26-08-2002','9976678785','pvaishnavi@gmail.com','2nd sem',' PHP','Shahu College latur','2020-2024 ','Bashweshwar colony latur')
fname,mname,gender,dob,mobile,email,semester,prog,sname,duration,addres

select * from NewAdmission
truncate table NewAdmission

 
 create table fee
 (
 fid int not null IDENTITY(1,1)primary key,
 NAID int not null,
 fee int not null
 )

 select *from fee
 

 truncate table fee

create table teacher
(
tID int not null IDENTITY(1,1)primary key,
fname varchar(250) not null,
gender varchar(10)not null,
dob varchar(50)not null,
mobile bigint not null,
email varchar(250),
semester varchar(250)not null,
prog varchar(100)not null,
yer varchar(250)not null,
adr varchar(200)not null
)

fname,gender,dob,mobile,email,semester,prog,yer,adr

select *from teacher
truncate table teacher 