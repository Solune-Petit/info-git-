<ul class="flexible space-evenly header">
    <li class="menu"><a href="/index.php">Home</a></li>
    <?php if(isset($_SESSION["user"])) : ?>
        <li class="menu"><a href="mesEcoles">Ecoles</a></li>
        <li class="menu"><a href="inscriptionOrEditProfil">Profil</a></li>
        <li class="menu"><a href="deconnexion">Deconnexion</a></li>
    <?php else : ?>
        <li class="menu"><a href="inscriptionOrEditProfil">Inscription</a></li>
        <li class="menu"><a href="connexion">Connexion</a></li>
    <?php endif ?>
</ul>