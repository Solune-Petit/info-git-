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

function deleteOptionsSchoolsFromUser($dbh)
{
    try{
        $query = 'DELETE from option_ecole where schoolId in (select schoolId from school where utilisateurId = :utilisateurId)';
        $deleteAllSchoolsFromId = $dbh->prepare($query);
        $deleteAllSchoolsFromId->execute([
            'utilisateurId' => $_SESSION["user"]->id
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function deleteAllScoolsFromUser($pdo)
{
    try {
        $query = 'delete from option_ecole where ';


        $query = 'delete from school where utilisateurId = :utilisateurId';
        $deleteAllSchoolsFromId = $pdo->prepare($query);
        $deleteAllSchoolsFromId->execute([
            'utilisateurId' => $_SESSION["user"]->id
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function selectMySchools($pdo)
{
    try {
        $query = 'SELECT * FROM school WHERE utilisateurId = :utilisateurId';
        $selectSchool = $pdo->prepare($query);
        $selectSchool->execute([
            'utilisateurId' => $_SESSION["user"]->id
        ]);
        $schools = $selectSchool->fetchAll();
        return $schools;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function selectAllOptions($pdo)
{
    try {
        $query = 'SELECT * FROM optionscolaire';
        $selectOptions = $pdo->prepare($query);
        $selectOptions->execute();
        $options = $selectOptions->fetchAll();
        return $options;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function createSchool($pdo){
    try{
        $query = 'INSERT INTO school (schoolNom, schoolAdresse, schoolVille, schoolCodePostal, schoolNumero, schoolImage, utilisateurId) VALUES (:schoolNom, :schoolAdresse, :schoolVille, :schoolCodePostal, :schoolNumero, :schoolImage, :utilisateurId)';
        $addSchool = $pdo->prepare($query);
        $addSchool->execute([
            'schoolNom' => $_POST["nom"],
            'schoolAdresse' => $_POST["Adresse"],
            'schoolVille' => $_POST["Ville"],
            'schoolCodePostal' =>$_POST["CP"],
            'schoolNumero' => $_POST["NumTel"],
            'schoolImage' => $_POST["img"],
            'utilisateurId' =>$_SESSION["user"]->id
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    } 
}

function ajouterOptionEcole($pdo, $schoolId, $optionId){
    try{
        $query = 'INSERT INTO option_ecole (schoolId, optionScolaireId) VALUES (:schoolId, :optionScolaireId)';
        $deleteAllSchoolsFromId=$pdo->prepare($query);
        $deleteAllSchoolsFromId->execute([
            'schoolId' => $schoolId,
            'optionScolaireId' => $optionId
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}