<h1>infos utillisateurs</h1>

<div class="admin"><?php foreach ($users as $user) : ?>

        <ul class="flexible space-around border">

            <li>id <?= $user->id ?></li>
            <li>nom <?= $user->nomUser ?></li>
            <li>prénom <?= $user->prenomUser ?></li>
            <li>login <?= $user->loginUser ?></li>
            <li>mot de passe <?= $user->passWordUser ?></li>
            <li>role <?= $user->role ?></li>
            <li>Email <?= $user->emailUser ?></li>
            <li>adresse <?= $user->adresseUser ?>, <?= $user->CPUser ?>, <?= $user->villeUser ?></li>
        </ul>
    <?php endforeach ?>
</div>

<h1>infos magasins</h1>


<div class="admin">
    <?php foreach ($stores as $store) : ?>

        <ul class="flexible space-around border">

            <li>id : <?= $store->idstores ?></li>
            <li>nom : <?= $store->namestores ?></li>
            <li>prénom : <?= $store->storeAdresse ?></li>
            <li>login : <?= $store->storeNumero ?></li>
            <li>mot de passe : <?= $store->storeWebsite ?></li>
            <li>role : <?= $store->userId ?></li>
            <li>Email : <?= $store->EmailStores ?></li>
            <li>adresse : <?= $store->storeAdresse ?>, <?= $store->storeCodePostal ?></li>
            <li>Image : <img src="/Assets/images/<?=$store->storeImage?>" alt="img du magasin" class="imageIcon"></li>
        </ul>
    <?php endforeach ?>
</div>