--1.�����޲δ洢����
if (exists (select * from sys.objects where name = 'proc_get_Consumer'))
    drop proc proc_get_Consumer
go
create procedure proc_get_Consumer
as
select * from Consumer;
go
--����,ִ�д洢����
exec proc_get_Consumer;