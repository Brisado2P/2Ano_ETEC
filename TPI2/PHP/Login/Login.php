<?php
  
    session_start();
    if (!isset($_SESSION["erro"])) {
        $_SESSION["erro"] = 0;
    }
?>

<!doctype html>
<html>
    <head>
        <meta charset="utf-8">
        <title>Login</title>
        <link rel="stylesheet" type="text/css" href="css/estilo.css">
    </head>
    <body>
    	<form action="Rec_Nm_log.php" method="post" class="box">
    		<h1>Login</h1>
    		<input type="text" name="txtLogin" id="txtLogin" placeholder="Username">
    		<input type="password" name="txtSenha" id="txtSenha" placeholder="Password">
    		<input type="submit" name="btnLogin" value="Entrar">
            <?php
              $_POST["txtLogin"]="James";
              $_POST["txtSenha"]="Admin";
                if ($_SESSION["erro"]== 1) {
                    echo "Usuario e/ou senha incorreto";
                }
                else{
                     if ($_SESSION["erro"]== 2) {
                     echo "Pagina restrita, por favor efetue login.";
                    }
                }
            ?>
    	</form>
    </body>
</html>
