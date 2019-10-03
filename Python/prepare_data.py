from nltk.tokenize import sent_tokenize, word_tokenize
from nltk.corpus import stopwords

import pymorphy2
morph = pymorphy2.MorphAnalyzer()

import codecs
f = codecs.open( "label12.data", "r", "utf_8_sig" )
data = f.read().lower()
f.close()
stopWords = set(stopwords.words('russian'))
words = word_tokenize(data)
wordsFiltered = []
for w in words:
	if w not in stopWords and w != "," and w != "." and w != ":" and w != ";" and w != "-" and w != "!" and w != "?" and w != "(" and w != ")":
	    if w[:9] == "__label__":
	        w = "\n" + w
	    wordsFiltered.append(w)

result = ""
for w in wordsFiltered:
    p = morph.parse(w)[0]
    if p.normal_form == "вод" or p.normal_form == "водо":
	    result += "вода "
    else:
	    result += p.normal_form + " "
f = codecs.open("label12.train", "w+", "utf_8_sig")
f.write(result)
