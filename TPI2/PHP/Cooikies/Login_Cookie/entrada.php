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
?>
<!doctype html>
<html>
    <head>
        <meta charset="utf-8">
        <title>Entrada</title>
        <link rel="stylesheet" type="text/css" href="css/estilo_entra.css">
    </head>
    <body>
        <h1 class="bem">Bem vindo <?php echo $_COOKIE["nome"]; ?> ao servidor.</h1>
        <div class="botao">
            <p class="b2"><a href="logout.php" >Deslogar.</a></p>
        </div>
    </body>
</html>
<?php
 }
 else{
      $_SESSION["erro"]= 2;
      header("location:index.php");

 }
 ?>