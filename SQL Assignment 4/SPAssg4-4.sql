create procedure DeleteProductById(@id int)
as
begin
	delete from Product where Pid = @id
end
select * from product

exec DeleteProductById 2;