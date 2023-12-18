use ClassReg

create proc insertcoursedetails
@coursename varchar(500)
as
begin
insert into coursetbl
values(@coursename)
end

create proc updatecoursedetails
@ecoursename varchar(500),@id int
as
begin
update coursetbl set coursename = @ecoursename where cid=@id
end



create proc deletecoursedetails
@id int
as
begin
delete from coursetbl  where cid = @id
end


create proc viewcoursedetails
as
begin
select * from coursetbl 
end


create proc searchcoursebyid
@id int
as
begin
select * from coursetbl where cid=@id
end


create proc viewcourseid

as
begin
select cid from coursetbl 
end


