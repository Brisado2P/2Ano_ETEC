<?php
	include "conexao.php";
	$sqlpais = mysqli_query($conn, "SELECT * FROM pais order by nm_pais");
?>

<!doctype html>
	<html>

		<head>
			<title>Formulário</title>
			<link rel="stylesheet" type="text/css" href="CSS/estilo.css"/>
			<meta charset="utf-8">
		</head>

	<body> 
		<h1>Formulário</h1>	
			<form action="cadastrando.php" method="post">

				<label for="txtNome">Nome:</label><br>
				<input type="text" name="txtNome" id="txtNome" placeholder="Nome da banda" size = 20 />
				<br><br>
				<label for="txtPais">País:</label><br>
				<select name="pais">
					<option value="0" selected="selected">Selecione um pais </option>
					<?php 
						while ($rs_pais = mysqli_fetch_array($sqlpais)) {
						
					?>
					<option value="<?php echo $rs_pais["id_pais"]; ?>">
					<?php echo $rs_pais["nm_pais"]; ?></option>

					<?php } ?>
				</select>
				<br><br>
				<label for="txtData">Data:</label><br>
				<input type="date" min = "1950-01-01" max = <?php echo date('Y-m-d');?> name="dtdata" id="dtdata" /> <br>
				<br><br>
				<input type="Submit" value="Enviar" name="btnCadastrar"/>

			</form>

	</body>
</html>
	

