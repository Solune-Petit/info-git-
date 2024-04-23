<div class="flexible wrap space-around">
    <?php foreach ($stores as $store) : ?>
        <div class="border card">
            <h1 class="center card-title"><?= $store->namestores ?></h2>
            <div>
                <div class="flexible blocImageEcole">
                    <img src="../../Assets/images/<?= $store->storeImage ?>" alt="photo du magasin">
                </div>
                <div class="center">
                    <p><span><?= $store->storeAdresse ?> - </span><span><?= $store->storeCodePostal . " " . $store->storeVille ?></span></p>
                    <h3><?= $store->storeNumero ?></h3>

                    <a href="<?= $store->storeWebsite ?>" class="btn btn-page" target="_blank">site du magasin</a>
                </div>
            </div>
        </div>
    <?php endforeach ?>
</div>

<a href="addStore"><button class="btn btn-page">ajouter un magasin</button></a>