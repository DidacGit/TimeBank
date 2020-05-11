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
  startDate date not null,
  endDate date not null,
  userConsumer int not null,
  userProducer int not null
  constraint fk_users_producer
	foreign key (userProducer)
	references Person (userId),
  constraint fk_users_consumer
	foreign key (userConsumer)
	references Person (userId))

insert into Activity (activityName, hours, startDate, endDate, userConsumer, userProducer)
values ('Actividad Uno', 5, getdate(), getdate(), 1, 2)