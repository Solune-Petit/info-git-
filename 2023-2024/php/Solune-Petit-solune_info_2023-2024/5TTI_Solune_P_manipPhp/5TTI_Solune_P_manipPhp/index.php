<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/style.css">
    <title>Document</title>
</head>
<body>
    <!-- étape 0 -->
    <h1>étape 0</h1>
    <?php
        echo "hello world";
    ?>

    <br>

    <!-- étape 1 -->
    <h1>étape 1</h1>
    <?php
        for ($i = 1;$i <= 10; $i++){
            echo "<p> le nombre vaut $i </p>";
        }
    ?>

    <!-- étape 2 -->
    <h1>étape 2</h1>
    <?php
        for ($i = 1;$i <= 10 ; $i++){
            if ($i == 3){
                
            }else{
                echo "<p> le nombre vaut $i </p>";
            }
        }
    ?>

    <!-- étape 3 -->
    <h1>étape 3</h1>
    <?php
        for ($i = 1;$i <= 10 ; $i++){
            if ($i >=3 && $i <= 7){
                
            }else{
                echo "<p> le nombre vaut $i </p>";
            }
        }
    ?>

    <!-- étape 4 -->
    <h1>étape 4</h1>
    <?php
        echo "<p> la valeur absolue de -5 est ".abs(-5). "</p>";
        echo "<p> la valeur absolue de 10 est ".abs(10). "</p>";
    ?>
</body>
</html>