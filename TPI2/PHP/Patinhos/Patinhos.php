<doctype html>
<html>
	<head>
	<title>Patinhos</title>
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
	</head>
	<body>
<?php
		
		for($f=5; $f>=2; $f--){ 
			$i=$f-1;
			$msg1=$f>1?"patinhos foram":"patinho foi";
			$msg2=$i>1?"voltaram":"voltou";
			echo "$f $msg1 passear</br> 
					além da montanha para brincar</br>
					a mamãe gritou</br>
					quá quá quá quá</br>
					mas só $i $msg2 de lá</br></br>";
			}
			echo "1 patinho foi passear</br> 
					além da montanha para brincar</br>
					a mamãe gritou</br>
					quá quá quá quá</br>
					mas nenhum patinho voltou de lá</br></br>";
		
?>
	</body>
</html>