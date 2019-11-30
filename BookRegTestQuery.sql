use BookRegistration
go

select CustomerID, FirstName, LastName, DateOfBirth
from Customer

select ISBN, Price, Title
from Book
order by Title

select *
from Registration

-- Test Query
--insert into Registration (CustomerID, ISBN, RegDate)
--values (4, 9780451524935, '11/28/2019')

