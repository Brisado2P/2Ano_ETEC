<!doctype html>
<html>
	<head>
		<title>PHP</title>
		<style>
			p{ color: red; text-align: center; font-size: 80px;}
			h3{ color: green; text-align: center; font-size: 40px;}
			img{margin-left: 650px;}
		</style>
	</head>
	<body>
	<?php
		$n1 = 70;		
		if($n1 > 70){
	?>
			<p>MULTADO</p>
			<img src=img/images.jpg>
			
	<?php		
		}
		else{
	?>
			<h3>Não foi multado</h3>
			<img src=img/certo.gif>
	<?php
		}
	?>
	
	</body>
</html>

