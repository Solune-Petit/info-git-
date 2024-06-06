<?php

require_once("Models/storeModel.php");

$uri = $_SERVER["REQUEST_URI"];

if ($uri == "/factory"){
    $title = 'mes magasins';
    $template  = 'Views/factory/factoryPage.php';   
    require_once('Views/base.php');
}