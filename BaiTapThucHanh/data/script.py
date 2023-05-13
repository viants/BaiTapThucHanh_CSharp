import sys
import os
from gtts import gTTS
import subprocess
import hashlib
from playsound import playsound

def ConvertMp3ToWav(src, dst):
    if os.path.exists(src):
        print(src)
        subprocess.call(['ffmpeg', '-i', src, dst])
        os.remove(src)
    else:
        print("error: file path can not open")

if len(sys.argv) > 1:
    msg = str(sys.argv[1])
    fileName = hashlib.md5(msg.encode('utf-8')).hexdigest()
    filePath = fr"Sound\{fileName}.mp3"
    try:
        
        if os.path.exists(filePath):
            print(f"Playing file: {fileName}.mp3")
            playsound(filePath)
        else:
            gtt = gTTS(msg, lang="vi", slow=False)
            gtt.save(filePath)
            print(f"Mp3 file was saved! - path: {os.getcwd()}\Sound\{fileName}.mp3")
            playsound(filePath)
    except Exception as ex:
        print(ex)
    # src = filePath + ".mp3"
    # dst = filePath + ".wav"
    # convert wav to mp3                                                            
    # ConvertMp3ToWav(src, dst)

else:
    print(f"Agruments are null")

