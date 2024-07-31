create procedure UpdateProduct(@price int,@stock int,@Pid int)
as
begin
	update product
	set Price=@price,Stock = @stock from product where Pid = @pid
end
select * from product
exec UpdateProduct 200,20,1