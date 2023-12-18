use ClassReg

CREATE PROCEDURE addcourse
@firstname VARCHAR(50)
AS
BEGIN
SELECT coursename, coursefee FROM admissiontbl WHERE firstname = @firstname
END

create procedure insertfeedetails
@studentname varchar(50), @coursename varchar(100), @totalfee decimal(10,2) , @action varchar(100), 
                                 @registrationfee decimal(10,2), @dor date, @installment int, @amount decimal(10,2), @dateamount date,
								 @status text, @balance decimal(10,2)
as
begin
insert into studentfeesdetails values(@studentname,@coursename,@totalfee,@action,@registrationfee,@dor,@installment,
                                 @amount,@dateamount,@status,@balance)
end


select * from studentfeesdetails where studentname =@studentname
insert into studentfeesdetails values('omkar','diploma in dot net',50000,'new',2000,'2023-10-04',
null,null,null,'hi',48000)
delete from studentfeesdetails



