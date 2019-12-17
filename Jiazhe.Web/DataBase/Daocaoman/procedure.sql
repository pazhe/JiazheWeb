--1.创建无参存储过程
if (exists (select * from sys.objects where name = 'getAllTaobaokeFavorites'))
    drop proc  getAllTaobaokeFavorites
go
create procedure getAllTaobaokeFavorites
as
select * from TaobaokeFavorites;
go
--调用,执行存储过程
exec getAllTaobaokeFavorites;

--1.创建添加选品库存储过程
if (exists (select * from sys.objects where name = 'InsertIntoTaobaokeFavorites'))
    drop proc  InsertIntoTaobaokeFavorites
go
create procedure InsertIntoTaobaokeFavorites
@skID int,
@favorites_id bigint,
@favorites_type bigint,
@favorites_title varchar(200),
@total_results bigint
as
insert into  TaobaokeFavorites values(@skID,@favorites_id,@favorites_type,@favorites_title,@total_results,default)
go
--调用,执行存储过程
exec InsertIntoTaobaokeFavorites 1,1,1,1,1;
go
select * from TaobaokeFavorites