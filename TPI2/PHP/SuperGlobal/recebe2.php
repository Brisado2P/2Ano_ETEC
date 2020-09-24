<?php
	session_start();

	$nome = $_SESSION["nome"];
?>
<!DOCTYPE html>
<html>
	<head>
		<title>Resp</title>
	</head>
	<body>
		<p>Olá <?php echo $nome; ?>, seja bem vindo </p> 
		<p><a href="index.php">Voltar</p>
	</body>
</html>