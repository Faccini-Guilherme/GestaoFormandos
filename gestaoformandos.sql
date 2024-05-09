drop database if exists gestaoformandos;

create database gestaoformandos;

use gestaoformandos;

create table formando (
	id_formando		int,
    nome			varchar(100) not null,
    morada			varchar(100) not null,
    contacto 		varchar(9) null,
    iban			varchar(50) not null default '0',
    sexo			char(1)	not null,
    data_nascimento	date not null,
    primary key (id_formando)
);

select max(id_formando) + 1 from formando;
delete from formando;

create table nacionalidade (
	id_nacionalidade int(11) not null auto_increment,
    alf2 varchar(2) default null unique,
    nacionalidade varchar(100) not null,
    primary key (id_nacionalidade)
);

insert into nacionalidade (id_nacionalidade, alf2, nacionalidade) values
(1, 'MO', 'Macau');

insert into nacionalidade (id_nacionalidade, alf2, nacionalidade) values
(0, 'PT', 'Portugal');

select * from nacionalidade;

select * from formando;

alter table formando
	add column id_nacionalidade int,
    add constraint fk_nacionalidade foreign key (id_nacionalidade) references nacionalidade (id_nacionalidade) 
		on update cascade;
        
create view vFormando as
select
	f.id_formando,
    f.nome, 
    f.iban,
    f.contacto,
    f.sexo,
    n.nacionalidade,
    n.id_nacionalidade
from
	formando f, nacionalidade n
where	
	f.id_nacionalidade = n.id_nacionalidade;

select
	f.id_formando,
    f.nome,
    f.morada,
    f.contacto,
    f.iban,
    f.sexo,
    f.data_nascimento,
    n.nacionalidade as nacionalidade
from
	formando f
join
	nacionalidade n on f.id_nacionalidade = n.id_nacionalidade;
    
select sha2(nome,512) from formando;
create table users (
	uname varchar(15) primary key,
    pwd varchar(25) not null,
    userRole varchar(25) not null
);
insert into users (uname, pwd, userRole) values
('user1','user1','Manager'),
('user2','user2','Admin'),
('user3','user3','User');

select * from users;

select * from users where binary uname = 'user1' and binary pwd = 'user1'; 

select uname, pwd, sha2(pwd,512) from users;

alter table users modify column pwd varchar(128);

update users set pwd = sha2(pwd,512);

select * from users where binary uname = 'user1';

select * from users where binary uname = 'user1' and pwd = sha2("user1",512);

insert into users (uname, pwd, userRole) values
('user4',sha2('user4',512),'Manager');

select uname from users where binary uname = 'user' and pwd = sha2("user1",512);
create table utilizador (
	id_utilizador int auto_increment primary key,
    nome_utilizador varchar(15) not null unique,
    palavra_passe varchar(128) not null,
    falhas tinyint default 0,
    estado enum('A', 'I') default 'A'
);

insert into utilizador (nome_utilizador, palavra_passe) values 
('user1', sha2('user1',512)),
('user2', sha2('user2',512)),
('user3', sha2('user3',512));


delimiter //
create procedure pUSuccessLogin (userName varchar(15), result char(1))
begin 
	if (result = 'S') then
		update utilizador set falhas = 0 where nome_utilizador = userName;
	else	
		update utilizador set falhas = falhas + 1 where nome_utilizador = userName;
	end if;
end //
delimiter ;

select * from utilizador;
call pUSuccessLogin('user1', 'U');
call pUSuccessLogin('user1', 'U');
call pUSuccessLogin('user1', 'U');

call pUSuccessLogin('user1', 'S');

delimiter //
create trigger tLogin before update on utilizador
for each row
begin
	if (new.falhas = 5) then
		set new.estado = 'I';
	end if;
end //
delimiter ;

update utilizador set estado = 'A' where id_utilizador = 1;

create table area (
	id_area			int auto_increment,
    area			varchar(100) not null unique,
    primary key (id_area)
);
insert into area (id_area, area) values
(1, 'Geografia');
create table formador (
	id_formador		int auto_increment,
    nome			varchar(100) not null,
    nif				varchar(9),
    dataNascimento	date,
    id_area			int,
    id_utilizador	int,
    primary key (id_formador),
    foreign key (id_area) references area (id_area)
		on update cascade,
    foreign key (id_utilizador) references utilizador (id_utilizador)
		on update cascade
);
select * from nacionalidade;

select * from formando;

select * from formador;

select *from area;

select * from utilizador;

select * from formando;
        
create view vformador as
select
	f.id_formador,
    f.nome, 
    f.nif,
    f.dataNascimento,
    a.id_area,
    f.id_utilizador,
    a.area
from
	formador f, area a
where	
	f.id_area = a.id_area;

select
	f.id_formador,
    f.nome, 
    f.nif,
    f.dataNascimento,
    f.id_utilizador,
    a.area as area
from
	formador f
join
	area a on f.id_area = a.id_area;




