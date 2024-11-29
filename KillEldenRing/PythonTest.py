import pyautogui
import time
import sys
from PyQt5.QtWidgets import QApplication, QWidget, QLabel
from PyQt5.QtCore import Qt





Value = int(open(r"C:\Users\NoahC\OneDrive\Desktop\Boss_2\Boss\Numbers.txt", "r").read())
while True:
    try:
        img = pyautogui.locateOnScreen(r'C:\Users\NoahC\OneDrive\Desktop\Boss_2\Boss\Boss.png', confidence=0.6, grayscale=True)
        Value += 1

        File = open(r"C:\Users\NoahC\OneDrive\Desktop\Boss_2\Boss\Numbers.txt", "w")
        File.write(str(Value))
        File.close()

        print('Found it!')
        time.sleep(30)
    except pyautogui.ImageNotFoundException:
        print(None)