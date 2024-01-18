<?php
    function DevinerNombre($value, &$message)
    {
        $aDeviner = 150;
        $message = "";
        $gagne = false;

        if ($value > $aDeviner)
        {
            $message = "votre chiffre est trop grand";
        }else if ($value < $aDeviner)
        {
            $message = "votre chiffre est trop petit";
        }else
        {
            $message = "bravo : vous avez deviné le chiffre" . $aDeviner;
            $gagne = true;
        }
        return $gagne;
    }
?>