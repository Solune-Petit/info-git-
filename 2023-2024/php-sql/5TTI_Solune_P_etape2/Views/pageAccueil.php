<?php if ($uri === "/mesEcoles") : ?>
    <h1>Vos écoles</h1>
<?php else : ?>
    <h1>Liste des écoles répertoriées</h1>
<?php endif ?>

<!--Dans le cas où on est connecté, on affiche un Lien permettant l'ajout d'une école -->
<?php if (isset($_SESSION["user"])) : ?>
    <a href="createSchool"><button class="btn"> Ajouter une école</button></a>
<?php endif ?>

<div class="flexible wrap space-around">
    <?php foreach ($schools as $school) : ?>
        <div class="border card">
            <h2 class="center"><?= $school->schoolNom ?></h2>
            <div>
                <div class="flexible blocImageEcole">
                    <img src="<?= $school->schoolImage ?>" alt="photo de l'école">
                </div>
                <div class="center">
                    <p><span><?= $school->schoolAdresse ?> - </span><span><?= $school->schoolCodePostal . " " . $school->schoolVille ?></span></p>
                    <h3><?= $school->schoolNumero ?></h3>

                    <!-- il reste encore à adapter le Lien pour retrouver l'école active! -->
                    <p><a href="voirEcole?schoolId=<?=$school->schoolId ?>" class="btn btn-page">Voir l'école</a></p>

                    <div class="flexible space-around">
                        <!-- Dans le cas où on est connecté et qu'on a cliqué sur mes écoles', on affiche les écoles de l'utilisateur -->
                        <?php if ($uri === "/mesEcoles") : ?>
                            <p><a href="updateEcole?schoolId=<?= $school->schoolId ?>"><button class="btn btn-page">Modifier l'école</button></a></p>
                            <p><a href="deleteEcole?schoolId=<?= $school->schoolId ?>"><button class="btn btn-page" style="color: red;"> suprimer l'école</button></a></p>
                        <?php endif ?>
                    </div>
                </div>
            </div>
        </div>
    <?php endforeach ?>
</div>