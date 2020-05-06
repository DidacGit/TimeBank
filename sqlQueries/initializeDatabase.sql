use TimeBank

--DROP TABLE IF EXISTS Person
--CREATE TABLE Person (
--    PersonId int not null,
--    Name varchar(255)
--	primary key (PersonId)
--);

drop table if exists TimeBank.dbo.Persons
drop table if exists TimeBank.dbo.Person
drop table if exists TimeBank.dbo.Activity

create table TimeBank.dbo.Person (
  userId int identity(1,1) primary key,
  userName varchar(100) not null,
  phone varchar(100) not null,
  email varchar(100) not null,
  hours int not null default 0,
  password varchar(100) not null)

insert into Person (userName, phone, email, hours, password)
values ('Marcos', '666777888', 'marcos@mail.com', 5, 'marcospass')

insert into Person (userName, phone, email, hours, password)
values ('Helena', '678123456', 'helena@mail.com', 10, 'helenapass')

insert into Person (userName, phone, email, hours, password)
values ('Marta', '612783233', 'marta@mail.com', 15, 'martapass')

--create table Activity (
--  userProducer int not null,
--  `user_consumer` INT(11) not null,
--  `idActivity` INT(11) not null,
--  `activity` varchar(45) NULL,
--  `start_date` DATE NULL,
--  `end_date` DATE NULL,
--  PRIMARY KEY (`user_producer`, `user_consumer`, `idActivity`),
--  INDEX `fk_user_has_user_user2_idx` (`user_consumer` ASC),
--  INDEX `fk_user_has_user_user1_idx` (`user_producer` ASC),
--  CONSTRAINT `fk_user_has_user_user1`
--    FOREIGN KEY (`user_producer`)
--    REFERENCES `mydb`.`user` (`id`)
--    ON DELETE NO ACTION
--    ON UPDATE NO ACTION,
--  CONSTRAINT `fk_user_has_user_user2`
--    FOREIGN KEY (`user_consumer`)
--    REFERENCES `mydb`.`user` (`id`)
--    ON DELETE NO ACTION
--    ON UPDATE NO ACTION);