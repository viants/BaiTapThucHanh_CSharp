import sys
from translate import Translator

langIn = sys.argv[1]
langOut = sys.argv[2]
content = sys.argv[3]

translator = Translator(from_lang=langIn, to_lang=langOut)
res = translator.translate(content)

print(res)
