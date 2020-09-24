Pamela e Victor


create table BANCO(
Codigo numeric(1) 
	constraint ban_cod_pk primary key,
Nome varchar(40) 
	constraint ban_nm_nn not null
)

create table AGENCIA(
Numero_agencia numeric(4) 
	constraint age_num_pk primary key,
Endereco varchar(40) 
	constraint age_end_nn not null,
Cod_banco numeric (1) 
	constraint age_cb_fk references BANCO
)

create table CLIENTE(
Cpf numeric(11) 
	constraint cli_cpf_pk primary key,
Nome char(40) 
	constraint cli_nm_nn not null,
Sexo char(1) constraint cli_sexo_nn not null,
Endereco varchar(40) constraint cli_end_nn not null
)

create table CONTA(
Numero_Conta numeric(6) constraint con_nm_pk primary key,
Saldo numeric(12,2) constraint con_sal_nn not null,
Tipo_conta numeric(1) constraint con_tipo_nn not null,
Num_agencia numeric(4) constraint con_numA_fk references AGENCIA
)

create table HISTORICO(
Cpf numeric(11) constraint his_cpf_fk references CLIENTE,
Num_Conta  numeric(6) constraint his_nc_fk references CONTA,
Data_inicio date 
)

create table TELEFONE_CLIENTE(
Cpf_cli numeric(11) constraint tel_cpf_fk references CLIENTE,
Telefone_cli numeric(10) constraint tel_tc_pk primary key
)

INSERT INTO BANCO(Codigo, Nome) VALUES(1, 'Banco do Brasil')
INSERT INTO BANCO(Codigo, Nome) VALUES(4, 'CEF')

INSERT INTO AGENCIA(Numero_agencia, Endereco) VALUES(0562, 'Rua Joaquim Teixeira Alvez, 1555')
INSERT INTO AGENCIA(Numero_agencia, Endereco) VALUES(3153, 'AV. Marcelino Pires, 1960')

INSERT INTO CLIENTE(Cpf, Nome, Sexo, Endereco) VALUES(11122233344, 'Jennifer B Souza', 'F', 'Rua Cuiab�, 1050')
INSERT INTO CLIENTE(Cpf, Nome, Sexo, Endereco) VALUES(66677788899, 'Caetano K Lima', 'M', 'Rua Ivinhema, 879')
INSERT INTO CLIENTE(Cpf, Nome, Sexo, Endereco) VALUES(55544477733, 'Silvia Macedo', 'F', 'Rua Estados Unidos, 735')

INSERT INTO CONTA(Numero_Conta, Saldo, Tipo_conta) VALUES(863402, 76305, 2)
INSERT INTO CONTA(Numero_Conta, Saldo, Tipo_conta) VALUES(235847, 387912, 1)

INSERT INTO HISTORICO(Data_inicio) VALUES(17121997)
INSERT INTO HISTORICO(Data_inicio) VALUES(17121997)
INSERT INTO HISTORICO(Data_inicio) VALUES(29112010)

INSERT INTO TELEFONE_CLIENTE(Telefone_cli) VALUES(6734227788)
INSERT INTO TELEFONE_CLIENTE(Telefone_cli) VALUES(6734239900)
INSERT INTO TELEFONE_CLIENTE(Telefone_cli) VALUES(6781218833)

Alter table CLIENTE
add dt_cadastro date 

Alter table CLIENTE
add email varchar(30)




