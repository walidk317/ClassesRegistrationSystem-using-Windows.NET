use ClassReg

create table adminlogin(name varchar(50),password varchar(50))

create proc addadmindetails
@name varchar(50), @password varchar(50)
as
begin
insert into adminlogin values (@name,@password)
end

insert into adminlogin values('admin', 'admin123')

delete from adminlogin
select * from adminlogin