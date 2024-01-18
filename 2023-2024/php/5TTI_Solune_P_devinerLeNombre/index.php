<?php
    $message = "";
    require_once "functions/functions.php";
    if (isset($_GET["numberToGuess"]))
    {
        $value = $_GET["numberToGuess"];
        $gagne = DevinerNombre($value, $message);
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <header>
        <h1>JOUEZ AVEC NOUS !!!!</h1>
    </header>
    <main>
        <div class="bigbox">
            <h2>DEVINEZ UN NOMBRE</h2>
            <form action="index.php" method="get">
                <div class="smallbox">
                    <input type="text" id="numberToGuess" name="numberToGuess">
                </div>
                <div class="sendbox">
                    <input type="submit" id="submit" name="value">
                </div>

            </form>
            <p><?= $message?></p>
        </div>
    </main>
    <footer>
        <p>premier exercice GET 5TI 2023</p>
    </footer>
</body>
</html>