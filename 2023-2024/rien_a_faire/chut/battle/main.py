import pyautogui
import pytesseract

img1 = pyautogui.screenshot("img1.png", region=(796,828,73,26))
img2 = pyautogui.screenshot("img2.png", region=(1209,828,80,26))
img3 = pyautogui.screenshot("img3.png", region=(1630,828,80,26))

valeur1 = pytesseract.image_to_string(img1)

print(valeur1)