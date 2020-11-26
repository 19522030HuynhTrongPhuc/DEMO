create table VOCABULARY
(
	id int not null,
	WORD nvarchar(255) default null,
	MEAN nvarchar(255) default null
)
create table USERINFO
(
	id int not null,
	username varchar(90),
	hashPass varchar(255),
	email varchar(90) 
)
create table Learned
(
	id_word int not null,
	id_user int not null
)
alter table Learned
add constraint PK_Learned primary key(id_word, id_user)

insert into Learned (id_word, id_user) values (2,1)
delete from Learned


select v.id, v.WORD, v.MEAN  from VOCABULARY v 
where v.id not in (select id_word from Learned l where l.id_user=1)
order by v.id



select * from Learned



create table ToLearn
(
	id_word int not null,
	id_user int not null
)
delete from ToLearn
alter table ToLearn
add constraint PK_ToLearn primary key(id_word, id_user)
select * from ToLearn
insert into USERINFO
	(id, username, hashPass, email)
values
	(0,'NguyenCongPhi','kkkkkkkk','phicongyugioh@gmail.com')

select id, username, email from USERINFO where id=0
select count(*) from ToLearn where id_user=0;
use ENGLISHVO
select count(*) as dem from ToLearn where id_user=0
select * from VOCABULARY order by id
select WORD from VOCABULARY where WORD like'a%'

create table FlashCard
(

	id int primary key not null,
	word varchar(255), 
	mean varchar(255),
	userID int 
)
drop table FlashCard

insert into FlashCard
	(id, word, mean, userID)
values
	()

select * from FlashCard