import pyautogui
import time

pyautogui.keyDown("ctrl")
pyautogui.press("tab")
pyautogui.keyUp("ctrl")
pyautogui.keyDown("ctrl")
pyautogui.press("tab")
pyautogui.press("tab")
pyautogui.keyUp("ctrl")
pyautogui.keyDown("ctrl")
pyautogui.press("tab")
pyautogui.keyUp("ctrl")


for i in range(0,2):

    pyautogui.keyDown("ctrl")
    pyautogui.keyDown("tab")
    pyautogui.keyUp("tab")
    pyautogui.keyUp("ctrl")
    pyautogui.keyDown("ctrl")
    pyautogui.keyDown("tab")
    pyautogui.keyUp("tab")
    pyautogui.keyUp("ctrl")

    pyautogui.press("down")

    pyautogui.keyDown("shift")
    pyautogui.press("left")
    pyautogui.press("left")
    pyautogui.press("left")
    pyautogui.keyUp("shift")

    pyautogui.keyDown("ctrl")
    pyautogui.press("c")
    pyautogui.keyUp("ctrl")

    pyautogui.moveTo(414,772)

    pyautogui.rightClick()
    pyautogui.press("enter")

# //////////////////////////////////////////

pyautogui.moveTo(414,772)
pyautogui.mouseDown(button='left')
pyautogui.moveTo(389, 771)
pyautogui.mouseUp(button='left')
pyautogui.keyDown("ctrl")
pyautogui.keyDown("c")
pyautogui.keyUp("c")
pyautogui.keyUp("ctrl")