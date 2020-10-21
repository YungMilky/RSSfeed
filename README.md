Öppna en terminal/kommandotolk i projektmappen:
navigera till din projektmapp i explorer/finder, för mig är det "F:\NetBeansProjects\Informatik"
windows:
	shift+högerklicka på en tom plats -> Open PowerShell window here

mac:
	Finder (längst upp till vänster i din toolbar) -> Services -> New Terminal 

Ladda ner master och lägg den på branchen du är på:
	git checkout [dinBranch]
	git pull origin master

Innan du börjar koda gå in på din egna branch:
	git checkout [dinBranch] (exempel: "git checkout Sam's branch")

Om du vill lägga upp ändringar:
1. Hämta master och mergea med dina ändringar:
	git checkout master
	git pull

2. Stagea ändringar:
	git checkout [dinBranch] (gå in i din branch)
	git add -A

3. lägg upp ändringar:
	git commit -m "[beskrivning av vad du lägger upp]"
	git push
