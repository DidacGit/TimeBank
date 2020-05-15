use TimeBank

drop table if exists TimeBank.dbo.Activity
drop table if exists TimeBank.dbo.Person

create table TimeBank.dbo.Person (
  userId int identity(1,1) primary key,
  userName varchar(100) not null,
  phone varchar(100) not null,
  email varchar(100) unique not null,
  hours int not null default 0,
  password varchar(100) not null)

insert into Person (userName, phone, email, hours, password)
values ('Marcos', '666777888', 'marcos@mail.com', 5, 'marcospass')

insert into Person (userName, phone, email, hours, password)
values ('Helena', '678123456', 'helena@mail.com', 10, 'helenapass')

insert into Person (userName, phone, email, hours, password)
values ('Marta', '612783233', 'marta@mail.com', 15, 'martapass')

create table Activity (
  activityId int identity(1,1) primary key,
  activityName varchar(100) not null,
  hours int not null,
  activityDate date not null,
  userConsumer int not null,
  userProducer int not null
  constraint fk_users_producer
	foreign key (userProducer)
	references Person (userId),
  constraint fk_users_consumer
	foreign key (userConsumer)
	references Person (userId))

insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A1 C: MARCOS P: HELENA', 5, getdate(), 1, 2)
insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A2 C: HELENA P: MARTA', 5, getdate(), 2, 3)
insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A3 C: MARCOS P: MARCOS', 5, getdate(), 1, 1)
insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A4 C: HELENA P: HELENA', 5, getdate(), 2, 2)
insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A5 C: MARTA P: MARTA', 5, getdate(), 3, 3)
insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A6 C: MARTA P: MARCOS', 5, getdate(), 3, 1)
insert into Activity (activityName, hours, activityDate, userConsumer, userProducer)
values ('A7 C: MARTA P: MARCOS', 5, getdate(), 3, 1)
