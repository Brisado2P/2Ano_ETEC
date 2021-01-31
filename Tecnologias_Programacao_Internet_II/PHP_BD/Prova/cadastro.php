<?php
	include "conexao.php";
?>

<!doctype html>
	<html>
		<head>
			<title>Formulário</title>

			<meta charset="utf-8">
		</head>
	<body> 
		<h1>Cadastramento</h1>	
			<form action="cadastrando.php" method="POST">

				<label for="lblNome">Nome:</label><br>
				<input type="text" name="txtNome" id="txtNome" placeholder="Seu nome" size = 20 />
				<br><br>
				<label for="lblEnd">Endereço:</label><br>
				<input type="text" name="txtEnd" id="txtEnd" placeholder="Endereço" size = 20 />
				<br><br>
				<label for="lblTell">Telefone ou celular:</label><br>
				<input type="text" name="txtTell" id="txtTell" placeholder="Telefone" size = 20  /> <br>
				<br><br>
				<input type="Submit" value="Enviar" name="btnCadastrar"/>
			</form>

	</body>
</html>

