create table ORGAO(
cod_orgao numeric(4) constraint org_cod_pk primary key,
nome_orgao varchar(20) constraint org_nm_nn not null
)

create table FUNCIONARIO(
matricula numeric(5) constraint fun_mat_pk primary key,
nome_func char(40) constraint fun_nm_nn not null,
anos_servico numeric(2),
cod_orgao numeric(4) references ORGAO,
salario numeric(8,2) constraint fun_sal_nn not null
)

create table DEPARTAMENTO(
cod_depto numeric(5) constraint dep_cod_pk primary key,
localizacao varchar(40) constraint dep_loc_nn not null
)

create table DIVISAO(
cod_div numeric(5) constraint div_cod_pk primary key,
nome_div varchar(30) constraint div_nm_nn not null
)

create table SUBORDINADO(
cod_depto numeric(5) references DEPARTAMENTO,
cod_div numeric(5) references DIVISAO,
matricula numeric(5) references FUNCIONARIO

)

create table GERENCIA(
mat_ger numeric(5) references FUNCIONARIO,
cod_orgao numeric(4) references ORGAO

)

create table FUNC_COMUM(
mat_func numeric(5) constraint fc_mf_nn not null,
cargo varchar(20) constraint fc_cargo_nn not null
)

create table PROJETO(
cod_proj numeric(5) constraint proj_cod_pk primary key,
nome_proj varchar(40) constraint proj_nm_nn not null,
dt_inicio date,
dt_fim date
)

create table ALOCA(
cod_proj numeric(5) references PROJETO,
mat_func numeric(5) references FUNCIONARIO,
data_alocacao date
)

create table COORDENA(
cod_projeto numeric(5) references PROJETO,
mat_coord numeric(5) references FUNCIONARIO,
data_alocacao date
)

create table SUPERVISIONA(
mat_superior numeric(5) references FUNCIONARIO,
mat_func numeric(5) references FUNCIONARIO
)

create table PROJ_TECNICO(
cod_proj numeric(5) references PROJETO,
area_pesquisa varchar(20) constraint pt_area_nn not null)

-------

--1 
	select *from FUNCIONARIO order by matricula

--2 
	select count(matricula) from  FUNCIONARIO

--3 
	select nome_func from FUNCIONARIO where anos_servico between 10 and 12

--4 
	select nome_func, matricula, salario from FUNCIONARIO not between 1000 and 3000

--5 
	select nome_func from FUNCIONARIO where anos_servico in(5,8,13) or anos_servico is null

--6	
	select nome_func from FUNCIONARIO where nome_func like '%_AN%' or nome_func like '%_ON%'

--7 
	select matricula, nome_func, salario from FUNCIONARIO order by nome_func ASC

--8 
	select anos_servico, matricula, nome_func, salario from FUNCIONARIO order by anos_servico DESC, salario DESC

--9 
	select nome_dpto, matricula, nome_func, salario from FUNCIONARIO group by nome_dpto order by  salario DESC

--10 
	select matricula, nome_func, cod_orgao, anos_servico, salario from FUNCIONARIO where anos_servico => 4 or salario > 500

--11 
	select nome_func, matricula from FUNCIONARIO where cod_orgao != 'Gerente'

--12 
	select cod_proj, nome_proj, anos_pesquisa from PROJ_TECNICO  

--17
	select *from PROJETO order by cod_proj ASC 

--19
	select nome_func, matricula, salario from FUNCIONARIO where salario > 1000

--20 
	select matricula, nome_func, anos_servico, salario from FUNCIONARIO where anos_servico > 6 and cod_orgao = 'Gerente' or salario > 3000







-------

INSERT INTO FUNCIONARIO(matricula, nome_func,anos_servico, salario) VALUES(12, 'Pamela', 13, 500)
