	create database Servico
	use Servico

	create table Ramo_Atividade(
	cd_ramo numeric(4) constraint cd_ramo_pk primary key,
	ds_ramo char(100)
	)

	create table Tipo_Assinante(
	cd_tipo numeric(4) constraint cd_tipo_pk primary key,
	ds_tipo char(100)
	)

	create table Assinante(
	cd_assinante numeric(4) constraint cd_as_pk primary key,
	nm_assinante char(30) constraint nm_as_nn not null,
	fk_ramo numeric(4) references Ramo_Atividade,
	fk_tipo numeric(4) references Tipo_Assinante
	)

	create table Municipio(
	cd_municipio numeric(7) constraint cd_mun_pk primary key,
	ds_municipio char(100) constraint ds_mun_nn not null
	)

	create table Endereco(
	cd_endereco numeric(4) constraint cd_end_pk primary key,
	ds_endereco varchar(100) constraint ds_end_nn not null,
	complemento integer,
	bairro char(50) constraint br_end_nn not null,
	CEP numeric(11) constraint cep_end_nn not null,
	fk_assinante numeric(4) references Assinante,
	fk_Municipio numeric(7) references Municipio
	)

	create table Telefone(
	cd_fone numeric(4) constraint cd_tel_pk primary key,
	ddd numeric(3) constraint ddd_tel_nn not null,
	n_fone numeric(8) constraint n_tel_nn not null,
	fk_endereco numeric(4) references Endereco
	)

	


--- Inserts

	insert into Ramo_Atividade(cd_ramo, ds_ramo) VALUES(1,'Assasinato')
	insert into Ramo_Atividade(cd_ramo, ds_ramo) VALUES(2,'Roubo qualificado')

	insert into Tipo_Assinante(cd_tipo, ds_tipo) VALUES(1,'Normal')
	insert into Tipo_Assinante(cd_tipo, ds_tipo) VALUES(2,'Luxo')
	insert into Tipo_Assinante(cd_tipo, ds_tipo) VALUES(3,'Residencial')

	insert into Assinante(cd_assinante, nm_assinante, fk_ramo, fk_tipo) VALUES(1,'Pamela', 1, 2)
	insert into Assinante(cd_assinante, nm_assinante, fk_ramo, fk_tipo) VALUES(2,'Turco', 2, 1)
	insert into Assinante(cd_assinante, nm_assinante, fk_ramo, fk_tipo) VALUES(3,'Hey', 2, 3)

	insert into Assinante(cd_assinante, nm_assinante, fk_ramo, fk_tipo) VALUES(1,'Pamela', 1, 2)
	insert into Assinante(cd_assinante, nm_assinante, fk_ramo, fk_tipo) VALUES(2,'Turco', 2, 1)
	insert into Assinante(cd_assinante, nm_assinante, fk_ramo, fk_tipo) VALUES(3,'Hey', 2, 3)

	insert into Municipio( cd_municipio, ds_municipio) VALUES(1200252, 'EPITACIOLÂNDIA')
	insert into Municipio( cd_municipio, ds_municipio) VALUES(1200302, 'FEIJÓ')
	insert into Municipio( cd_municipio, ds_municipio) VALUES(1200112, 'SÂO PAULO')

	insert into Endereco(cd_endereco, ds_endereco, complemento, bairro, CEP, fk_assinante, fk_Municipio) VALUES(1,'Rua James Azevedo', 320, 'Jardim Bonita', 02289560, 1, 1200252)
	insert into Endereco(cd_endereco, ds_endereco, complemento, bairro, CEP, fk_assinante, fk_Municipio) VALUES(2,'Rua do Brás', 560, 'Brás', 02203560, 2, 1200302)

	insert into Telefone(cd_fone, ddd, n_fone, fk_endereco) VALUES(1, 11, 29990000, 1)
	insert into Telefone(cd_fone, ddd, n_fone, fk_endereco) VALUES(2, 21, 28790021, 2)

------------------

--A)
	SELECT a.nm_assinante, e.ds_endereco, e.bairro, e.CEP, e.complemento, t.n_fone  from Assinante a inner join Endereco e on a.cd_assinante = e.cd_endereco inner join Telefone t on a.cd_assinante = t.cd_fone
--B)
	SELECT  r.cd_ramo, a.nm_assinante from Assinante a inner join Ramo_Atividade r on a.cd_assinante = r.cd_ramo order by cd_ramo 
--C)
	SELECT  m.cd_municipio, m.ds_municipio, a.nm_assinante from Assinante a inner join Municipio m on a.cd_assinante = m.cd_municipio where ds_municipio = 'SÃO PAULO'

