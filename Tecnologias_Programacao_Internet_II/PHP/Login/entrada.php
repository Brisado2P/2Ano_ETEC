<?php
	session_start();
    if ($_SESSION["logado"]) {
     
    
	$user=$_SESSION["nome"];
	$pass=$_SESSION["password"];
?>


<!doctype html>
<html>
    <head>
        <meta charset="utf-8">
        <title>Entrada</title>
        <link rel="stylesheet" type="text/css" href="css/estilo_entra.css">
    </head>
    <body>
        <h1 class="bem">Bem vindo <?php echo $user; ?> ao servidor.</h1>
        <div class="botao">
            <p class="b2"><a href="logout.php" >Deslogar.</a></p>
        </div>
    </body>
</html>
<?php
 }
 else{
      $_SESSION["erro"]= 2;
      header("location:Login.php");

 }
 ?>