<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>

<form action="" method=""> 
    <fieldset class="coordonee">
        <legend>vos coordonées</legend>
        <div class="mini_group">
        <label for="fName">Nom :</label>
        <input type="text" id="fname" name="fname" required>
        </div>
        <div class="mini_group">
        <label for="lName">Prénom :</label>
        <input type="text" id="lname" name="lname"required>
        </div>
        <div class="mini_group">
        <label for="bDay"> Date de Naissance :</label>
        <input type="date" id="bDay" name="bDay" value="00-00-0000"required>
        </div>
    </fieldset>

    <fieldset class="nouv-input">
        <legend>Les nouveaux input</legend>
        <div class="mini_group">
            <label for="URL">Votre URL</label>
            <input type="text" id="url" required>
        </div>
        <div class="mini_group">
            <label for="URL">Votre numéro de téléphone</label>
            <input type="text" id="num-tel" required>
        </div>
        <div class="mini_group">
            <label for="apreciation">Votre apréciation (entre 10 et 20)</label>
            <input type="range" min="10" max="20" value="15" id="num-tel" class="slider" required>
        </div>
        <div class="mini_group">
            <label for="couleur">Votre couleur préférée</label>
            <input type="text" id="num-tel" required>
        </div>
</body>
</html>