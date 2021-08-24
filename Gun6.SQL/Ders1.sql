	--ANSII Standard
	--Select
--KOMUT KOLON ADI VE ALLIAS TAKMA İSİM					  CUSTOMERS DATABASE'SINDE
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

	--Select Filter
--KOMUT HEPSI CUSTOMER  
Select * from Customers where City = 'Berlin'

	--case insensitive
Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>10

Select * from Products where CategoryID=1 order by UnitPrice desc		--ascending - artan -- descending - azalan

Select count(*) Adet from Products

select CategoryID, count(CategoryID) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID  where Products.UnitPrice>10

--DTO Data Transformation object

Select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID
inner join Orders o on o.OrderID = od.OrderID

Select * from Customers c left join Orders o on c.CustomerID = o.CustomerID
where o.CustomerID is null
