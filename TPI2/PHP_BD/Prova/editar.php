<?php
	include "conexao.php";

	$id = $_GET['id'];

	$sqlcliente = mysqli_query($conn, "SELECT * FROM CLIENTE WHERE id = $id");
	$rs_cliente = mysqli_fetch_array($sqlcliente);
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
				<input type="text" name="txtNome" id="txtNome" value="<?php echo $rs_cliente['nome']; ?>" placeholder="Seu nome" size = 20 />
				<br><br>
				<label for="lblEnd">Endereço:</label><br>
				<input type="text" name="txtEnd" id="txtEnd" value="<?php echo $rs_cliente['endereco']; ?>" placeholder="Endereço" size = 20 />
				<br><br>
				<label for="lblTell">Telefone ou celular:</label><br>
				<input type="text" name="txtTell" id="txtTell" value="<?php echo $rs_cliente['tell_cell']; ?>" placeholder="Telefone" size = 20  /> <br>
				<br><br>
				<input type="Submit" value="Enviar" name="btnCadastrar"/>
			</form>

	</body>
</html>

