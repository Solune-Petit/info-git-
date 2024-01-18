import pyautogui

button1 = pyautogui.locateOnScreen("/images/1.png")
button2 = pyautogui.locateOnScreen("/images/2.png")
button3 = pyautogui.locateOnScreen("/images/3.png")
button4 = pyautogui.locateOnScreen("/images/4.png")
button5 = pyautogui.locateOnScreen("/images/5.png")
button6 = pyautogui.locateOnScreen("/images/6.png")
button7 = pyautogui.locateOnScreen("/images/7.png")
button8 = pyautogui.locateOnScreen("/images/8.png")
button9 = pyautogui.locateOnScreen("/images/9.png")
button0 = pyautogui.locateOnScreen("/images/0.png")

Uinput = input("quelle touche est à présser ?")

if Uinput == "1":
    pyautogui.moveTo(button1)