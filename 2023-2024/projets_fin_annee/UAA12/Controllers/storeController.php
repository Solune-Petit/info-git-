<?php


require_once("Models/storeModel.php");

$uri = $_SERVER["REQUEST_URI"];


if ($uri == "/magasins"){
    
    $stores = selectAllStores($pdo);
    
    $title = 'nos magasins';
    $template  = 'Views/stores/pageMagasins.php';   
    require_once('Views/base.php');
}