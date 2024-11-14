Create database  viewFuncProcedure
use viewFuncProcedure


create table Authors(
Id int identity primary key,
Name nvarchar(15),
Surname nvarchar(15))

Create table Books(
Id int identity primary key,
AuthorId int references Authors(id),
Name nvarchar(100) CHECK (LEN(Name) >= 2),
PageCount int Check(PageCount>=10)
)

-- Authors cədvəlinə 5 nümunə daxil edirik
INSERT INTO Authors (Name, Surname) VALUES ('Gabriel', 'Garcia Marquez');
INSERT INTO Authors (Name, Surname) VALUES ('Jane', 'Austen');
INSERT INTO Authors (Name, Surname) VALUES ('George', 'Orwell');
INSERT INTO Authors (Name, Surname) VALUES ('Mark', 'Twain');
INSERT INTO Authors (Name, Surname) VALUES ('Fyodor', 'Dostoevsky');
select * from Books
-- Books cədvəlinə 5 nümunə daxil edirik
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (1, 'One Hundred Years of Solitude', 417);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (2, 'Pride and Prejudice', 279);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (3, '1984', 328);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (4, 'Adventures of Huckleberry Finn', 366);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (5, 'Crime and Punishment', 545);




select * from Books
create view GetData
as
select Books.id as BookID, Books.Name as BookName, Books.PageCount as BookCount, CONCAT( Authors.Name , Authors.Surname) as AuthotFullName from Books 
join Authors
on Books.AuthorId = Authors.Id

select * from GetData





CREATE PROCEDURE GetInfoProceduru1  @SerachName NVARCHAR(15)
as
begin
    SELECT 
        Books.Id AS BookID,
        Books.Name AS BookName,
        Books.PageCount AS BookCount,
        CONCAT(Authors.Name, ' ', Authors.Surname) AS AuthorFullName
    FROM Books
    JOIN Authors ON Books.AuthorId = Authors.Id
    WHERE Authors.Name = @SerachName OR Books.Name = @SerachName;
end
go

--hem author name'e gore hemde bookname'e gore axtaris edir
exec GetInfoProceduru1 '1984'




create function CountBooksPageCount (@MinPageCount INT = 10)
returns int
as
begin 
declare @BookCount int
select @BookCount = COUNT(*) from Books  where PageCount > @MinPageCount; 
return @BookCount;
end


select dbo.CountBooksPageCount(400) as BookCount