<?php
	session_start();

	$username = $_POST["txtLogin"];

	$password = $_POST["txtSenha"];

if ($username=="James" && $password=="Admin") {
	$_SESSION["logado"]= true;
	$_SESSION["erro"]= 0;

	setcookie('nome', 'James', time()+(3600*24*365));

	if ($_POST['Manter'] == 1) {		
		setcookie('logado', 'true', time()+(3600*24*365));
		header("location:entrada.php");
	}
	else{
		header("location:entrada.php");
	}
}
else{
	$_SESSION["logado"]= false;
	$_SESSION["erro"]= 1;

	header("location:index.php");
}
?>