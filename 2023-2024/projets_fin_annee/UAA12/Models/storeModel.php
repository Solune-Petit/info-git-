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
