<?php
	
	include "musics.php";
	
	$sqlbanda = mysqli_query($conn, "SELECT * FROM BANDAS order by nome asc");
	
	while ($rs_banda = mysqli_fetch_array($sqlbanda)) {
		echo $rs_banda['id'] ."  ". $rs_banda['nome']."  ".$rs_banda['pais_origem']."  ".$rs_banda['data_origem']. "<br>" ;
		
	}
	
	 
?>