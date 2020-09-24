<?php
	
	include "conexao.php";
	
	$nomebanda = $_POST["txtNome"];
	$pais = $_POST["pais"];
	$dataestreia = $_POST["dtdata"];
	
	$sqlinsert = mysqli_query($conn, "INSERT INTO bandas (nome, pais, data_origem) VALUES ('$nomebanda', $pais, '$dataestreia' ) ");
	
	$n = mysqli_affected_rows($conn);
	
	$dataestreia = explode("-", $dataestreia);
	$ano = $dataestreia[0];
	$mes = $dataestreia[1];
	$dia = $dataestreia[2];
	
	$dataestreia = $dia . "/" . $mes . "/" . $ano;
	
	if($n > 0)
	{
		echo "Banda $nomebanda  Pais de estreia: $pais Data de Estreia: $dataestreia <br> Cadastrada com sucesso <br> ";
		echo "<a href='formulario.php'> Cadastrar Novo </a>";
	}
	else
	{
		echo "Erro ao cadastrar, tente novamente <br>";
		echo "<a href='formulario.php'> Voltar </a>";
	}
	
?>