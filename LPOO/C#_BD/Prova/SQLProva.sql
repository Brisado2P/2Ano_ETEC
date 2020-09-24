create database Prova

use Prova

create table registro(
	id int constraint re_id_pk primary key,
	nome char(60) constraint re_nm_nn not null,
	cargo varchar(60) constraint re_cg_nn not null
)

insert into registro values(1, 'Carlos', 'Diretor de RH' )
select * from registro