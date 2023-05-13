from pydub import AudioSegment
import os
import subprocess
src = "ngu.mp3"
dst = "result.wav"
sound = AudioSegment.from_mp3(src)
sound.export(dst, format="wav")
