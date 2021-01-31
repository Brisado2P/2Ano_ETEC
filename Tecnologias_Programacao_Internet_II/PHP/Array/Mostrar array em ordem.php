<?php

	$bandas=array("Slipknot","Metallica","5SOS","Test");
	//array é opcional colocar

	sort($bandas); //Coloca em Ordem alfabetica crescente

	//arsort($bandas) Coloca em ordem alfabetica decrescente
	//asort/ 

	foreach ($bandas as $x => $x_value) {
		echo "Banda[".$x."]:" . $x_value;
		echo "<br>";
	}
	//$x_value é o valor exibido ex: slipknot
	//$x é o numero da banda(array) 

?>