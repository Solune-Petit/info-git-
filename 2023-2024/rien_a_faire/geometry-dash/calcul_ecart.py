import os
import time
restart = "y"
while restart == "y":
    os.system("cls")
    nbr1 = input("nbr1 \n")
    nbr2 = input("nbr2 \n")

    os.system("cls")

    if nbr1 > nbr2 :
        print(int(nbr1)-int(nbr2))
    elif nbr2 > nbr1:
        print(int(nbr2)-int(nbr1))
    
    time.sleep(2)

    restart = input("restart ?")