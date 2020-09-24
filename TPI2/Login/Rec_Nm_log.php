<?php
	session_start();

	$_SESSION["username"] = $_POST["txtLogin"];

	$_SESSION["password"] = $_POST["txtSenha"];

if ($_SESSION["username"]=="James" && $_SESSION["password"]=="Admin") {
	$_SESSION["logado"]= true;

	$_SESSION["erro"]= 0;

	$_SESSION["nome"]= "James";

	header("location:entrada.php");
}
else{
	$_SESSION["logado"]= false;
	$_SESSION["erro"]= 1;

	header("location:Login.php");
}
?>