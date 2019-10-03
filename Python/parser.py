from html.parser import HTMLParser
import urllib.request
import io
try: 
    from BeautifulSoup import BeautifulSoup
except ImportError:
    from bs4 import BeautifulSoup

url = "https://tomrc.ru/physics/qa/?PAGEN_2="

for r in range(0, 112):
	fp = urllib.request.urlopen(url + str(r))
	mybytes = fp.read()
	mystr = mybytes.decode("utf8")
	fp.close()
	parsed_html = BeautifulSoup(mystr)
	pars = parsed_html.body.find_all('div', attrs={'class':'faq-spoiler__title'})
	with io.open("pars", "a", encoding="utf-8") as f:
		for i in pars:
			f.write(i.text + "\n-----------------------------------------------------------------------------\n")
			print("Done: " + str(r))


