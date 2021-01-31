 --Victor e Pamela 2AI

--1.    Listar nome e sobrenome ordenado por sobrenome.

		select PrimeiroNome, SegundoNome from Funcionario order by SegundoNome ASC 

--2.    Listar todos os campos de funcion�rios ordenados por cidade.

		select * from Funcionario order by Cidade ASC 

--3.    Liste os funcion�rios que t�m sal�rio superior a R$ 1.000,00 ordenados pelo nome completo.

		select * from Funcionario where Salario > 1000 order by PrimeiroNome,SegundoNome,UltimoNome ASC

--4.    Liste a data de nascimento e o primeiro nome dos funcion�rios ordenados do mais novo para o mais velho.

		select DataNasci, PrimeiroNome from Funcionario order by DataNasci ASC

--5.    Liste os funcion�rios como uma listagem telef�nica.

		select PrimeiroNome, SegundoNome, UltimoNome, Fone from Funcionario where Fone != null  order by PrimeiroNome,SegundoNome,UltimoNome ASC 

--6.    Liste o total da folha de pagamento.

		select sum(Salario) from Funcionario

--7.    Liste o nome, o nome do departamento e a fun��o de todos os funcion�rios.

		select f.PrimeiroNome, f.SegundoNome, d.Nome, f.Funcao  from Funcionario f 
		left join Departamento d on d.Codigo = f.CodigoDepartamento

--8.    Liste todos departamentos com seus respectivos gerentes.

		select d.Nome, f.PrimeiroNome, SegundoNome from Departamento d 
		left join Funcionario f on d.Codigo = f.CodigoDepartamento where f.Funcao = 'Gerente'

--9.    Liste o valor da folha de pagamento de cada departamento (nome).

		select sum(Salario) from Funcionario

--10.   Liste os departamentos dos funcion�rios que t�m a fun��o de supervisor.

		select d.Nome, f.PrimeiroNome, f.SegundoNome from Departamento d 
		inner join Funcionario f on d.Codigo = f.CodigoDepartamento where f.Funcao = 'Supervisor'

--11.   Liste a quantidade de funcion�rios desta empresa.

	 select count(Codigo) from Funcionario

--12.   Liste o sal�rio m�dio pago pela empresa.

	select AVG(Salario) from Funcionario

--13.   Liste o menor sal�rio pago pela empresa em cada departamento.

		select MIN(Salario) from Funcionario

--14.   Liste o nome completo de todos os funcion�rios que n�o tenham segundo nome.

		select PrimeiroNome, UltimoNome from Funcionario where SegundoNome = null

--15.   Liste o nome do departamento e do funcion�rio ordenados por departamento e funcion�rio.

		select d.Nome, f.PrimeiroNome from Departamento d 
		inner join Funcionario f on d.Codigo = f.CodigoDepartamento order by d.Nome, f.PrimeiroNome

--16.   Liste os nomes dos funcion�rios que moram em Recife e que exer�am a fun��o de Telefonista.

		select PrimeiroNome, Cidade, Funcao from Funcionario where Funcao = 'Telefonista' and Cidade = 'Recife'

--17.   Liste os nomes dos funcion�rios que trabalham no departamento Pessoal.

		select PrimeiroNome, SegundoNome, UltimoNome, d.Nome from Funcionario f 
		inner join Departamento d on f.CodigoDepartamento = d.Codigo where d.Nome = 'Pessoal'

--18.   Liste o nome e o departamento de todos os funcion�rios que ganham mais do que algum gerente.

	
