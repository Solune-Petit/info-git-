<?php
require_once "fonctions/functions.php";
if (isset($_GET["age"]) && isset($_GET["tempsPermis"]) && isset($_GET["anciennete"]) && isset($_GET["accidents"])) {
    $age = (int)$_GET["age"];
    $tempsPermis = (int)$_GET["tempsPermis"];
    $anciennete = (int)$_GET["anciennete"];
    $accidents = (int)$_GET["accidents"];
    $contrat = CalculeContrat($age, $tempsPermis, $anciennete, $accidents);
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

    <head>
        <h1>Quel contract peux vous être assigner</h1>
    </head>

    <main>
        <p>mettez vos informations pour que nous puissions déterminer votre contract</p>
        <div class="bigBox1">
            <div class="bigBox2">
                <form action="index.php" method="GET">
                    <legend>vos données</legend>
                    <div class="smallBox">
                        <label for="age">votre âge (min 18 ans)</label>
                        <input type="number" id="age" name="age" min=18 required>
                    </div>
                    <div class="smallBox">
                        <label for="tempsPermis">Depuis combiens de temps avez-vous votre permis</label>
                        <input type="number" id="tempsPermis" name="tempsPermis" required>
                    </div>
                    <div class="smallBox">
                        <label for="anciennete">depuis combiens de temps êtes-vous dans cette assurance</label>
                        <input type="number" id="anciennete" name="anciennete" required>
                    </div>
                    <div class="smallBox">
                        <label for="accidents">nombres d'accidents</label>
                        <input type="number" id="accidents" name="accidents" required>
                    </div>
                    <input type="submit" id="submit" name="submit">
                </form>
            </div>
        </div>
    </main>

    <footer>
        <?php
        if (isset($_GET["age"]) && isset($_GET["tempsPermis"]) && isset($_GET["anciennete"]) && isset($_GET["accidents"])) {
            echo $contrat;
        }
        ?>
    </footer>

</body>

</html>