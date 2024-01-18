<?php



    $uri = $_SERVER['REQUEST_URI'];

    if ($uri === "/index.php"){


        $title = "Accueil";
        $template = "Views/pageAcceuil.php";
        require_once("views/base.php");
    }