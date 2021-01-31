<?php 
	session_start();


	$_SESSION["logado"] = false;
	$_SESSION["username"] = "";
	$_SESSION["password"] = "";

	session_destroy();
	header("location:Login.php");
?>