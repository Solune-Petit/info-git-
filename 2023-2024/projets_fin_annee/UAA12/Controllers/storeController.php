<?php


require_once("Models/storeModel.php");

$uri = $_SERVER["REQUEST_URI"];


if ($uri == "/magasins"){
    
    $stores = selectAllStores($pdo);
    
    $title = 'nos magasins';
    $template  = 'Views/stores/pageMagasins.php';   
    require_once('Views/base.php');


}elseif ($uri == "/myStore"){

    $stores = selectMyStores($pdo);

    $title = 'mes magasins';
    $template  = 'Views/stores/pageMagasins.php';   
    require_once('Views/base.php');
}elseif (isset($_GET["idstores"]) && $uri == "/crudStore?idstores=" . $_GET["idstores"]){
    $stores = selectOneOfMyStores($pdo);
    $title = 'mes magasins';
    $template  = 'Views/stores/crudStore.php';   
    require_once('Views/base.php');
}elseif ($uri == "/addStore"){
    $title = 'ajouter votre magasin';
    $template  = 'Views/stores/crudStore.php';   
    require_once('Views/base.php');
}