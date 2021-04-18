-- Stored procedure encapsulates SQL queries
-- System SP(predefined) and User Defined SP (custom)
exec [sys].[sp_help] '[HR].[Employees]' -- alt + F1
exec sp_helptext 'sp_help' --'[sys].[sp_add_agent_profile]'

create procedure sp_GetAllEmployees
as 
begin
select * from HR.Employees
end

execute sp_GetAllEmployees

exec sp_helptext 'sp_GetAllEmployees'

create procedure sp_GetEmployeeById
(
@id int 
)
with encryption
as
begin
select empid as Id, (concat(firstname,' ',lastname)) as Fullname, title as Role, phone
from HR.Employees
where empid=@id
end

exec sp_GetEmployeeById @id=5

exec sp_help 'sp_GetEmployeeById'