create database BookApp
use BookApp
create table Book
(BookId int primary key,
BookName varchar(30) not null,
Price int,
Author varchar(30) not null,
Lang varchar(15) not null,
ReleaseDate datetime not null
)
insert into Book
values
(1,'Rich Dad Poor Dad',300,'Sharon Lechter','English','1998-8-8'),
(2,'Thousand Splindid Suns',350,'Khaleed hussane','Arab','1978-1-1'),
(3,'It Ends With Us',400,'Unknown','Hindi','1990-4-4'),
(4,'It Starts with us',400,'Unknown','Hindi','2000-1-1'),
(5,'All I ever want is you',250,'Krish','Telugu','2005-2-2');
select * from Book

ALTER TABLE Book
ADD CONSTRAINT PK_Book PRIMARY KEY (BookId);
drop table book