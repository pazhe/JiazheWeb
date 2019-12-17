--1.创建无参存储过程
if (exists (select * from sys.objects where name = 'proc_get_Consumer'))
    drop proc proc_get_Consumer
go
create procedure proc_get_Consumer
as
select * from Consumer;
go
--调用,执行存储过程
exec proc_get_Consumer;