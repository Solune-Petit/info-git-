<?php 
    $nombreDepart=5;
    $NombreElementSouhaite=8;
    $nbr1=21;
    $nbr2=15;
    $suite;


        $phrase = "la réussite passe par une étude et un entrainement régulier et sérieux";
        require_once "php/fonctions.php";

?>

<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/index.css">
</head>
<body>
    
    <header>
        <h1>Aprendre les fonctions en PHP</h1>

    </header>


    <main>
        <h1>Testons les apels de fonctions</h1>
        <h3>je veux des belles fonctions php (séparer analyse et affichage dans votre fichier)</h3>
        <h2>première fonction</h2>
        <p>Voici une suite tout à fait farfelue (pour un nombre de départ de 5 et un nombre d'éléments de 8) : <?= fonctionSpeciale($nombreDepart, $NombreElementSouhaite) ?></p>
        <h2>Calcul du PGCD</h2>
        <p>le PGCD entre 21 et 15 vaut <?= algorithmEuclide2($nbr1, $nbr2) ?>
        <h2>Affichez proprement du code</h2>
        <p>On ne crée pas de fonction mais on écrit proprement la boucle php dans l'html</p>
        <p>(On souhaite afficher la dernière lettre de chaque mot dans une liste à puces. On considère que chaque mot est suivi d'un espace sauf le dernier)</p>
        <br>
        <p>Dans la variable $phrase "La réussite passe par une étude et un entraînement régulier et sérieux", la dernière lettre de chaques mot est</p>
        <ul>
        <?php 
            $len = strlen($phrase);
            for ($i = 1; $i < $len; $i++):
            
                if ($phrase[$i] == " "):
                
                    $lettre = $phrase[$i - 1];?>

                    <li><?= $lettre?></li>
                <?php endif; endfor?>
            
            <?php $lettre = $phrase[$len - 1] ?>
            <li><?= $lettre?></li>

        </ul>
    </main>


    <footer>

    </footer>
</body>
</html>