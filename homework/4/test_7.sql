use test_3;
set global log_bin_trust_function_creators=TRUE;
delimiter $$
create function hello()
returns varchar(64)
begin
	declare str varchar(64);
	set str = 'hello world';
	return str;
end $$
select hello();
delimiter $$
create function score_grade(s float)
returns char(10)
begin
	declare g char(10) default '';
		select (case
			when s is null then '无成绩'
				when s <60 then '不及格'
				when s >=60 and s < 70 then '及格'
				when s >=70 and s < 80 then '中等'
				when s >=80 and s < 90 then '良好'
				when s >=90 then '优秀'
				else
					'未知'
				end) into g;
				return g;
end $$
select score_grade(45)
select Sid,Grade,score_grade(Grade) as grade from grade;
create procedure getAllStudent()
	select * from student;
call getAllStudent;
CREATE PROCEDURE getAvgScore (sn varchar(10), out avgs numeric(5,2))
BEGIN
	SELECT avg(grade)
	FROM grade
	WHERE Sid=sn
	into avgs;
END

call getAvgScore('20331066',@a);
select @a;

CREATE PROCEDURE maxnum(a int,b int,c int)
BEGIN
	DECLARE max int;
		SET max=a;
		IF b>max THEN
			SET max=b;
		END IF;
		IF c>max THEN
			SET max=c;
		END IF;
		SELECT max;
END
call maxnum(10, 6, 8);

create procedure calsum( a int, b int)
begin
	declare c int;
	set c=a+b;
	select c as sum;
end
call calsum(19, 32);

CREATE TRIGGER tri_insert_stu
AFTER
INSERT ON student
FOR EACH ROW
# 触发器主体
	INSERT INTO log_info VALUES ('向学生信息表中插入一行记录');
	
create table log_info(
log varchar(100)
)


CREATE TRIGGER tri_update_stu
AFTER
Update ON student
FOR EACH ROW
# 触发器主体
INSERT INTO log_info VALUES ('从学生信息表中更新了一行记录');

update student set Sname = 'ccc' where sid='20220801';

CREATE TRIGGER tri_update_stu2
AFTER
Update ON student
FOR EACH ROW
# 触发器主体
	INSERT INTO log_info VALUES (concat('从学生信息表中更新了一行记录', old.SName, '改为', new.SName));
	
update student set Sname = 'ddd' where sid='20220801';

show triggers;

#新的函数
delimiter $$
create function fib(n int)
returns int
begin
	if n=1 then
		return 0;
	elseif n=2 then
		return 1;
	else
		return fib(n-1)+fib(n-2);
	end if;
end $$

select fib(5);

delimiter $$
create function fibo(n int)
returns int
begin
	declare i int default 3;
	declare a int default 0;
	declare b int default 1;
	declare c int default 1;
	if n=1 THEN
		return 0;
	elseif n=2 THEN
		return 1;
	end if;
	
	while i <= n do
		set c = a + b;
		set a = b;
		set b = c;
		set i = i +1;
  end while;
	return c;
end $$

select fibo(5);

delimiter $$
create function idToName(id varchar(10))
returns char(10)
begin
	declare g char(10) default '';
	select sname from student where sid=id into g;
	return g;
end $$
select idToName('20331021')

CREATE PROCEDURE getNameAndMajor(id varchar(10))
	SELECT s.sname,m.mname FROM student s inner join major m on m.mid=s.mid where s.sid=id;
drop PROCEDURE getNameAndMajor;
call getNameAndMajor('20331021');

create procedure getMinAndMax(
	cid int,
	out mingrade decimal(8,2),
	out maxgrade decimal(8,2)
)
begin
	select DISTINCT min(grade) into mingrade from grade where cid=cid;
	select DISTINCT max(grade) into maxgrade from grade where cid=cid;
end;
call getMinAndMax(6,@mingrade,@maxgrade);
select @mingrade,@maxgrade;

Create Trigger relatesid       
after    
Update on student
for each row                  
begin
	Update grade g Set g.sid=new.sid  Where g.sid=old.sid and old.sid!=new.sid;
end  
set foreign_key_checks = 0
update student set sid='20331065' where sid='20331067';
set foreign_key_checks = 1

CREATE TRIGGER insert_stu_avgScore
AFTER
INSERT ON student
FOR EACH ROW
# 触发器主体
	INSERT INTO log_info VALUES (concat('平均学分为',(select AVG(scores) from student)));
drop trigger insert_stu_avgScore
insert into Student values ('20226666',1,'tominn', 1, '2000-10-21', 99, NULL,NULL);