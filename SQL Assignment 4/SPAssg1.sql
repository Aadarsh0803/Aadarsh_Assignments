use mydb1
create procedure GetAllProducts
as
Begin
	select * from Product
End

exec GetAllProducts
