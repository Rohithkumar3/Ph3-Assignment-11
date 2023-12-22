create database ContentDB
use ContentDB

create table Articles(
ArticleId int primary key,
Title nvarchar(50),
Content nvarchar(50),
PublishDate datetime)

insert into Articles values(1, 'Article-1','Content in 1st article','12/12/2023'),
(2, 'Article-2','Content in 2st article','11/11/2024')
select * from Articles

