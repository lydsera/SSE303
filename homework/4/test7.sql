use test_3;
set global log_bin_trust_function_creators=TRUE;
drop function hello;
create function hello()
returns varchar(64)
AS
begin
	declare @str varchar(64);
	set @str = 'hello world';
	return @str;
end
select dbo.hello();

create function score_grade(@s float)
returns char(10)
begin
	declare @g char(10);
	
	return (select (case
			when @s is null then '无成绩'
				when @s <60 then '不及格'
				when @s >=60 and @s < 70 then '及格'
				when @s >=70 and @s < 80 then '中等'
				when @s >=80 and @s < 90 then '良好'
				when @s >=90 then '优秀'
				else
					'未知'
				end))
end 
select dbo.score_grade(45)
select Sid,Grade,dbo.score_grade(Grade) as grade from grade;
create procedure getAllStudent
as
begin
	select * from student;
end
getAllStudent;
CREATE PROCEDURE getAvgScore @sn varchar(10), @avgs numeric(5,2) output
AS
	SELECT @avgs=avg(grade)
	FROM grade
	WHERE Sid=@sn;

DECLARE   @a   numeric(5,2); 
exec getAvgScore '20331066',@a output;
select @a;

CREATE PROCEDURE maxnum @a int,@b int,@c int
AS
BEGIN
	DECLARE @max int;
		SET @max=@a;
		IF @b>@max 
			SET @max=@b;
		IF @c>@max 
			SET @max=@c;
		SELECT @max;
END
exec maxnum 10, 6, 8;
drop procedure calsum
create procedure calsum @a int, @b int
as
begin
	declare @c int;
	set @c=@a+@b;
	select @c as sum;
end
calsum 19, 32;

CREATE TRIGGER tri_insert_stu
ON student
AFTER INSERT 
as
	INSERT INTO log_info VALUES ('向学生信息表中插入一行记录');
	
create table log_info(
log varchar(100)
)
insert into Student values('20220801',2,'Linda',2,'2010-10-01',99,NULL,NULL);

CREATE TRIGGER tri_update_stu
ON student
AFTER Update 
as
INSERT INTO log_info VALUES ('从学生信息表中更新了一行记录');

update student set Sname = 'ccc' where sid='20220801';

CREATE TRIGGER tri_update_stu2
ON student
AFTER Update 
as
INSERT INTO log_info 
VALUES (concat('从学生信息表中更新了一行记录', (select SName from deleted), '改为', (select SName from inserted)));
	
update student set Sname = 'ddd' where sid='20220801';


SELECT  *
FROM 
    sys.triggers 





create function fib(@n int)
returns int
begin
	if @n=1 
		return 0;
	else if @n=2 
		return 1;
	else
		return fib(@n-1)+fib(@n-2);
	end if;
end

select fib(5);

drop function fibo
create function fibo(@n int)
returns int
begin
	declare @i int=3;
	declare @a int=0;
	declare @b int=1;
	declare @c int=1;
	if @n=1 
		return 0;
	else if @n=2 
		return 1;
	while @i <= @n 
	begin
		set @c = @a + @b;
		set @a = @b;
		set @b = @c;
		set @i = @i +1;
	end
	return @c;
end

select dbo.fibo(5);


create function idToName(@id varchar(10))
returns char(10)
begin
	declare @g char(10)='';
	select @g=sname from student where sid=@id;
	return @g;
end 
select dbo.idToName('20331021')

CREATE PROCEDURE getNameAndMajor @id varchar(10)
as
	SELECT s.sname,m.mname FROM student s inner join major m on m.mid=s.mid where s.sid=@id;
drop PROCEDURE getNameAndMajor;
getNameAndMajor '20331021';

drop procedure getMinAndMax
create procedure getMinAndMax
	@cid int,
	@mingrade decimal(8,2) output,
	@maxgrade decimal(8,2) output 
as
begin
	set @mingrade=(select min(grade) from dbo.grade where cid=@cid);
	set @maxgrade=(select max(grade) from dbo.grade where cid=@cid);
end;
declare @ming decimal(8,2);
declare @maxg decimal(8,2);
exec getMinAndMax 6,@ming output,@maxg output;
select @ming,@maxg;

Create Trigger relatesid   
on student
after Update 
as
begin
	Update grade Set grade.sid=i.sid  
	from grade g,inserted i,deleted d Where g.sid=d.sid and d.sid!=i.sid ;
end  

EXEC sp_MSforeachtable @command1='alter table ? NOCHECK constraint all;'
update student set sid='20331065' where sid='20331067';
EXEC sp_MSforeachtable @command1='alter table ? CHECK constraint all;'



CREATE TRIGGER insert_stu_avgScore
ON student
AFTER INSERT 
as
	INSERT INTO log_info VALUES (concat('平均学分为',(select AVG(scores) from student)));
drop trigger insert_stu_avgScore
insert into Student values ('20226666',1,'tominn', 1, '2000-10-21', 99, NULL,NULL);