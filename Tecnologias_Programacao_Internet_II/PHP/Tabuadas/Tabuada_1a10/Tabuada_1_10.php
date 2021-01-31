<doctype html>
<html>
	<head>
	<title>Tabuadas</title>
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
	</head>


	<body>
<?php
		$res=0;
		for($f=1; $f<=10; $f++){ 
		?><div class="coluna"><?php
		echo "Tabuado do ", $f;
			for($i=0; $i<=10; $i++){
				$res=$f*$i;
?>

		<p class="cor1"> <?php echo $f; ?>
			<a class="cor2"> <?php echo "X"; ?> </a>
				<a class="cor3"> <?php echo $i; ?> </a>
					<a class="cor2"> <?php echo"="; ?> </a>
						<a class="cor4"> <?php echo $res; ?> </a>
		</p>

<?php
	}
	?></div><?php
		}
?>
	</body>
</html>