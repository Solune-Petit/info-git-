<div class="flex space-evenly wrap">
    <form method="post" action="">
        <fieldset>
            <legend>Ajouter une écoles</legend>
            <div>
                <label for="Nom" class="form-label">Nom</label>
                <input type="text" placeholder="ex : collège paul éluard" class="form-control" id="nom" name="nom">
            </div>
            <div>
                <label for="Adresse" class="form-label">Adresse</label>
                <input type="text" placeholder="ex : 2 rue de la tranquilité" class="form-control" id="Adresse" name="Adresse">
            </div>
            <div>
                <label for="Ville" class="form-label">Ville</label>
                <input type="text" placeholder="ex : Montreuil" class="form-control" id="Ville" name="Ville">
            </div>
            <div>
                <label for="CP" class="form-label">Code postal</label>
                <input type="text" placeholder="ex : 93000" class="form-control" id="CP" name="CP">
            </div>
            <div>
                <label for="NumTel" class="form-label">Numéro de Telephone</label>
                <input type="text" placeholder="ex : +33101010" class="form-control" id="NumTel" name="NumTel">
            </div>
            <div>
                <label for="options[]" class="form-label">Choisis une option <br>(maintenez la touche 'ctrl' pour faire une sélection multiple)</label>
                <select name="options[]" id="options-select" class="form-control" multiple>
                    <?php foreach ($options as $option) : ?>
                        <option value="<?= $option->optionScolaireId ?>"><?= $option->nom ?></option>
                    <?php endforeach ?>
                </select>
            </div>
            <div>
                <label for="img" class="form-label">Image (URL)</label>
                <input type="text" placeholder="ex : https://fdjsqkfdsq" class="form-control" id="img" name="img">
            </div>
            <div>
                <button name="btnEnvoi" class="btn btn-primary">Ajouter votre Ecole</button>
            </div>
        </fieldset>
    </form>
</div>