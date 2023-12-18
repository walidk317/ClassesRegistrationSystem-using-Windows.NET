use ClassReg

create proc insertfeesdetails
@cid int, @fees decimal(10,2)
as
begin
insert into feestbl values(@cid,@fees)
end