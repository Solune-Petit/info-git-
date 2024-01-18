<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/style.css">
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
    <div class="mini_group">
      <label for="Email">Email</label>
      <input type="text" id="lname" name="lname"required>
    </div>
    <div class="mini_group">
      <label for="Country">Pays</label>
      <select name="pays" required>
        <option value="defaul" selected disabled>choisissez une option</option>
        <optgroup label="Europe">
          <option value="Belgique">Belgique</option>
        </optgroup>
        <optgroup label="Amérique du nord">
          <option value="États-Unis">États-Unis</option>
          <option value="Canada">Canada</option>
        </optgroup>
        <optgroup label="Asie">
          <option value="Japon">Japon</option>
          <option value="Chine">Chine</option>
        </optgroup>
      </select>
    </div>
  </fieldset>

  <div class="partie_droite">
    <div class="partie_droite_H">
      <fieldset>
        <legend>Pérodicité</legend>
        <div class="mini_group">
          <input type="checkbox" name="Newsletter hebdomadaire" value="checkbox_news" required><label>Newsletter hebdomadaire</label>
        </div>
        <div class="mini_group">
          <input type="checkbox" name="Newsletter mensuelle" value="checkbox_news" required><label>Newsletter mensuelle</label>
        </div>
        <div class="mini_group">
          <input type="checkbox" name="Newsletter trimestrielle" value="checkbox_news" required><label> Newsletter trimestrielle</label>
        </div>
      </fieldset>
    </div>
    <div class="partie_droite_B">
      <fieldset>
        <legend>Version papier / informatique</legend>
        <div class="mini_group">
        <input type="checkbox" name="version papier" value="version"><label>recevoir la version papier</label>
        </div>
        <div class="mini_group">
        <input class="checkbox" type="checkbox" name="version informatique" value="version"><label>recevoir la version informatique</label>
        </div>
        <div class="mini_group">
        <label>nombre de copies souhaitées : </label><input type="number" name="nbr_copies" min="1" max="10"/>
        </div>
      </fieldset>
    </div>
    <div class="submit-div">
    <input class="submit" type="submit" name="submit" value="Submit">
    </div>
  </div>
</form>


</body>
</html>