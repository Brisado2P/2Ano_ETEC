<?php
	session_start();
    if (isset($_SESSION["logado"])) {
        $SLogin = $_SESSION["logado"];
    }
    else{
        $SLogin = "false";
    }

    if (isset($_COOKIE["logado"])) {
        $CLogin = $_COOKIE["logado"];
    }
    else{
        $CLogin = "false";
    }
   	if(($SLogin == "true") || ($CLogin == "true")){
   		$_SESSION["username"]=$_COOKIE["nome"];
?>
<!DOCTYPE html>
<html>
<head>
	<title>Perfil</title>
	<meta charset="utf-8">
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
</head>
<body>
	<form action="mudanca.php" method="post" class="perfil">
		<label>Deseja Mudar seu nome de usuário? <br> Escreva seu novo nome aqui</label><br>
		<input type="text" name="txtMudarNome" value= "<?php echo $_SESSION["username"];?>">
		<input type="submit" name="btnConcluir" value="Concluir">
	</form>
</body>
</html>
<?php
 }
 else{
      $_SESSION["erro"]= 2;
      header("location:index.php");

 }
 ?>