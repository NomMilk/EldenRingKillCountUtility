import pyautogui
import time
import os

os.startfile("KillEldenRing.exe")
Value = int(open("ScoreCount.txt", "r").read())
while True:
    try:
        img = pyautogui.locateOnScreen('ScoreCount.txt', confidence=0.6, grayscale=True)
        Value += 1

        File = open("ScoreCount.txt", "w")
        File.write(str(Value))
        File.close()

        print('Found it!')
        time.sleep(30)
    except pyautogui.ImageNotFoundException:
        print(None)