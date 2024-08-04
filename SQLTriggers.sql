--1. Add two numbers

create function fn_AddTwoNumbers(@a int,@b int)
returns int
as 
begin
	return @a+@b
end

print dbo.fn_AddTwoNumbers (1,2)

--2. Trim 

create function fn_Trim(@s varchar(250))
returns varchar(250)
as 
begin
	return trim(@s)
end
print dbo.fn_Trim(' Ada  ')

--3.To remove num from varchar
create function fn_RemoveNumber(@s varchar(250))
returns varchar(250)
as
begin
	return REPLACE
(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE
(REPLACE(REPLACE(REPLACE (@s, '0', ''),'1', ''),
'2', ''),'3', ''),'4', ''),'5', ''),'6', ''),
'7', ''),'8', ''),'9', '')
end

select trim('1234567890' from '3456rty4567')
print dbo.fn_RemoveNumber('123ert234we234')

--4. Format Phone no
CREATE FUNCTION fn_FormatPhone (@PhoneNumber VARCHAR(10))
RETURNS VARCHAR(20)
AS
BEGIN
    RETURN '(' + SUBSTRING(@PhoneNumber, 1, 3) + ') ' + 
               SUBSTRING(@PhoneNumber, 4, 3) + '-' + 
               SUBSTRING(@PhoneNumber, 7, 4)
END;

print dbo.fn_FormatPhone('1234567890')

--5.
create procedure sp_table(@Tname varchar(50),@Tcolumn varchar(50))
as
begin
	declare @s nvarchar(max);
	set @s= N'create table ' + @Tname + N' (' + @Tcolumn + N');';
	exec sp_executesql @s
end

exec dbo.sp_table  'NewTable', 'ID INT, Name VARCHAR(100)'
select * from newtable

drop procedure sp_table
drop table newtable




--6.
create procedure sp_take(@source varchar(30), @destination varchar(30))
as
begin
	exec('insert into' + @destination +' select * from' + @source)
end

exec sp_take 'customer','department'