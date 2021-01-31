<?php  

	include "conexao.php";

	$id = $_GET['id'];

	$sqlcliente = mysqli_query($conn, "DELETE FROM CLIENTE WHERE id = $id");

	header("location:Index.php");

?>