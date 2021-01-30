-- Select 
select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

select * from Customers where City= 'Berlin'

select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc  -- asc => artan desc => azalan

select count(*)from Products -- tüm product tablosunda kaç tane satır var

select count(*) Adet from Products where CategoryID=2

select CategoryID,COUNT(*)  from Products group by CategoryID

select CategoryID,COUNT(*) from Products group by CategoryID having count(*)<10

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10


-- DTO Data Transformation object

select * from products p inner join [Order Details] od -- inner join sadece eşleşenleri getirir
on p.ProductID=od.ProductID

select * from products p left join [Order Details] od 
on p.ProductID=od.ProductID
inner join orders o 
on o.OrderID=od.OrderID

select * from Customers c left join orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null