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
    
    $idStore = $_GET["idstores"];

    if (isset($_POST['btnEnvoiAjoutProduits']))
    {
        createProduct($pdo);
        header('location:/crudStore?idstores=' . $_GET["idstores"]);

    }
    if (isset($_POST['btnEnvoiModifProduits']))
    {
        updateProduct($pdo);
        header('location:/crudStore?idstores=' . $_GET["idstores"]);

    }
    if (isset($_POST['btnEnvoiDelProduits'])){
        delProduct($pdo, $idStore);
        var_dump("coucou");
    }
    
    
    $stores = selectOneOfMyStores($pdo);
    $products = sellectMyProducts($pdo);
    $title = 'mon magasins';
    $template  = 'Views/stores/crudStore.php';   
    require_once('Views/base.php');




}elseif ($uri == "/addStore"){
    $title = 'ajouter votre magasin';
    $template  = 'Views/stores/crudStore.php';   
    require_once('Views/base.php');

}elseif (isset($_GET["idstores"]) && $uri == "/delProduct?idstores=" . $_GET["idstores"]){
    delProduct($pdo, $_GET["idstores"]);
    header("/");
}elseif ($uri == "/deleteStore"){
    delStore($pdo);
}