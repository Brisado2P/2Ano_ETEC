Create table curso(
cd_curso numeric(4) constraint cs_cd_pk primary key,
nm_curso varchar(3) constraint cs_nm_NN not null,
preco char(3))

create table aluno(
cd_alu varchar(3),
nm_alu varchar(3),
dt_nasc date,
sx_alu char(1))

sp_help aluno

EDITAR COLUNA(TIPO OU REGRA)

alter table curso
alter column nm_curso varchar(50)

alter table curso
alter column preco numeric(10,2)

alter table aluno
alter column cd_alu numeric(4)

alter table aluno
alter column cd_alu numeric(4) not null 

ADICIONAR CONSTRAINT

alter table aluno
add constraint alu_cd_pk primary key(cd_alu)

ADICIONAR NOVA COLUNA

alter table aluno
add est_civil varchar(30)  

APAGAR COLUNA

alter table aluno
drop column est_civil

APAGAR CHAVE PRIMARIA

alter table aluno
drop constraint  alu_cd_pk 

APAGAR TABELA

drop table aluno

drop table curso