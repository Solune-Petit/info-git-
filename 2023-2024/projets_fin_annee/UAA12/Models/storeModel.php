<?php

function selectAllStores($pdo)
{
    try {
        //définition de la requête
        $query = "SELECT * from stores";
        //préparation de l'exécution de la requête
        $selectStores = $pdo->prepare($query);
        //exécution
        $selectStores->execute();
        //récupération des données dans l'objet fetch
        $stores = $selectStores->fetchAll();
        //renvoi des données
        return $stores;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function selectMyStores($pdo)
{
    try {
        //définition de la requête
        $query = "SELECT * from stores where userId = :userId";
        //préparation de l'exécution de la requête
        $selectStores = $pdo->prepare($query);
        //exécution
        $selectStores->execute([
            "userId" => $_SESSION["user"]->id
        ]);
        //récupération des données dans l'objet fetch
        $stores = $selectStores->fetchAll();
        //renvoi des données
        return $stores;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function selectOneOfMyStores($pdo)
{

    try {
        $query = "SELECT * from stores where idstores = :idstores";
        $selectStores = $pdo->prepare($query);
        $selectStores->execute([
            "idstores" => $_GET["idstores"]
        ]);
        $stores = $selectStores->fetch();
        return $stores;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function sellectMyProducts($pdo)
{
    try {
        $query = "SELECT * from products where magasinId = :idstores";
        $selectProduct = $pdo->prepare($query);
        $selectProduct->execute([
            "idstores" => $_GET["idstores"]
        ]);
        $product = $selectProduct->fetchAll();
        return $product;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function delProduct($pdo, $idStore)
{
    var_dump($idStore);
    
    try {
        $query = 'DELETE from products WHERE idproducts = :idproducts';
        $delUser = $pdo->prepare($query);
        $delUser->execute([
            'idproducts' => $idStore,
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function createProduct($pdo)
{
    try {
        //définition de la requête d'insertion en utilisant la notion de paramètre
        $query = 'insert into products (productsNoms, magasinId, productsQuantity)
        values (:productsName, :idstores, :productsQuantity)';
        //préparation de la requête
        $ajouteUser = $pdo->prepare($query);
        //exécution en attribuant les valeurs récupérées dans le formulaire aux paramètres
        $ajouteUser->execute([
            'productsName' => $_POST["productsName"],
            'idstores' => $_GET["idstores"],
            'productsQuantity' => $_POST["productsQuantity"],
        ]);
    } catch (PDOEXCEPTION $e) {
        $message = $e->getMessage();
        die($message);
    }
}
function updateProduct($pdo)
{
    try {
            $query = 'UPDATE products SET productsNoms = :productsName, productsQuantity = :productsQuantity WHERE idproducts = :idproducts';
            $modifProduct = $pdo->prepare($query);
            $modifProduct->execute([
                'productsName' => $_POST["productsName"],
                'productsQuantity' => $_POST["productsQuantity"],
                'idproducts' => $_GET["idproducts"],
            ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
    
}

function delStore($pdo){
    
    
    
    try {
        $query = 'delete from stores where idstores = :idstores';
        $delUser = $pdo->prepare($query);
        $delUser->execute([
            'idstores' =>$_GET["idstores"]
        ]);
    }catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}