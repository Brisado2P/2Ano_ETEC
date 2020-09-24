<doctype html>
<html>
	<head>
	<title></title>

	<style> .cor1{color:red;} .cor2{color:blue;} </style>

	</head>
	<body>
<?php
	for($i=0;$i<=30;$i++){
	  if($i%3==0){	
?>
	<p class="cor1"> <?php echo $i; ?> </p>

<?php
	}
	  
	  else{
?>
	  	<p class="cor2"> <?php echo $i; ?> </p>
<?php
	  }
	}
?>
	</body>
</html>