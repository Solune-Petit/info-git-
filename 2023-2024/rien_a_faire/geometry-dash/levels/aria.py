import pyautogui
import time

# Delay before starting the script
time.sleep(5)

# Press the space bar to start the level
pyautogui.press('space')

# Loop to control the player
while True:
    # Check if the player has completed the level
    if pyautogui.locateOnScreen('level_completed.png'):
        break

    # Check if the player has crashed
    if pyautogui.locateOnScreen('crash.png'):
        # Press the space bar to restart the level
        pyautogui.press('space')
    
    # Press the space bar to make the player jump
    pyautogui.press('space')