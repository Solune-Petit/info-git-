<ul class="flexible space-evenly header">
    <li class="menu"><a href="pageAcceuil">accueil</a></li>
    <li class="menu"><a href="magasins">nos magasins</a></li>
    <?php if (isset($_SESSION["user"]) && $_SESSION["user"]->role == 'store') :?>
        <li class="menu"><a href="factory">nos usines</a></li>
    <?php endif ?>
    <?php if (isset($_SESSION["user"])) : ?>
        <li class="menu"><a href="orders">commandes</a></li>
        <li class="menu"><a href="updateProfile">Profil</a></li>
        <li class="menu"><a href="deconnexion">Deconnexion</a></li>
    <?php else : ?>
        <li class="menu"><a href="inscriptionOrEditProfil">Inscription</a></li>
        <li class="menu"><a href="connexion">Connexion</a></li>
    <?php endif ?>
</ul>