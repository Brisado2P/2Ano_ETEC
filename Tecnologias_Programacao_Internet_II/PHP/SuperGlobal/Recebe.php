<?php

		session_start();

		$_SESSION["nome"] = $_POST["txtNome"];
		
		header("location:recebe2.php");


?>