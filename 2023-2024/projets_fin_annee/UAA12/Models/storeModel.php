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
