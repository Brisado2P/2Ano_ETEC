<?php
  
    session_start();
    if (!isset($_SESSION["erro"])) {
        $_SESSION["erro"] = 0;
    }
    if(isset($_COOKIE["logado"]))
    {
        
         header("location: entrada.php");
           
    }
    else{
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
    		<input type="text" name="txtLogin" id="txtLogin" value="James" placeholder="Username">
    		<input type="password" name="txtSenha" id="txtSenha" placeholder="Password" value="Admin">
            <input type="submit" name="btnLogin" value="Entrar"> <br>
            <input type="checkbox" id="manter" name="Manter" value="1" >
            <label for="manter">Manter conectado</label> <br>

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
    	</form>
    </body>
    <?php
        }
    ?>
</html>
