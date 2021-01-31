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

				$sqlBanda = mysqli_query($conn, "SELECT * FROM bandas inner join pais on id = id_pais order by nome asc");
				$n = mysqli_affected_rows($conn);
				if ( $n > 0) 
				{
					while ($rs_banda = mysqli_fetch_array($sqlBanda))
					{
						echo $rs_banda['nome']." - ".$rs_banda['nm_pais']." - ".$rs_banda['data_origem']. "<br>" ;
						?>
							<a href="editar.php?id=<?php echo $rs_banda['id']; ?>">Editar</a>
							<a href="delete.php?id=<?php echo $rs_banda['id']; ?>">Apagar</a>
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

			$sqlBanda = mysqli_query($conn, "SELECT * FROM bandas inner join pais on id = id_pais order by id DESC limit 1");
					while ($rs_banda = mysqli_fetch_array($sqlBanda))
					{
						echo $rs_banda['nome']." - ".$rs_banda['nm_pais']." - ".$rs_banda['data_origem']. "<br>" ;					
					}
			?>

		</fieldset>
		<br><br>
		<a href="formulario.php">Cadastrar Novo Cliente</a>

</body>
</html>
