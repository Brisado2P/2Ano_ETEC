create database Estoque

use Estoque;

--TABLE CLIENTE

create table cliente(
	cpf numeric (11)
		constraint cli_id_pk primary key,
	nome varchar (40)
		constraint cli_nom_nn not null,
	endereco varchar (40)
		constraint cli_end_nn not null,
	dt_nasci date,
	situacao numeric (1) 
		constraint cli_sit_nn not null,
	telefone numeric (9)
		constraint cli_tel_nn not null
)

--TABLE ESTOQUE

create table estoque(
	id_estoq numeric identity (1,1)
		constraint id_est_pk primary key,
	situacao_estoque varchar (80)
		constraint sit_est_nn not null,
	endereco varchar (40)
		constraint end_est_nn not null,
	area_armaz varchar (40) 
		constraint area_est_nn not null,
	qtd_prod numeric (5) 
		constraint qtd_est_nn not null
)


--TABLE ADM

create table adm(
	id_adm numeric identity (1,1)
		constraint adm_id_pk primary key,
	login_adm varchar (30) 
		constraint adm_log_nn not null,
	/*id_adm_ven numeric
	constraint adm_idven_fk foreign key
	references vendedor
	
	Para criação dessa coluna, executar o alter table após a criação de todas as tabelas
	*/
)

--TABLE VENDEDOR

create table vendedor(
	id_ven numeric identity (1,1) 
		constraint vend_id_pk primary key,
	senha numeric (26) 
		constraint adm_sen_nn not null,
	nome_ven varchar (20) 
		constraint vend_nm_nn not null,
	endereco varchar (40)
		constraint cli_end_nn not null,
	salario_fixo numeric (8,2)
		constraint vend_sal_nn not null,
	dt_registro date,
	telefone numeric (11),
	id_vend_adm numeric 
		constraint adm_id_fk foreign key
		references adm
)

--TABLE PEDIDO

create table pedido(
	cod_pedido numeric identity (1,1) 
		constraint ped_cod_pk primary key,
	valor_total numeric (10, 2)
		constraint ped_val_nn not null, 
	dt_emis date,
	cpf numeric (11)
		constraint cli_cpf_fk foreign key
		references cliente,
	id_ven_pedido numeric 
		constraint vend_id_fk foreign key
		references vendedor
)

--TABLE PRODUTO

create table produto(
	id_prod numeric identity (1,1) 
		constraint prod_id_pk primary key,
	nome varchar (20)
		constraint prod_nome_nn not null,
	dt_fabric date,
	dt_valid date,
	preco numeric (6,2) 
		constraint prod_prec_nn not null,
	marca varchar (40)
		constraint prod_mar_nn not null,
	id_estoq_prod numeric
		constraint prod_id_estoque_fk
		references estoque
)

--TABLE ITEM_PEDIDO

create table item_pedido(
	id_item numeric identity (1,1)
		constraint ped_id_pk primary key,
	tipo_prod varchar (20)
		constraint ped_tipo_nn not null,
	qtd_prod numeric (10)
		constraint ped_qtd_nn not null,
	fk_pedido numeric 
		constraint ped_cod_fk foreign key
		references pedido

)

--TABLE VENDC

create table vendC(
	cpf_vend numeric (11)
		constraint vendC_cpf_pk primary key,
	id_ven_C numeric 
		constraint vendC_idven_fk foreign key
		references vendedor
)

create table pedido_produto(
	pedido numeric
		constraint pedprod_pedido_fk
		references pedido,
	produto numeric
		constraint pedprod_produto_fk
		references produto,

)


--ADICIONANDO A FOREIGN KEY PARA VENDEDOR (SE COLOCAR DIRETO NÃO VAI FUNFAR)

alter table adm
add id_adm_ven numeric constraint adm_idven_fk foreign key references vendedor

select * from adm
select * from item_pedido

--INSERTS ADM

insert into adm (login_adm)
values ('Administrador')


--INSERTS VENDEDOR

insert into vendedor (senha, nome_ven, endereco, salario_fixo, dt_registro, telefone, id_vend_adm)
values (1234, 'Victor', 'Rua Alcântra, 113', 5000, '2012-12-12', 963972037, 01)

insert into vendedor (senha, nome_ven, endereco, salario_fixo, dt_registro, telefone, id_vend_adm)
values (5678, 'Maluf', 'Rua Pedro de Campos, 40', 1001, '2016-01-01', 965897803, null)

insert into vendedor (senha, nome_ven, endereco, salario_fixo, dt_registro, telefone, id_vend_adm)
values (9012, 'Pamela', 'Jardim Corisco, 306', 1000, '2009-05-20', 973667683, null)

/* para inserção da foreign key na tabela adm utilizar o update a seguir*/

update adm
set login_adm = 'Administrador', id_adm_ven = 01
where id_adm = 01


--INSERTS CLIENTE

insert into cliente (cpf, nome, endereco, dt_nasci, situacao, telefone)
values (12345678901, 'Breno', 'Capitão Rubens, 736', '2003-08-04', 0, 979694117)

insert into cliente (cpf, nome, endereco, dt_nasci, situacao, telefone)
values (23456789012, 'Pablo', 'Pero Henrique Cruz, 901', '2004-09-05', 1, 958945223)

insert into cliente (cpf, nome, endereco, dt_nasci, situacao, telefone)
values (34567890123, 'Bruno', 'Esmeralda Avermelhada, 007', '2005-10-06', 0, 974102323)

--TESTE
select * from adm
select * from vendedor
select * from cliente

--INSERTS ESTOQUE

insert into estoque (situacao_estoque, endereco, area_armaz, qtd_prod)
values ('Com a capacidade quase cheia de acordo com o esperado', 'Rua Maria Alcântara, 440', 'Mais Fria', 100)

insert into estoque (situacao_estoque, endereco, area_armaz, qtd_prod)
values ('Com a capacidade mediana de acordo com o esperado', 'Rua Pedro Alcântara, 450', 'Fria', 250)

insert into estoque (situacao_estoque, endereco, area_armaz, qtd_prod)
values ('Com a capacidade de cheia acordo com o esperado', 'Rua João Alcântara, 460', 'Temperatura ambiente', 320)

--INSERTS PRODUTO


insert into produto (nome, dt_fabric, dt_valid, preco, marca, id_estoq_prod)
values ('MagicRaibow', '2004-04-04', '2005-05-05', 10.00, 'Ben & Jerrys', 01) 

insert into produto (nome, dt_fabric, dt_valid, preco, marca, id_estoq_prod)
values ('MagicSugar', '2005-05-05', '2006-06-06', 5.00, 'BJFS', 02) 

insert into produto (nome, dt_fabric, dt_valid, preco, marca, id_estoq_prod)
values ('Casquinha', '2007-07-07', '2008-08-08', 1.00, 'ShinraS', 03)

--INSERTS PEDIDO
insert into pedido (valor_total, dt_emis, cpf, id_ven_pedido)
values (10.00, '2019/12/19', 12345678901, 01)

insert into pedido (valor_total, dt_emis, cpf, id_ven_pedido)
values (17.00, '2020/11/20', 23456789012, 02)

insert into pedido (valor_total, dt_emis, cpf, id_ven_pedido)
values (29.00, '2019/10/21', 34567890123, 03)

select * from pedido


--INSERTS ITEM_PEDIDO

insert into item_pedido (tipo_prod, qtd_prod, fk_pedido)
values ('Casquinha', 1, 01)

insert into item_pedido (tipo_prod, qtd_prod, fk_pedido)
values ('Sunday', 2, 02)

insert into item_pedido (tipo_prod, qtd_prod, fk_pedido)
values ('Copinho', 3, 03)

--INSERTS VENDC (VENDEDOR COMUM)

insert into vendC (cpf_vend, id_ven_C)
values (12345678901, 01)

insert into vendC (cpf_vend, id_ven_C)
values (23456789012, 02)

insert into vendC (cpf_vend, id_ven_C)
values (34567890123, 03)

--INSERT PEDIDO_PRODUTO


insert into pedido_produto (pedido, produto)
values (01,01)

insert into pedido_produto (pedido, produto)
values (02,02)

insert into pedido_produto (pedido, produto)
values (03,03)


/****** Object:  Database [Estoque]    Script Date: 20/11/2019 16:06:31 ******/
/*DROP DATABASE [Estoque]
GO

USE [master]
GO*/

delete from adm
delete from vendedor
delete from cliente
delete from produto
delete from pedido
delete from item_pedido
delete from estoque
delete from vendC

drop table cliente
drop table estoque
drop table adm
drop table vendedor
drop table pedido
drop table produto
drop table item_pedido
drop table vendC

UPDATE vendedor SET salario_fixo = 1
WHERE id_ven = 2