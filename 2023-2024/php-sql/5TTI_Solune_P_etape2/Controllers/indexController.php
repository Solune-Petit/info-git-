<?php // code php qui décide de ce qu'il faut donner comme valeur à la variable Stemplate
//appel aux controller
require_once("Models/schoolModel.php");
// on ajoutera par la suite les require aux modeles

// récupération du chemin désiré
$uri = $_SERVER["REQUEST_URI"];
if ($uri == "/index.php" || $uri === "/") {
    // récupérer toutes les données de la table school
    $schools = selectAllSchools($pdo);

    $title = "Page d'accueil";              //titre à afficher dans l'onglet de la page du navigateur
    $template = "Views/pageAccueil.php";    //chemin vers la vue demandée
    require_once("Views/base.php");         //appel de la page de base qui sera remplie avec la vue demandée


}