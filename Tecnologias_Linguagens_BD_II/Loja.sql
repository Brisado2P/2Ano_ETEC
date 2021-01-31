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
sp_help pedido

create table item_pedido(
	num_pedido numeric(4) references pedido, 
	cod_prod numeric(4) references produto,
	quant numeric(10,2)
)
sp_help item_pedido



--Cliente

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) VALUES(720, 'Ana', 'Rua 17 n.19', 'Niterói', 24358310, 'RJ', 12113231000134, 2134)

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) VALUES(870, 'Flávio', 'Av. Pres.Vargas,10', 'São Paulo', 22763931, 'SP', 2253412693879, 4631)

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj) VALUES(110, 'Jorge', 'Rua Caiapó, 13', 'Curitiba', 30078500, 'PR', 1451276498349 )

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) VALUES(222, 'Lúcia', 'Rua Itabira, 123', 'Belo Horizonte', 22124391, 'MG', 28315212393488, 2985)

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) VALUES(830, 'Mauricio', 'AV. Paulista, 1236', 'São Paulo', 3012683, 'SP', 3281698574656, 9343)

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) VALUES(130, 'Edmar', 'Rua da Praia, s/n', 'Salvador', 30079300, 'BA', 234632842349, 7121)

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) VALUES(410, 'Rodolfo', 'Largo da Lapa, 27', 'Rio de Janeiro', 30078900, 'RJ', 1283512823469, 7431)

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) VALUES(20, 'Beth', 'Av. Climério, 45', 'São Paulo', 25679300, 'SP', 3248512673268, 9280)

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, uf, cnpj, ie) VALUES(157, 'Paulo', 'Trav. Moraes, casa 3', 'Londrina', 'PR', 328482233242, 1923)

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) VALUES(180, 'Lívio', 'Av. Beira Mar, 1256', 'Florianópolis', 30077500, 'SC', 1273657123474, 1111)

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) VALUES(260, 'Susana', 'Rua Lopes Mandes, 12', 'Niterói', 30046500, 'RJ', 217635712329, 2530)

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) VALUES(290, 'Renato', 'Rua Meireles, 123', 'São Paulo', 30225900, 'SP', 1327657112314, 1820)

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) VALUES(390, 'Sebastião', 'Rua da Igreja, 10', 'Uberaba', 30438700, 'MG', 321765472133, 9071)

INSERT INTO cliente(cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) VALUES(234, 'José', 'Quadra 3, Bl. 3, sl.1003', 'Brasília', 22841650, 'DF', 2176357612323, 2931)

SELECT *FROM cliente

--Vendedor

INSERT INTO vendedor(cod_ven, nome_ven, salario_fixo, comissao) VALUES(209, 'José', 1800,'C')

INSERT INTO vendedor(cod_ven, nome_ven, salario_fixo, comissao) VALUES(111, 'Carlos', 2490,'A')

INSERT INTO vendedor(cod_ven, nome_ven, salario_fixo, comissao) VALUES(11, 'João', 2780,'C')

INSERT INTO vendedor(cod_ven, nome_ven, salario_fixo, comissao) VALUES(240, 'Antônio', 9500,'C')

INSERT INTO vendedor(cod_ven, nome_ven, salario_fixo, comissao) VALUES(720, 'Felipe', 4600,'A')

INSERT INTO vendedor(cod_ven, nome_ven, salario_fixo, comissao) VALUES(213, 'Jonas', 2300,'A')

INSERT INTO vendedor(cod_ven, nome_ven, salario_fixo, comissao) VALUES(101, 'João', 2650,'C')

INSERT INTO vendedor(cod_ven, nome_ven, salario_fixo, comissao) VALUES(310, 'Josias', 870,'B')

INSERT INTO vendedor(cod_ven, nome_ven, salario_fixo, comissao) VALUES(250, 'Maurício', 2930,'B')
		
SELECT *FROM vendedor

--Produto

INSERT INTO produto(cod_prod, unidade, descricao, val_unit) VALUES(25, 'KG', 'Queijo', 0.97)

INSERT INTO produto(cod_prod, unidade, descricao, val_unit) VALUES(31, 'BAR', 'Chocolate', 0.87)

INSERT INTO produto(cod_prod, unidade, descricao, val_unit) VALUES(78, 'L', 'Vinho', 2.00)

INSERT INTO produto(cod_prod, unidade, descricao, val_unit) VALUES(22, 'M', 'Linho', 0.11)

INSERT INTO produto(cod_prod, unidade, descricao, val_unit) VALUES(30, 'SAC', 'Acucar', 0.30)

INSERT INTO produto(cod_prod, unidade, descricao, val_unit) VALUES(53, 'M', 'Linha', 1.80)

INSERT INTO produto(cod_prod, unidade, descricao, val_unit) VALUES(13, 'G', 'Ouro', 6.18)

INSERT INTO produto(cod_prod, unidade, descricao, val_unit) VALUES(45, 'M', 'Madeira', 0.25)

INSERT INTO produto(cod_prod, unidade, descricao, val_unit) VALUES(87, 'M', 'Cano', 1.97)

INSERT INTO produto(cod_prod, unidade, descricao, val_unit) VALUES(77, 'M', 'Papel', 1.05)

SELECT *FROM produto

--Pedido

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(121, 20, 410, 209)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(97, 20, 720, 101)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(101, 15, 720, 101)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(137, 20, 720, 720)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(148, 20, 720, 101)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(189, 15, 870, 213)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(104, 30, 110, 101)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(203, 30, 830, 250)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(98, 20, 410, 209)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(143, 30, 20, 111)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(105, 30, 180, 240)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(111, 15, 260, 240)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(103, 20, 260, 11)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(91, 20, 260, 11)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(138, 20, 260, 11)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(108, 15, 290, 310)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(119, 30, 390, 250)

INSERT INTO pedido(num_pedido, pr_entrega, cod_clie, cod_ven) VALUES(127, 10,410, 11)

SELECT *FROM pedido

INSERT INTO item_pedido(num_pedido,cod_prod, quant) VALUES(121,25,10)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(121, 31, 35)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(97, 77, 20)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(101, 31, 9)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(101, 78, 18)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(101, 13, 5)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(98, 77, 5)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(148, 45, 8)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(148, 31, 7)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(148, 77, 3)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(148, 25, 10)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(148, 78, 30)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(104, 53, 32)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(203, 31, 6)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(189, 78, 45)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(143, 31, 20)

INSERT INTO item_pedido(num_pedido,cod_prod,quant) VALUES(143, 78, 10)

SELECT *FROM item_pedido


--resposta 1

select * from cliente
select * from vendedor
select * from produto
select num_pedido, cod_prod from item_pedido order by 1
select nome_clie, endereco, cnpj, uf from cliente where uf = 'SP'
select nome_ven, salario_fixo from vendedor where salario_fixo < 2500
select * from pedido where cod_ven <> 101
select num_pedido, cod_prod from item_pedido order by 1
select nome_ven, salario_fixo, comissao, cod_ven from vendedor where salario_fixo > 2500 and comissao = 'C' and cod_ven  <= 100
select * from pedido where num_pedido > 100 and cod_ven = 209 or cod_ven = 101 or cod_ven = 213




--resposta 2

select *from cliente where cod_clie > 500 and cod_clie <800
SELECT *from pedido WHERE num_pedido not between 200 and 300
SELECT *from cliente where nome_clie BETWEEN 'b%' and  'j%' 
SELECT cod_prod, quant FROM item_pedido WHERE num_pedido in(143, 101,121)
SELECT *from vendedor WHERE comissao in('A','C')
SELECT *from pedido where num_pedido not in(870,720)

SELECT *from cliente where nome_clie like 'A%'

SELECT *from cliente where nome_clie like 'O%'

SELECT *from cliente where nome_clie like '%s'

SELECT *from cliente where nome_clie like '%a%' and nome_clie not like '%e%' or 

--resposta 3

select count(cod_ven) from vendedor
select count(uf) from cliente where uf not like 'SP'
select count(num_pedido) from pedido where num_pedido like 25
select sum(quant) from item_pedido group by num_pedido
select cod_ven, count(num_pedido) as 'Quantidade de pedidos' from pedido group by (cod_ven)
select cod_ven, count(num_pedido) as 'Quantidade de pedidos' from pedido group by (cod_ven) having count(num_pedido)>3
select count(num_pedido) as 'Quantidade pedidos' from pedido
select count(cod_ven) from vendedor where comissao like 'C'
select count(uf) from cliente where uf  like 'SP'
select count(num_pedido) from pedido where cod_clie like 260

--exercicio 4 - 03/06

select nome_ven, salario_fixo from vendedor where salario_fixo = (select max(salario_fixo) from vendedor)

select descricao, val_unit from produto where val_unit = (select min(val_unit) from produto)

select nome_ven, salario_fixo from vendedor WHERE salario_fixo > (select avg(salario_fixo) from vendedor)

select nome_ven, salario_fixo from vendedor where salario_fixo = (select max(salario_fixo) from vendedor) or salario_fixo = (select min(salario_fixo) from vendedor) 
 
