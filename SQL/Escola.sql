create table Aluno (
RA numeric(7) constraint al_ra_pk primary key, 
nm_aluno char(100) constraint al_nm_nn not null, 
end_aluno varchar(150) constraint al_end_nn not null, 
cidade char(50) constraint al_cid_nn not null
)



create table Disciplina (
COD_DISC char(5) constraint disc_cod_pk primary key , 
nm_disc char(50) constraint disc_nm_nn not null, 
carga_hor numeric(6) constraint disc_carg_nn not null
)



create table Professor (
COD_PROF numeric(7) constraint prof_cod_pk primary key ,
nm_prof char(100) constraint prof_nm_nn not null, 
end_prof varchar(150) constraint prof_end_nn not null , 
cidade char(50) constraint prof_cid_nn not null
)



create table Turma (
cod_disc char(5) references Disciplina ,
COD_TURMA numeric(5) constraint tur_cod_pk primary key, 
cod_prof numeric(7) references Professor, 
Ano varchar(4) constraint tur_ano_nn not null, 
horario char(15) constraint tur_hor_nn not null
)



create table Historico (
RA numeric(7) references Aluno,
COD_DISC char(5) references Disciplina, 
COD_TURMA numeric(5) references Turma, 
COD_PROF numeric(7) references Professor, 
ano numeric(4) constraint hist_ano_nn not null, 
freq_aluno numeric(3) constraint hist_freq_nn not null, 
nota numeric(2) constraint hist_nota_nn not null
)


insert into Aluno(RA,nm_aluno, end_aluno,cidade) values(0023876, 'Victor', 'Rua Pamela Brandão 120', 'São Paulo')
insert into Aluno(RA,nm_aluno, end_aluno,cidade) values(0024876, 'James', 'Rua Laiza Goimes 90', 'São Miguel')
insert into Aluno(RA,nm_aluno, end_aluno,cidade) values(0025876, 'Heloisa', 'Rua Pedro Alvarez 60', 'Guarulhos')
insert into Aluno(RA,nm_aluno, end_aluno,cidade) values(0026876, 'Jessie', 'Rua Manuel da Nobrega 11', 'São Paulo')
insert into Aluno(RA,nm_aluno, end_aluno,cidade) values(0027876, 'Miau', 'Av. Guilherme 720', 'São Paulo')
insert into Aluno(RA,nm_aluno, end_aluno,cidade) values(0028876, 'Kuka', 'Av. Guilherme 20', 'São Paulo')
insert into Aluno(RA,nm_aluno, end_aluno,cidade) values(0029876, 'Alex', 'Av.porta 20', 'Campinas')

insert into Disciplina(COD_DISC,nm_disc, carga_hor) values('Mat', 'Matematica', 5)
insert into Disciplina(COD_DISC,nm_disc, carga_hor) values('Ing', 'Ingles', 2)
insert into Disciplina(COD_DISC,nm_disc, carga_hor) values('Geo', 'Geografia', 3)
insert into Disciplina(COD_DISC,nm_disc, carga_hor) values('BD', 'TLBD', 24)
insert into Disciplina(COD_DISC,nm_disc, carga_hor) values('GSO', 'GSO', 8)

insert into Professor(COD_PROF,nm_prof, end_prof, cidade) values(1, 'Helson', 'Rua Pamela 123', 'São Paulo')
insert into Professor(COD_PROF,nm_prof, end_prof, cidade) values(2, 'Marcel', 'Rua Manuel da Nobrega 17', 'São Paulo')
insert into Professor(COD_PROF,nm_prof, end_prof, cidade) values(3, 'Marco', 'Rua Pedro Alvarez 69', 'Guarulhos')
insert into Professor(COD_PROF,nm_prof, end_prof, cidade) values(4, 'Breno', 'Rua Manuel da Nobrega 11', 'São Paulo')
insert into Professor(COD_PROF,nm_prof, end_prof, cidade) values(5, 'Carlos', 'Rua Laiza Goimes 70', 'São Miguel')
insert into Professor(COD_PROF,nm_prof, end_prof, cidade) values(6, 'José', 'Rua Laiza Goimes 50', 'Campinas')

insert into Turma(cod_disc, COD_TURMA, cod_prof, Ano, horario) values('Mat', 1, 4, '2 A', 'Tarde')
insert into Turma(cod_disc, COD_TURMA, cod_prof, Ano, horario) values('Ing', 2, 1, '3 A', 'Noite')
insert into Turma(cod_disc, COD_TURMA, cod_prof, Ano, horario) values('Geo', 3, 5, '2 B', 'Manhã')
insert into Turma(cod_disc, COD_TURMA, cod_prof, Ano, horario) values('BD', 4, 2, '1 A', 'Tarde')
insert into Turma(cod_disc, COD_TURMA, cod_prof, Ano, horario) values('GSO', 5, 3, '1 B', 'Noite')

insert into Historico(RA, COD_DISC, COD_TURMA, COD_PROF, ano, freq_aluno, nota) values(0023876, 'Mat', 1, 4, 2010, 80, 5)
insert into Historico(RA, COD_DISC, COD_TURMA, COD_PROF, ano, freq_aluno, nota) values(0024876, 'Ing', 2, 1, 2009 , 65, 3)
insert into Historico(RA, COD_DISC, COD_TURMA, COD_PROF, ano, freq_aluno, nota) values(0025876, 'Geo', 3, 5, 2011 , 100, 10)
insert into Historico(RA, COD_DISC, COD_TURMA, COD_PROF, ano, freq_aluno, nota) values(0026876, 'BD', 4, 2, 2010 , 90, 9)
insert into Historico(RA, COD_DISC, COD_TURMA, COD_PROF, ano, freq_aluno, nota) values(0027876, 'GSO', 5, 3, 2009 , 10, 1)
insert into Historico(RA, COD_DISC, COD_TURMA, COD_PROF, ano, freq_aluno, nota) values(0028876, 'GSO', 5, 6, 2009 , 10, 2)
insert into Historico(RA, COD_DISC, COD_TURMA, COD_PROF, ano, freq_aluno, nota) values(0028876, 'GSO', 5, 3, 2010 , 10, 2)
insert into Historico(RA, COD_DISC, COD_TURMA, COD_PROF, ano, freq_aluno, nota) values(0029876, 'Mat', 1, 6, 2010 , 8, 2)

select* from Aluno
select* from Disciplina
select* from Professor
select* from Turma
select* from Historico


--1. Encontre o RA dos alunos com nota em BD em 2010 menor que 5 (obs: BD = código da disciplinas).

	select a.RA, h.nota from Aluno a 
	inner join Historico h on a.RA = h.RA where COD_DISC = 'BD' and nota < 5  and ano = 2010

--2. Forneça o RA, nome e nota dos alunos com nota menor que 5 em BD em 2010.
	 
	 select a.RA, a.nm_aluno, h.nota from Aluno a 
	 inner join Historico h on a.RA = h.RA where COD_DISC = 'BD' and nota < 5 and ano = 2010

--3. Forneça o nome dos professores de BD em 2010.

	SELECT p.nm_prof, h.COD_DISC, h.ano from Professor p 
	inner join Historico h on  p.COD_PROF = h.COD_PROF where COD_DISC = 'BD' and ano = 2010 

--4. Encontre o nome, endereço, cidade dos alunos e código das disciplinas onde os alunos tiveram nota menor que 5 em 2010.

	SELECT a.nm_aluno, a.end_aluno, a.cidade, h.COD_DISC from Aluno a 
	inner join Historico h on a.RA = h.RA where nota < 5 and ano = 2010

--5. Obtenha o nome e RA dos alunos do professor em 2010.
	
	SELECT a.nm_aluno, a.RA, h.COD_PROF, p.nm_prof from Aluno a 
	inner join Historico h on a.RA = h.RA 
	inner join Professor p on h.COD_PROF = p.COD_PROF  where ano = 2010 

--6. Localize o nome e RA dos alunos do professor JOSÉ em 2010 ou 2009 que tiveram aulas com o professor MARCOS em algum ano.
	
	SELECT a.nm_aluno, a.RA, h.COD_PROF, p.nm_prof from Aluno a 
	inner join Historico h on a.RA = h.RA 
	inner join Professor p on h.COD_PROF = p.COD_PROF  where (ano = 2010 or ano = 2009) and (nm_prof = 'José' and nm_prof = 'Marcos')

--7. Forneça o histórico escolar do aluno de nome Alex, ou seja, seu RA, nome, a lista de disciplinas que ele já cursou contendo o 
--- código e nome da disciplina, freqüência e nota e ano que o aluno a cursou.

	SELECT a.RA, a.nm_aluno, h.COD_DISC, d.nm_disc, h.freq_aluno, h.nota, h.ano from Aluno a 
	inner join Historico h on a.RA = h.RA 
	inner join Disciplina d on h.COD_DISC = d.COD_DISC where a.nm_aluno = 'Alex'

--8. Encontre o nome e endereço dos alunos e professores de Campinas.

	select a.nm_aluno, a.end_aluno, p.nm_prof, p.end_prof  from Aluno a 
	inner join Professor p on a.cidade = p.cidade where p.cidade = 'Campinas' 

--9. Forneça o nome dos alunos que cursaram disciplinas com carga horária menor que 60 horas, bem como os respectivos professores que as lecionaram.

	select a.nm_aluno, d.nm_disc, d.carga_hor, p.nm_prof from Aluno a 
	inner join Historico h on a.RA = h.RA
	inner join Disciplina d on h.COD_DISC = d.COD_DISC 
	inner join Professor p on h.COD_PROF = p.COD_PROF where d.carga_hor = 60

--10. Localize o nome dos professores que lecionaram matérias nas quais o aluno “Pedro Paulo Cunha” foi reprovado. (nota < 5)

	select p.nm_prof, a.nm_aluno, h.nota from Historico h 
	inner join Aluno a on a.RA = h.RA 
	inner join Professor p on p.COD_PROF = h.COD_PROF where nm_aluno = 'Pedro Paulo Cunha' and nota < 5
 
--11. Encontre o RA dos alunos que já cursaram todas as disciplinas lecionadas pelo prof.João.

	select a.RA, nm_aluno, nm_prof, h.COD_DISC from Aluno a
	inner join Historico h on a.RA = h.RA
	inner join Professor p on h.COD_PROF = p.COD_PROF 
	where nm_prof = 'João'

--12. Encontre o Ra, nome e média das notas dos alunos que cursaram todas as matérias lecionadas por professores de Campinas.

	select a.RA, AVG(h.nota) as 'Media' from Historico h 
	inner join Aluno a  on a.RA = h.RA 
	inner join Professor p on p.COD_PROF = h.COD_PROF
	WHERE p.cidade = 'Campinas' group by (a.RA) 

--13. Localize o RA e nome dos alunos com nota menor que qualquer uma das notas do aluno de RA 20090121.
	
	select a.RA, nm_aluno from Aluno a 
	inner join Historico h on a.RA = h.RA 
	where (h.nota) < (select nota from Historico where RA = 20090121 )

