<?php
/*
Fonction selectAllSchools
BUT : aller rechercher les caractéristiques de toutes les écoles dans la base de données
IN : $pdo reprenant toutes les informations de connexion
OUT : objet pdo contenant toutes les écoles de la base de données
*/
function selectAllSchools($pdo)
{
    try {
        //définition de la requête
        $query = "select * from school";
        //préparation de l'exécution de la requête
        $selectSchool = $pdo->prepare($query);
        //exécution
        $selectSchool->execute();
        //récupération des données dans l'objet fetch
        $schools = $selectSchool->fetchAll();
        //renvoi des données
        return $schools;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}