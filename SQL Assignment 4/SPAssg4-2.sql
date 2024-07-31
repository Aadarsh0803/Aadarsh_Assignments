
create procedure GEtProductByName(@name varchar(30))
as
begin
	select * from Product where Pname = @name
end

exec GEtProductByName 'Pen';