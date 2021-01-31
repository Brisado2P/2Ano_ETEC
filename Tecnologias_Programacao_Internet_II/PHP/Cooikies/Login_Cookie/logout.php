<?php 
	session_start();
	session_unset();
	

	unset($_COOKIE["logado"]);

	$_SESSION["logado"] = false;
	$_SESSION["username"] = "";
	$_SESSION["password"] = "";

	setcookie('logado', null, time() -1);
	setcookie('nome', null, time() -1);
	session_destroy();
	header("location:index.php");
?>