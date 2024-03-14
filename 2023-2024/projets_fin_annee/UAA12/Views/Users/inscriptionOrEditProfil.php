<div class="flex space-evenly">
    <form method="post" action="">
        <fieldset>
            <legend>Inscription</legend>
            <div class="flexible space-evenly">
                <div>
                    <div class="mb-3">
                        <label for="Nom" class="form-label">Nom</label>
                        <input type="text" placeholder="Nom" class="form-control" id="nom" name="nom" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->nomUser ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <label for="Prenom" class="form-label">Prénom</label>
                        <input type="text" placeholder="Prénom" class="form-control" id="prenom" name="prenom" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->prenomUser ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <label for="email" class="form-label">Email</label>
                        <input type="email" placeholder="Email" class="form-control" id="email" name="email" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->emailUser ?>" <?php endif ?>>
                    </div>
                </div>
                <div>
                    <div class="mb-3">
                        <label for="Login" class="form-label">Login</label>
                        <input type="text" placeholder="Login" class="form-control" id="login" name="login" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->loginUser ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <label for="Password" class="form-label">Mot de passe</label>
                        <input type="password" placeholder="Mot de passe" class="form-control" id="mot_de_passe" name="mot_de_passe" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->passWordUser ?>" <?php endif ?>>
                    </div>
                </div>
                <div>
                    <div class="mb-3">
                        <label for="adresseUser" class="form-label">Adressse</label>
                        <input type="adresseUser" placeholder="ex : 1 avenue compte de smet de Nayer" class="form-control" id="adresseUser" name="adresseUser" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->adresseUser ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <label for="CPUser" class="form-label">Code Postal</label>
                        <input type="CPUser" placeholder="ex : 5000" class="form-control" id="CPUser" name="CPUser" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->CPUser ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <label for="villeUser" class="form-label">Ville</label>
                        <input type="villeUser" placeholder="ex : Namur" class="form-control" id="villeUser" name="villeUser" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->villeUser ?>" <?php endif ?>>
                    </div>
                </div>
            </div>
                <div>
                    <button name="btnEnvoi" class="btn btn-primary btn-big"><?php if (isset($_SESSION['user'])) : ?>modifier le profil<?php else : ?>Valider<?php endif ?></button>
                </div>
        </fieldset>

        <?php if (isset($_SESSION['user'])) : ?> <?php else : ?> <h4 class="text-danger">Déjà inscrit ?</h4>
            <a href="connexion" class="btn btn-secondary">Cliquez ici !</a> <?php endif ?>
    </form>
</div>