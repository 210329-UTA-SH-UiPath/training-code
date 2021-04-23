--- reference : https://www.slideshare.net/AaronBuma/sql-triggers-56794620
--- https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql?view=sql-server-ver15

use Tsql
go

create table ArchiveTableForUpdateEmployee(
Id int identity(1,1) not null primary key,
empid int not null,
empname nvarchar(max) not null,
DateModified date not null default getdate(),
comment varchar(max) null
)
go

create trigger OnEmployeeModify
on HR.Employees
after update
as 
begin
declare @empid as int, @empname as nvarchar(max)
select @empid=deleted.empid, @empname=concat(deleted.firstname,' ',deleted.lastname) from deleted
insert into ArchiveTableForUpdateEmployee values (@empid,@empname, GETDATE(),'Employee values changed')
end



update HR.Employees set lastname='Belotte',firstname='Fred' where empid=9
select * from [HR].[Employees]
select * from ArchiveTableForUpdateEmployee