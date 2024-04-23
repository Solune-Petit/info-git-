<ul class="flexible space-evenly header">
    <li class="menu"><a href="pageAcceuil">accueil</a></li>
    <!-- si le mec est un magasin -->
    <?php if (isset($_SESSION["user"]) && ($_SESSION["user"]->role == 'store' || $_SESSION["user"]->role == 'admin')):?>
        <li class="menu"><a href="factory">nos usines</a></li>
        <li class="menu"><a href="myStore">Mes magasins</a></li>

    <?php endif ?>
        <li class="menu"><a href="magasins">nos magasins</a></li>

    <!-- si le mec est connecté -->
    <?php if (isset($_SESSION["user"])) : ?>
        <li class="menu"><a href="orders">commandes</a></li>
        <li class="menu"><a href="updateProfile">Profil</a></li>
        <li class="menu"><a href="deconnexion">Deconnexion</a></li>

    <!-- si le mec est pas connecté -->
    <?php else : ?>
        <li class="menu"><a href="inscriptionOrEditProfil">Inscription</a></li>
        <li class="menu"><a href="connexion">Connexion</a></li>
    <?php endif ?>
</ul>