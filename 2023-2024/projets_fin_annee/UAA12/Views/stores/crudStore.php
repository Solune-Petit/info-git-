<div class="flex space-evenly">
    <form method="post" action="">
        <fieldset>
            <legend><?php if (isset($stores)) : ?> Modifier vos informations <?php else : ?> Inscription <?php endif ?></legend>
            <div class="flexible space-evenly">
                <div>
                    <div class="mb-3">
                        <label for="Nom" class="form-label">Nom du magasin</label>
                        <input type="text" placeholder="Nom" class="form-control" id="nom" name="nom" required <?php if (isset($stores)) : ?>value="<?= $stores->namestores ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <?php if (isset($stores->storeImage)) : ?> <img src="../../Assets/images/<?= $stores->storeImage ?>" alt="photo du magasin"> <?php endif ?>
                        <label for="storeImage" class="form-label">Image du magasin</label>
                        <input type="file" accept=".png,.jpg,.jpeg" placeholder="storeImage" class="form-control" id="storeImage" name="storeImage" <?php if (isset($stores)) : ?>value="<?= $stores->storeImage ?>" <?php endif ?>>
                    </div>
                </div>
                <div>
                    <div class="mb-3">
                        <label for="number" class="form-label">numéro de téléphone</label>
                        <input type="text" placeholder="ex : +32 00 00 00" class="form-control" id="number" name="number" required <?php if (isset($stores)) : ?>value="<?= $stores->storeNumero ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <label for="Email" class="form-label">adresse Email</label>
                        <input type="Email" placeholder="ex : monEmail@gmail.com" class="form-control" id="Email" name="Email" required <?php if (isset($stores)) : ?>value="<?= $stores->EmailStores ?>" <?php endif ?>>
                    </div>
                </div>
                <div>
                    <div class="mb-3">
                        <label for="adresse" class="form-label">Adressse</label>
                        <input type="adresse" placeholder="ex : 1 avenue compte de smet de Nayer" class="form-control" id="adresse" name="adresse" required <?php if (isset($stores)) : ?>value="<?= $stores->storeAdresse ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <label for="CPU" class="form-label">Code Postal</label>
                        <input type="int" placeholder="ex : 5000" class="form-control" id="CP" name="CP" required <?php if (isset($stores)) : ?>value="<?= $stores->storeCodePostal ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <label for="ville" class="form-label">Ville</label>
                        <input type="ville" placeholder="ex : Namur" class="form-control" id="ville" name="ville" required <?php if (isset($stores)) : ?>value="<?= $stores->storeVille ?>" <?php endif ?>>
                    </div>
                </div>
            </div>
            <div>
                <button name="btnEnvoiStores" <?php if (isset($stores)) : ?> class="btn btn-primary btn-big-custom"> modifier le magasin<?php else : ?>class="btn btn-primary btn-big">Ajouter votre magasin<?php endif ?></button>
            </div>
        </fieldset>
    </form>
    <form method="post" action="">
        <fieldset>
            <legend>vos produits</legend>
            <?php foreach ($products as $product) : ?>
                <div class="flexible space-evenly">
                    <div class="mb-3">
                        <label for="productsNoms" class="form-label">Nom du produit</label>
                        <input type="text" placeholder="productsNoms" class="form-control" id="productsNoms" name="productsNoms" value="<?= $product->productsNoms ?>">
                    </div>
                    <div class="mb-3">
                        <label for="productsQuantity" class="form-label">quantitée</label>
                        <input type="int" placeholder="productsQuantity" class="form-control" id="productsQuantity" name="productsQuantity" value="<?= $product->productsQuantity ?>">
                    </div>

                    <!-- <button name="btnEnvoiModifProduits" class="btn btn-primary btn-big"> modifier ce produit</button> -->
                    <!-- <button name="btnEnvoiDelProduits" class="btn btn-primary btn-big"> suprimer ce produit</button> -->


                </div>



            <?php endforeach ?>
        </fieldset>
    </form>
    <form method="post" action="">
        <fieldset>
            <legend>ajouter un produit</legend>
            <div class="flexible space-evenly">
                <div class="mb-3">
                    <label for="productsName" class="form-label">Nom du produit</label>
                    <input type="text" placeholder="productsName" class="form-control" id="productsName" name="productsName">
                </div>
                <div class="mb-3">
                    <label for="productsQuantity" class="form-label">quantité</label>
                    <input type="int" placeholder="productsQuantity" class="form-control" id="productsQuantity" name="productsQuantity">
                </div>
            </div>

            <div>
                <button name="btnEnvoiAjoutProduits" class="btn btn-primary btn-big">Ajouter votre produit</button>
            </div>
        </fieldset>

        <?php if (isset($stores)) : ?> <button name="delStore" class="btn btn-primary btn-big-custom back-red"><a href="deleteStore">Suprimer le profil</a></button> <?php endif ?>
    </form>
</div>