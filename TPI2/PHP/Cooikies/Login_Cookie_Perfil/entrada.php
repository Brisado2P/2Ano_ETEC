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
        $username =$_COOKIE["nome"];
?>
<!doctype html>
<html>
    <head>
        <meta charset="utf-8">
        <title>Entrada</title>
        <link rel="stylesheet" type="text/css" href="CSS/estilo_entra.css">
    </head>
    <body>
        <h1 class="bem">Bem vindo <a href="perfil.php"> <?php echo $username;  ?> </a> ao servidor.</h1>
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