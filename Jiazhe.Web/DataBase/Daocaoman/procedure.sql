--1.�����޲δ洢����
if (exists (select * from sys.objects where name = 'getAllTaobaokeFavorites'))
    drop proc  getAllTaobaokeFavorites
go
create procedure getAllTaobaokeFavorites
as
select * from TaobaokeFavorites;
go
--����,ִ�д洢����
exec getAllTaobaokeFavorites;

--1.�������ѡƷ��洢����
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
--����,ִ�д洢����
exec InsertIntoTaobaokeFavorites 1,1,1,1,1;
go
select * from TaobaokeFavorites