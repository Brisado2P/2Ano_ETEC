<?php

 $bandas=array("Slipknot","Metallica","5SOS");

$c= count($bandas);

echo "Foram encontradas $c bandas no vetor " . '$bandas <br>';

foreach ($bandas as $x => $x_value) {
		echo "Banda[".$x."]:" . $x_value;
		echo "<br>";
	}

?>