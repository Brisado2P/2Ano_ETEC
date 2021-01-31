<?php 
	$servidor = "localhost";
	$usuario = "root";
	$senha = "";
	$banco = "teste01";


	$conn = mysqli_connect($servidor, $usuario, $senha, $banco) or die("ERRO!!!");

	/*if($conn) {

		echo "Conexao efetuada com sucesso <br/>";

	}

	else {

		echo "Erro de Conexao";

	}*/
?>
