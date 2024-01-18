import pyautogui
import time
import os
import winsound


# time.sleep(0.5)

os.system("cls")
winsound.Beep(700, 100)
winsound.Beep(700, 100)
time.sleep(0.5)

#partie 1

pyautogui.press("r")
time.sleep(0.8)
pyautogui.press("space")
time.sleep(0.85)
pyautogui.press("space")
time.sleep(0.1)
pyautogui.press("space")
time.sleep(0.5)
pyautogui.press("space")
time.sleep(0.06)
pyautogui.press("space")
time.sleep(0.06)
pyautogui.press("space")
time.sleep(0.06)
pyautogui.press("space")
time.sleep(0.15)
pyautogui.press("space")
time.sleep(0.3)
pyautogui.press("space")
time.sleep(0.6)
pyautogui.keyDown("space")
time.sleep(0.05)
pyautogui.keyUp("space")
time.sleep(0.3)
pyautogui.press("space")
time.sleep(0.08)
pyautogui.press("space")
time.sleep(0.02)
pyautogui.press("space")
time.sleep(0.2)
pyautogui.press("space")
# time.sleep(0.15)
# pyautogui.press("space")

im = pyautogui.screenshot("test.png")

winsound.Beep(700, 100)