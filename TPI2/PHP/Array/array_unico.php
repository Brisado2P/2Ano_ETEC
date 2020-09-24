<?php

	$bandas=array("Slipknot","Metallica","5SOS","5SOS","Test","Test");
	//array é opcional colocar

	$result=array_unique($bandas);

	foreach ($result as $x => $x_value) {
		echo "Banda[".$x."]:" . $x_value;
		echo "<br>";
	}
	//$x_value é o valor exibido ex: slipknot
	//$x é o numero da banda(array) 
	//php.net

?>