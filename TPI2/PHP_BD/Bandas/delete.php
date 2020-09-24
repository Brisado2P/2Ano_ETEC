<?php  

	include "conexao.php";

	$id = $_GET['id'];

	$sqlBanda = mysqli_query($conn, "DELETE FROM bandas WHERE id = $id");

	header("location:index.php");

?>