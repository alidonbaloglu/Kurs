--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * From Customers where City ='London'

Select * From  Products where CategoryID=1 or CategoryID=3

Select * From  Products where CategoryID=1 and UnitPrice>=10

Select * From  Products order by CategoryID,ProductName 

Select * From  Products order by UnitPrice asc--artan
Select * From  Products order by UnitPrice desc --azalan

Select * From  Products where CategoryID=1 order by UnitPrice desc

select count(*) toplam from Products where CategoryID=2

select categoryID, COUNT(*) toplam from Products group by CategoryID

select categoryID, COUNT(*) toplam from Products group by CategoryID having COUNT(*) < 10

select categoryID, COUNT(*) toplam from Products where UnitPrice > 20
group by CategoryID having COUNT(*) < 10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID

--DTO Data Transformation Object

select *from Products p left join [Order Details] od -- solda olup sağda olmayanları getir
on p.ProductID = od.ProductID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

select *from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID= od.OrderID









