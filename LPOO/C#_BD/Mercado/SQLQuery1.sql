create database aula_edson

use aula_edson

create table alimentos
(
	id_alimento integer primary key NOT NULL,
	alimento varchar(30) NOT NULL,
	quantidade integer,
	data_fabricacao date,
	data_validade date,
	preco real
)

select * from alimentos