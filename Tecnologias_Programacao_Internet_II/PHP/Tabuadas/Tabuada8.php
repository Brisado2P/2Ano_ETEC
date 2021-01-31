<doctype html>
<html>
	<head>
	<title>Tabuada 8</title>

	<style> .cor1{color:green;} .cor2{color:black;} .cor3{color:yellow;} .cor4{color:blue;}  </style>

	</head>


	<body>
<?php
	$res=0;
	for($i=0; $i<=10; $i++){
		$res=8*$i;
?>
<p class="cor1"> <?php echo "8"; ?>
	<a class="cor2"> <?php echo "X"; ?> </a>
		<a class="cor3"> <?php echo $i; ?> </a>
			<a class="cor4"> <?php echo"="; ?> </a>
				<a class="cor2"> <?php echo $res; ?> </a>
</p>

<?php
	}
	
?>
	</body>
</html>