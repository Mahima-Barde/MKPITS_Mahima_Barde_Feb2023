--primary key
create database Bookstore

create table books(
Orderno int,
Bookid int,
Price int,
Qty int,
custid int,
primary key(Orderno,Bookid),)--Composite key(Orderno,Bookid)
--constraint price_check cheak
select * from books

insert into books values(1,23,200,1,212),
(1,24,400,2,212),
(2,25,500,1,214),
(3,23,200,1,214),
(3,27,1000,3,215)

create table Cost(
Bookid int primary key,
price int
)

insert into Cost values(23,200),
(24,400),
(25,500),
(27,1000)

create table BookInfo(
Bookid int,
Orderno int,
Qty int,
custid int
constraint b foreign key(Bookid) references Cost(Bookid)
)

insert into BookInfo values(23,1,1,212),
(24,1,2,212),
(25,2,1,214),
(23,3,1,214),
(27,2,3,212)

select * from BookInfo

--Alter table Cost
--Add constraint check_price
--Check(price=200);
