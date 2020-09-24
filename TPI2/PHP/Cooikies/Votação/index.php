<!DOCTYPE html>
<html>
<head>
	<title>Cookies</title>
</head>
<body>
<?php
	if(($_SERVER["REQUEST_METHOD"]=="POST") || (isset($_COOKIE["voto"])))
	{
			if(!isset($_COOKIE["voto"]))
			{
				setcookie('voto','true',(time()+(2*24*3600)));
				$voto = $_POST["musica"];
				echo "Você votou em: $voto <br>";
				echo"Obrigado pelo seu voto" ;
			}
			else
			{
				echo "Você não pode votar mais de uma vez!";
			}
	}
	else{
?>
<form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
	Vote no seu estilo de musica preferido:<br>
	<br>
	<input type="radio" name="musica" value="Forro" />
	<label>Forro</label>
	<br>
	<input type="radio" name="musica" value="Lambada"/>
	<label>Lambada</label>
	<br>
	<input type="radio" name="musica" value="Pagode"/>
	<label>Pagode</label>
	<br>
	<input type="radio" name="musica" value="Rock"/>
	<label>Rock</label>
	<br>
	<input type="radio" name="musica" value="Sertanejo"/>
	<label>Sertanejo</label>
	<br>
	<input type="radio" name="musica" value="Samba"/>
	<label>Samba</label>
	<br><br>
	<input type="submit" value="Votar">
	</form>
</body>
<?php
}
?>
</html>