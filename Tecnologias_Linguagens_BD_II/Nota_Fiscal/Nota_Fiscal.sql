Create table nota_fiscal(
	ID_NF	numeric(1) constraint nota_nf_nn not null,
	ID_ITEM numeric(1) constraint nota_item_nn not null,
	COD_PROD numeric(2) constraint nota_cod_nn not null,
	VALOR_UNIT numeric(5,2) constraint nota_valor_nn not null,
	QUANTIDADE numeric(3) constraint nota_quant_nn not null,
	DESCONTO numeric(2)
	)

INSERT INTO nota_fiscal(ID_NF, ID_ITEM, COD_PROD, VALOR_UNIT, QUANTIDADE, DESCONTO) VALUES(5,2,5,30,6, null)
INSERT INTO nota_fiscal(ID_NF, ID_ITEM, COD_PROD, VALOR_UNIT, QUANTIDADE, DESCONTO) VALUES(6,1,1,25,22,15)
INSERT INTO nota_fiscal(ID_NF, ID_ITEM, COD_PROD, VALOR_UNIT, QUANTIDADE, DESCONTO) VALUES(6,2,3,15,25,20)
INSERT INTO nota_fiscal(ID_NF, ID_ITEM, COD_PROD, VALOR_UNIT, QUANTIDADE, DESCONTO) VALUES(7,1,1,25,10,3)
INSERT INTO nota_fiscal(ID_NF, ID_ITEM, COD_PROD, VALOR_UNIT, QUANTIDADE, DESCONTO) VALUES(7,2,2,13.50,10,4)
INSERT INTO nota_fiscal(ID_NF, ID_ITEM, COD_PROD, VALOR_UNIT, QUANTIDADE, DESCONTO) VALUES(7,3,3,15,10,4)
INSERT INTO nota_fiscal(ID_NF, ID_ITEM, COD_PROD, VALOR_UNIT, QUANTIDADE, DESCONTO) VALUES(7,4,5,30,10,1)

--1)
 select ID_NF, ID_ITEM, COD_PROD, VALOR_UNIT from nota_fiscal where DESCONTO is not null 

--2)
 select ID_NF, ID_ITEM, COD_PROD, VALOR_UNIT, VALOR_UNIT-(VALOR_UNIT*(DESCONTO/100)) as 'Valor vendido ' from nota_fiscal where DESCONTO is not null 

--3)

UPDATE nota_fiscal SET DESCONTO = 0 WHERE DESCONTO = is null

--4)
 select ID_NF, ID_ITEM, COD_PROD, VALOR_UNIT, VALOR_UNIT-(VALOR_UNIT*(DESCONTO/100)) as 'Valor vendido ', DESCONTO, QUANTIDADE*VALOR_UNIT as 'Valor Total' from nota_fiscal
 
--5)

 select count(ID_NF), COD_PROD, VALOR_UNIT, QUANTIDADE*VALOR_UNIT as 'Valor Total' from nota_fiscal order by 1