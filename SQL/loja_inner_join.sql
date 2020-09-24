create database loja

use loja

create table cliente(
	cod_clie numeric(4) constraint clie_cod_pk primary key,
	nome_clie varchar(20) constraint clie_nm_nn not null,
	endereco varchar(30),
	cidade varchar(15),
	cep char(8),
	uf char(2),
	cnpj char(16),
	ie char(12)
)

create table vendedor(
	cod_ven numeric(4) constraint vend_cod_pk primary key,
	nome_ven varchar(20) constraint vend_nm_nn not null,
	salario_fixo numeric(10,2),
	comissao char(1)
)
select *from vendedor
create table produto(
	cod_prod numeric(4) constraint prod_cod_pk primary key,
	unidade varchar(3),
	descricao varchar(20),
	val_unit numeric(10,2)
)
sp_help produto

create table pedido(
	num_pedido numeric(4) constraint ped_num_pk primary key,
	pr_entrega numeric(3) constraint ped_entrega_nn not null,
	cod_clie numeric(4) references cliente,
	cod_ven numeric(4) references vendedor
)


create table item_pedido(
	num_pedido numeric(4) references pedido, 
	cod_prod numeric(4) references produto,
	quant numeric(10,2)
)




--1) Listar o cliente(nome) e o nr do seu pedido

	SELECT c.nome_clie, p.num_pedido from cliente c 
	inner join pedido p on c.cod_clie = p.cod_clie   

--2)Listar o vendedor(nome) e o nr do seu pedido

	SELECT p.num_pedido, v.nome_ven  from vendedor v 
	inner join pedido p on v.cod_ven = p.cod_ven order by num_pedido 

--3) Mostrar o nome do vendedor, seus pedidos e o nome do cliente que ele atendeu

	SELECT v.nome_ven, p.num_pedido, c.nome_clie from pedido p 
	inner join vendedor v on v.cod_ven = p.cod_ven  
	inner join cliente c on  c.cod_clie = p.cod_clie 

--4) Listar os pedidos com a descrição dos produtos

	SELECT i.num_pedido, pro.descricao from produto pro 
	inner join item_pedido i on pro.cod_prod = i.cod_prod
	
--5) Exibir qtos pedidos cada vendedor efetuou mostrando seu nome

	SELECT p.num_pedido, v.nome_ven, COUNT(v.cod_ven) as ' Quantidade' from pedido p 
	inner join vendedor v on v.cod_ven = p.cod_ven 

	SELECT v.nome_ven, p.cod_ven, COUNT(p.num_pedido) from pedido p 
	inner join vendedor v on p.cod_ven = v.cod_ven group by(p.cod_ven)  

--6) Mostre quais clientes(nome) não possuem pedido

	select c.nome_clie from cliente c
    left join pedido p on c.cod_clie = p.cod_clie where p.num_pedido is null 

	select *from pedido
	select *from cliente

--7) Crie um relatorio que mostre quais produtos(descricao) cada vendedor vende

	SELECT p.descricao from produto p on pedido p = 

