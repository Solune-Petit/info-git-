<?php
    function algorithmEuclide2($nbr1, $nbr2)
    {
        $reste = $nbr2;
        while ($reste != 0)
        {
            $reste = $nbr1 % $nbr2;
            $nbr1 = $nbr2;
            $nbr2 = $reste;
        }
        return $nbr1;
    }

    function fonctionSpeciale($nombreDepart, $NombreElementSouhaite)
    {
        $suite = " " .  $nombreDepart . " ";
        for ($i = 1; $i < $NombreElementSouhaite + 1; $i++)
        {
            if (($nombreDepart < 5 ) && ($nombreDepart % 3 != 0))
            {
                $nombreDepart = $nombreDepart * 5;
            }else if (($nombreDepart > 5) && ($nombreDepart < 10))
            {
                $nombreDepart = $nombreDepart / 6;
            }else
            {
                $nombreDepart = $nombreDepart * $nombreDepart;
            }
            $suite += $nombreDepart;
        }
        return $suite;
    }
?>