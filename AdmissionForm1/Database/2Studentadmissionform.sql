use ClassReg

create or alter procedure insertstudentdetails
@firstname varchar(50), @lastname varchar(50), @dateofbirth date, @gender varchar(10), @email varchar(100),
                     @phonenumber bigint,@addrss varchar(500), @coursename varchar(100), @courseduration int, @coursefee decimal(10,2),
					 @admissiondate date, @docname varchar(300)
as
begin
insert into admissiontbl values(@firstname, @lastname, @dateofbirth, @gender, @email,
                         @phonenumber, @addrss, @coursename, @courseduration, @coursefee,
						 @admissiondate, @docname)
end

create procedure updatestudendetails
@firstname varchar(50), @lastname varchar(50), @dateofbirth date, @gender varchar(10), @email varchar(100),
                     @phonenumber bigint,@addrss varchar(500), @coursename varchar(100), @courseduration int, @coursefee decimal(10,2),
					 @admissiondate date, @docname varchar(300)
as
begin
update admissiontbl set firstname =@firstname,lastname = @lastname,dateofbirth= @dateofbirth,gender = @gender,email= @email,
                         addrss= @addrss,coursename= @coursename,courseduration = @courseduration,coursefee = @coursefee,
						admissiondate = @admissiondate,docname = @docname where phonenumber = @phonenumber
end

create procedure deletestudentdetails
@phonenumber bigint
as
begin
delete from admissiontbl where phonenumber = @phonenumber
end

create procedure viewstudentdetails
as
begin
select * from admissiontbl
end



drop proc insertstudentdetails
select *from admissiontbl

create or alter procedure insertstudentdetails
@firstname varchar(50), @lastname varchar(50), @gender varchar(10), @email varchar(100),
                     @phonenumber bigint,
					 @addrss varchar(500), @coursename varchar(100), @courseduration int, @coursefee decimal(10,2),
					  @docname varchar(300
					  )
as
begin
insert into admissiontbl(firstname, lastname, gender, email, phonenumber, addrss, coursename, courseduration, coursefee, docname) values(@firstname, @lastname, @gender, @email,
                         @phonenumber, @addrss, @coursename, @courseduration, @coursefee,
						  @docname)
end

select * from admissiontbl