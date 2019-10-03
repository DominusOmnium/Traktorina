from flask import Flask
from flask import request
import fasttext
from nltk.tokenize import sent_tokenize, word_tokenize
from nltk.corpus import stopwords

import pymorphy2
morph = pymorphy2.MorphAnalyzer()

data = "У меня в комнате течёт холодная вода"
stopWords = set(stopwords.words('russian'))
words = word_tokenize(data)
wordsFiltered = []

for w in words:
	if w not in stopWords and w != "," and w != "." and w != ":" and w != ";" and w != "-":
		wordsFiltered.append(w)

result = ""

for w in wordsFiltered:
	p = morph.parse(w)[0]
	result += p.normal_form + " "

switch = {
		'__label__0' : 'models/label0_model',
		'__label__1' : 'models/label1_model',
		'__label__2' : 'models/label2_model',
		'__label__3' : 'models/label3_model',
		'__label__4' : 'models/label4_model',
		'__label__5' : 'models/label5_model',
		'__label__6' : 'models/label6_model',
		'__label__7' : 'models/label7_model',
		'__label__8' : 'models/label8_model',
		'__label__9' : 'models/label9_model',
		'__label__10' : 'models/label10_model',
		'__label__11' : 'models/label11_model',
		'__label__12' : 'models/label12_model',
		'__label__13' : 'models/label13_model'
	}


flev_model = fasttext.load_model("flev_model")
f_predict = flev_model.predict(result, k=-1, threshold=1.0/len(flev_model.get_labels()))

res = ""
for l in f_predict[0]:
    model = fasttext.load_model(switch[l])
    sl_predict = model.predict(result, k=-1, threshold=1.0/len(model.get_labels()))
    if (sl_predict[0]) == 0:
		    res += l[9:]
    for sl in sl_predict[0]:
	    res += sl[9:]
print(res)
