<?php
	$n1 = 1000;
	$n2 = 24;
	$n3 = 39;
	if ($n1 < $n2 && $n1 < $n3)
	{
			if ($n2 < $n3)
			{
				echo $n1 . " ",$n2, "", $n3;
			}
			else
			{
				echo "",$n1, "", $n3, "", $n2;
			}
	}
	else 
		if ($n2 < $n3)
			{
				echo "",$n2,"", $n3,"", $n1;
			}
			else
			{
				echo "",$n3,"", $n2,"", $n1;
			}
?>
	