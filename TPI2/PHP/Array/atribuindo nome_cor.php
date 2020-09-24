<?php

$a1=array("a"=>"red","b"=>"green");
$a2=array("c"=>"blue","d"=>"red");

print_r(array_merge_recursive($a1,$a2));

//print_r exibe o conteudo de um array
//array_merge_recursive junta os dois arrays

?>