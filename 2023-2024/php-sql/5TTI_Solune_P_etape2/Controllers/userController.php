<?php 

require_once("Models/userModel.php");

$uri = $_SERVER["REQUEST_URI"];

if ($uri == "/inscriptionOrEditProfil")
{
    if(isset($_POST['btnEnvoi'])){
        //ajout de l'utilisateur à la base de données
        createUser($pdo);
        //redirection vers la page de connextion
        header('location:/connexion');
    }
    
    $title = "inscription";
    $template = "Views/Users/inscriptionOrEditProfil.php";
    require_once("Views/base.php");
}else if ($uri == "/connexion")
{
    if(isset($_POST['btnEnvoi'])){
        //ajout de l'utilisateur à la base de données
        if (connectUser($pdo))
        {
            header('location:/index.php');
        }
    }
    
    $title = "connexion";
    $template = "Views/Users/connexion.php";
    require_once("Views/base.php");
}else if ($uri == "/deconnexion")
{
    session_destroy();
    header("location:/");
}else if ($uri == "/updateProfile")
{
    if(isset($_POST['btnEnvoi'])){
            updateUser($pdo);
            updateSession($pdo);
            header('location:/updateProfile');
    }

    $title = "inscription";
    $template = "Views/Users/inscriptionOrEditProfil.php";
    require_once("Views/base.php");
}

function verifEmptyData()
{
    //parcours du tableau $_POST en recherchant les éléments vides ou munis d'espaces
    foreach ($_POST as $key => $value) {
        //str-replace rempkace une chaine par une autre dans un chaine de caractères donnée, ici un espace par le vide dans $value
        if (empty(str_replace(' ','', $value))){
            //on rempli un tableau associatif $messageError dont les clés sont les noms des champs avec un massage rappelant que le champ concerné est vide
            $messageError[$key] = "votre " . $key . " est vide";
        }
    }
    //si le tablea $messageError est vide, on reverra false, sinon, on renvoie le tableau
    if (isset($messageError)) {
        return $messageError;
    }else {
        return false;
    }
}