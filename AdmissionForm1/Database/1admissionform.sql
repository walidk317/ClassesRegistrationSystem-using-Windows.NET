create database ClassReg
use ClassReg
create table admissiontbl(studentid int not null primary key identity(101,1), firstname varchar(50), lastname varchar(50), dateofbirth date, gender varchar(10), email varchar(100),
                     phonenumber bigint,addrss varchar(500), coursename varchar(100), courseduration int, coursefee decimal(10,2),
					 admissiondate date, docname varchar(300)) ---insert,update,delete,view(grid view)

--create table enquirytbl(firstname varchar(50),middlename varchar(50), lastname  varchar(50), course varchar(50),contact int,qualification varchar(50))--insert

create table coursetbl(cid int not null primary key identity(1,1),coursename varchar(500)) --insert,update,delete,view(grid)

 
create table feestbl(cid int,fees decimal(10,2),constraint fk foreign key(cid) references coursetbl(cid))--insert,update,delete,view/grid

create table studentfeesdetails (studentname varchar(50), coursename varchar(100), totalfee decimal(10,2) , action varchar(100), 
                                 registrationfee decimal(10,2), dor date, installment int, amount decimal(10,2), dateamount date,
								 status text, balance decimal(10,2))

constraint fks foreign key(studentid) references admissiontbl(studentid),
constraint fkp foreign key(cid) references coursetbl(cid))

create table batchdetailstbl(studentid int, coursename varchar(100), admissiondate date,startdate date, status varchar(50) default 'pending')

select * from admissiontbl

--drop table studentfeesdetails


