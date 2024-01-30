<h1>Liste des écoles répertoriées</h1>

<div class="flexible">
    <div class="flexible wrap space-evenly border">
        <?php foreach ($schools as $school) : ?>
            <div class="border card">
                <h2 class="center"><?= $school->schoolNom ?></h2>
                <div>
                    <div class="flexible blocImageEcole justify-content-center">
                        <img src="<?= $school->schoolImage ?>" alt="photo de l'école">
                    </div>
                    <div class="center">
                        <p><span><?= $school->schoolAdresse ?></span> - <span><?= $school->schoolCodePostal ?></span> - <span><?= $school->schoolVille ?></span></p>
                        <h3><?=$school->schoolNumero ?></h3>
                    </div>
                </div>
            </div>
        <?php endforeach?>
    </div>
</div>