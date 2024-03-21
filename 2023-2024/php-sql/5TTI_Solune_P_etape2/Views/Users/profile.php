<div class="flex space-evenly wrap">
    <fieldset>
        <Legend>Votre Profile</Legend>
        <div class="mb-3">
            <label for="Nom" class="form-label">Nom : <?= $_SESSION["user"]->nomUser?></label>
        </div>
        <div class="mb-3">
            <label for="Nom" class="form-label">Prénom : <?= $_SESSION["user"]->prenomUser?></label>
        </div>
        <div class="mb-3">
            <label for="Nom" class="form-label">Email : <?= $_SESSION["user"]->emailUser?></label>
        </div>
        <div class="mb-3">
            <label for="Nom" class="form-label">Login : <?= $_SESSION["user"]->loginUser?></label>
        </div>
        <div class="mb-3">
            <label for="Nom" class="form-label">Mot de passe : <?= $_SESSION["user"]->passWordUser?></label>
        </div>
        <div class="">
        <a href="deletePofil"><button name="btnDel" class="btn btn-primary">suprimer le profil</button></a>
        </div>
    </fieldset>
</div>