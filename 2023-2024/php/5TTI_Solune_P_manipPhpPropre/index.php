<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <!-- étape 0 -->
    <h1>étape 0</h1>
    <?php
        echo "hello world";
    ?>

    <!-- étape 1 -->
    <h1>étape 1</h1>
    <?php
        for ($i = 1;$i <= 10; $i++): ?>
            <p> le nombre vaut <?= $i ?> </p>
        <?php endfor ?>

    <!-- étape 2 -->
    <h1>étape 2</h1>
    <?php
        for ($i = 1;$i <= 10 ; $i++):
            if ($i == 3): 
                
            else: ?>
                <p> le nombre vaut <?= $i ?> </p>
            <?php endif ?>
        <?php endfor ?>


    <!-- étape 3 -->
    <h1>étape 3</h1>
    <?php
        for ($i = 1;$i <= 10 ; $i++):
            if ($i >=3 && $i <= 7):
                
            else: ?>
                <p> le nombre vaut <?= $i ?> </p>
            <?php endif ?>
        <?php endfor ?>

    <!-- étape 4 -->
    <h1>étape 4</h1>
        <p> la valeur absolue de -5 est <?= abs(-5) ?></p>
        <p> la valeur absolue de 10 est <?= abs(10) ?></p>
</body>
</html>