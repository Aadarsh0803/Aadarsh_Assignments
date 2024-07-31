create procedure GetAllProductsGreaterThanPrice(@price int)
as 
Begin
	select * from Product where Price>@price
End
select * from Product
exec GetAllProductsGreaterThanPrice 20;