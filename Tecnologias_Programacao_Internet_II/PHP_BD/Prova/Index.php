<?php  

	include "conexao.php";
?>
<!DOCTYPE html>
<html>
<head>
	<title> Registros </title>
</head>
<body>
		<h1>Registros encontrados.<br></h1>
		<fieldset>
		<?php	

				$sqlcliente = mysqli_query($conn, "SELECT * FROM CLIENTE order by nome asc");
				$n = mysqli_affected_rows($conn);
				if ( $n > 0) 
				{
					while ($rs_cliente = mysqli_fetch_array($sqlcliente))
					{
						echo $rs_cliente['nome']." - ".$rs_cliente['endereco']." - ".$rs_cliente['tell_cell']. "<br>" ;
						?>
							<a href="editar.php?id=<?php echo $rs_cliente['id']; ?>">Editar</a>
							<a href="delete.php?id=<?php echo $rs_cliente['id']; ?>">Apagar</a>
							<br>
						<?php
					}		
				}
				else
				{
					echo "<h3>Sem Registros</h3>";
				}

		?>	
		</fieldset>

		<h2>Ultimo registro cadastrado</h2>
		<fieldset>
			<?php

			$sqlcliente = mysqli_query($conn, "SELECT * FROM CLIENTE order by id DESC limit 1");
					while ($rs_cliente = mysqli_fetch_array($sqlcliente))
					{
						echo $rs_cliente['nome']." - ".$rs_cliente['endereco']." - ".$rs_cliente['tell_cell']. "<br>" ;					
					}
			?>

		</fieldset>
		<br><br>
		<a href="cadastro.php">Cadastrar Novo Cliente</a>

</body>
</html>
