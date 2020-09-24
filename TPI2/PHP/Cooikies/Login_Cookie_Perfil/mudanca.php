<?php
	session_start();
	unset($_COOKIE["nome"]);

	$username=$_POST["txtMudarNome"];
	setcookie('nome',$username, time()+(3600*24*365));

	header("location:entrada.php");
	
?>