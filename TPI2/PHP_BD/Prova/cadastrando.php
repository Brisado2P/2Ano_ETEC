<?php
	
	include "conexao.php";
	
	$nomeClie = $_POST["txtNome"];
	$end = $_POST["txtEnd"];
	$tell_cell = $_POST["txtTell"];
	
	$sqlinsert = mysqli_query($conn, "INSERT INTO cliente (nome, endereco, tell_cell) VALUES ('$nomeClie', '$end', $tell_cell ) ");
	
	$n = mysqli_affected_rows($conn);

	if($n > 0)
	{
		header("location:Index.php");
	}
	else
	{
		echo("<h2>Informação invalida, verifique se o nome e o endereço estão corretos e se o telefone tem até 11 digitos</h2>");
	}
?>
<!DOCTYPE html>
<html>
<head>
	<title>Informação</title>
</head>
<body>

	<a href="cadastro.php">Tentar Novamente</a>

</body>
</html>