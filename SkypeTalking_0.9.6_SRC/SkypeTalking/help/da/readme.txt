
SkypeTalking

Version 0.8

Copyright (c) 2010 SkypeTalk Team

Projektets netsted: http://skypetalking.googlecode.com

1. Indledning

SkypeTalking er et program, der g�r det popul�re program Skype, der bruges til internet-telefoni, mere tilg�ngeligt og nemmere at bruge for blinde. Programmet benytter Skype API Wrapper og punktskrift samt talen fra din sk�rml�ser til at finde informationerne fra Skype og sende informationen til din sk�rml�ser. SkypeTalking videregiver de fleste statusmeldinger fra Skype s�som �ndring af en brugers status, indg�ende og udg�ende chatbeskeder, status for opkald og meget mere! Skypetalking f�r kort sagt Skype til at tale!

Programmet SkypeTalking er f�rst og fremmest udviklket med det form�l at g�re Skype mere brugbart med sk�rml�seren NVDA, der er gratis og open source. Men JAWS, Window-eyes, System Access og SAPI5 tale er ogs� underst�ttet. N�r du benytter SAPI5, har du blot ikke mulighed for at udnytte punktskrift.

1.1. Systemkrav  

For at kunne bruge SkypeTallking, skal du have f�lgende:
* Windows 2000, XP, VISTA eller 7
* En af de underst�ttede sk�rml�sere: I �jeblikket omfatter dette NVDA 2010.1 eller nyere, JAWS (alle versioner), Window_Eyes (alle versioner) eller System Access (alle versioner) herunder System Access to Go.
* Hvis du ikke bruger en af de underst�ttede sk�rml�sere, bruges talen via en SAPI5 talesyntese i stedet. Hertil beh�ves en talesyntese, der er kompatibel med SAPI5 (Windows-systemer leveres med mindst 1 SAPI5 talesyntese)
* Herudover skal du naturligvis have selve Skype-programmet (3.x, 4.x eller nyere) - fungerer sandsynligvis ogs� med Skype 2.x og muligvis med version 1.x. Dette er dog ikke blevet testet.

2. Anvendelse af programmet

2.1. Installation og f�rste afvikling

Du installerer SkypeTalking ved at k�re skypetalking_setup.exe og f�lge instruktionerne. Under installationen oprettes et ikon p� Skrivebordet, en programgruppe i Start menuen samt installationsmappen x:\SkypeTalking, hvor "x" er bogstavet p� din computers systemdrev.
SkypeTalking afinstalleres ved f�rst at �bne programgruppen SkypeTalking i menuen Start og v�lge "Uninstall SkypeTalking".
Du starter SkypeTalking ved at klikke p� ikonet SkypeTalking enten fra Skrivebordet eller fra punktet SkypeTalking i Start-menuen under Programmer\SkypeTalking.
F�rste gang du starter SkypeTalking, er programmet med stor sandsynlighed ikke godkendt til at kommunikere med Skype. Af sikkerhedshensyn tillader Skype ikke tredjeparts-pluins eller ekstraprogrammer at kommunikere med Skype uden forudg�ende godkendelse af brugeren. Dette g�res for at undg�, at vira eller trodjanske heste for�rsager skader p� Skype. G�r f�lgende for at give SkypeTalking adgang til Skype:
1. Start SkypeTalking enten fra Skrivebordet eller fra menuen Start under Programmer>SkypeTalking. Du h�rer dern�st "Forbinder til Skype".
2. �bn Skype.
3. G� nu til menulinjen, v�lg Funktioner og bev�g dig med piletasterne til Indstillinger og tryk Enter.
4. V�lg nu kategorien Avanceret ved hj�lp af pil ned.
5. Tryk Shift+Tab flere gange indtil du n�r punktet "H�ndter andre programmers adgang til Skype", som er et link. Tryk mellemrum for at aktivere linket. 
6. Find skypeTalking i listen (det er s�dvanligvis det f�rste punkt), tryk Tab til du n�r knappen "�ndre" og tryk Mellemrum for at aktivere den.
Tryk Tab. Du h�rer nu, at du st�r p� en radioknap, hvor der st�r: "Giv ikke dette program adgang til Skype". Tryk Pil Op indtil du h�rer: "Giv dette program adgang til Skype" og tryk Enter.
8. S�dan! Du har netop givet SkypeTalking lov til at bruge Skype. Du h�rer nu SkypeTalkings velkomstbesked. Du kan nu forlade Indstillinger ved at trykke flere gange p� Escape. Du beh�ver ikke engang at gemme dine �ndringer.
OBS: Hver gang du geninstallerer SkypeTalking skal du gentage disse trin. Men bare rolig! Du skal kun g�re det �n gang pr. SkypeTaling-installation. Du skal ligeledes g�re det, hvis du �ndrer den placering, hvor SkypeTalking.exe ligger.


2.2. Anvendelse

N�r SkypeTalking er startet, k�rer det i baggrunden og annoncerer begivenheder, indtil det afsluttes. SkypeTalking rummer en lang r�kke kommandoer, der er forbundet til genvejstaster og som bruges til at styre, hvordan programmet fungerer og til at f� bestemte informationer l�st op eller gentaget. Alle SkypeTalkings genvejstaster bruges sammen med tasterne Alt, ctrl og Shift (Alt+Ctrl+Shift+Noget andet). Vi siger derfor, at Alt+Ctrl+Shift fungerer som SkypeTalking-tast. En kommando udf�res derfor ved at holde Alt+Ctrl+Shift (SkypeTalking-tast) nede, mens en yderligere tast trykkes.
OBS: Du kan �ndre alle SkypeTalkings genvejstaster efter behov ved at �bne filen SkypeTalking.ini, som findes i SkypeTalking-mappen. Denne mulighed anbefales dog kun for �vede brugere for �jeblikket.

I de f�lgende afsnit beskrives alle SkypeTalkings kommandoer og deres brug.

 
3. Kommandoerne

3.1. L�se Skype chatbeskeder

3.1.1. Sig seneste 10 indg�ende/udg�ende chatbeskeder (Alt+Ctrl+Shift+tallene 1 til og med 0)

Du kan l�se de sidste indg�ende og udg�ende chatbeskeder (1 til og med 10), som du har sendt eller modtaget i l�bet af den aktuelle SkypeTalking session ved at trykke Alt+Ctrl+Shift+tallene 1 til og med 0 p� et alfanumerisk tastatur. Hvis et tal trykkes ned 2 gange, kopieres den tilknyttede besked til udklipsholderen. Trykkes det 3 gange, �bnes en web-adresse i din standard-browser, hvis den p�g�ldende besked indeholder en web-adresse.

3.1.2. Overv�ge aktive chats (Alt+Ctrl+Shift+Funktionstast F1 til og med F10)

Denne funktion giver mulighed for at overv�ge aktive chats dvs. de �bne chatvinduer. Det er nyttigt, hvis du �nsker at l�se de seneste 10 chatbeskeder i en bestemt chat i stedet for de nyeste chatbeskeder, du har modtaget fra alle chats. Benyt Alt+Ctrl+Shift+Funktionstasterne F1 til og med F10 til at s�tte en overv�gning p� en chat op til 10 chats eller tryk 2 gange for at s�tte fokus til det p�g�ldende chatvindue), hvorefter du med Alt+Ctrl+Shift+tallene kan l�se  de 10 nyeste chatbeskeder i den aktuelt overv�gede chat. N�r du trykker Alt+Ctrl+Shift+C, h�rer du, hvilken chat du netop nu overv�ger. Trykker du kommandoen 2 gange, bringes fokus til den p�g�ldende chat.

3.1.3. Gentag seneste chatbesked (Alt+Ctrl+Shift+R)
 

Denne kommando gentager den seneste indg�ende eller udg�ende chatbesked. Hvis kommandoen trykkes 2 gange, �bnes et Skype chatvindue tilknyttet denne besked samtidig med, at overv�gning s�ttes til den p�g�ldende chat.

3.2. Gentag seneste begivenhed (Alt+Ctrl+Shift+E)

Denne kommando gentager den seneste Skype begivenhed herunder chatbeskeder. De begivenheder, som kan blive l�st op igen ved hj�lp af denne kommando, omfatter statusskift, seneste chatbesked og status for samtaler.

3.3. Ignor�r Skype-begivenheder (Alt+Ctrl+Shift+I)

Denne kommando bruges til at sl� ignorering af Skype-begivenheder til og fra. Hvis funktionen er sl�et til, ignorerer SkypeTalking alle begivenheder og vil hverken annoncere eller huske dem.

3.4. L�bende �ndre din status p� Skype (Alt+Ctrl+Shift+Backspace)

Denne kommando bruges til skift af Skype-status imellem online, ikke tilstede, ikke tilg�ngelig, vil ikke forstyrres osv. Din status �ndres 1 sekund efter, at du har trykket kommandoen.

3.5. Sig samtales varighed (Alt+Ctrl+Shift+D)

Kommandoen virker under en samtale. Den vil annoncere varigheden af den igangv�rende samtale i timer/minutter/sekunder.

3.6. Sig status for den igangv�rende filoverf�rsel (Alt+Ctrl+Shift+F)

Denne kommando vil oplyse status for den seneste indg�ende eller udg�ende filoverf�rsel. Hvis den p�g�ldende filoverf�rsel er i gang, oplyses ligeledes overf�rselshastigheden i megabytes pr. sekund samt antal megabytes, der allerede er overf�rt.

3.7. Oplys din aktuelle online-status eller saldo (Alt+Ctrl+Shift+O)

F�rste gang denne kommando udf�res, oplyses din aktuelle online-status. Hvis du trykker kombinationen 2 gange, oplyses din Skypekredit saldo.

3.8. Opl�s eller skift din Skype hum�rbesked (Alt+Ctrl+Shift+M)

Hvis du har angivet en hum�rbesked p� Skype, bruges denne kommando til at f� l�st den op. Hvis du trykker den 2 gange, fremkommer en dialogboks, hvor du kan indtaste en hum�rbesked. Du indtaster din tekst og afslutter med Enter. Derefter �ndres din hum�rbesked.

3.9. andre kommandoer

3.9.1. Dialogboksen Om SkypeTalking (Alt+Ctrl+Shift+A)

Der fremkommmer en dialogboks med oplysninger om den aktuelle version af SkypeTalking, information om copyright, information om webstedet osv. Du lukker dialogboksen ved at trykke Enter. 

3.9.2. Oplys Skype-version (Alt+Ctrl+Shift+V)

Denne kommando oplyser, hvilken version af Skype der i �jeblikket er installeret p� brugerens computer. Hvis den trykkes 2 gange, oplyses hvilken version af Skype Wrapper API, der er installeret (hovedsageligt nyttig for udviklere).

3.9.3. Stop SAPI5-tale (Alt+Ctrl+Shift+Mellemrum)

Denne kommando standser talen, n�r SkypeTalking benytter SAPI5-tale. Hvis du bruger SkypeTalking sammen med din sk�rml�ser, kan du stoppe talen p� normal vis med Ctrl-tasten.

3.9.4. Afslut SkypeTalking (Alt+Ctrl+shift+Q)

Denne kommando udl�ser SkypeTalking fra hukommelsen. Du vil som standard blive bedt om at bekr�fte. Hvis du svarer ja, udl�ses SkypeTalking og alle nye begivenheder, igangv�rende filoverf�rsler og chatbeskeder slettes, fordi Skypetalking holder styr p� dem i computerens hukommelse. Hvis du svarer nej, forts�tter SkypeTalking med at k�re i sin igangv�rende session.

4. Dialogboksen Indstillinger

Dialogboksen med SkypeTalkings indstillinger startes ved at trykke Alt+Ctrl+Shift+P. Herfra kan du �ndre SkypeTalkings virkem�de, standardsprog samt output. Dialogboksen Indstillinger indeholder 3 faneblade (Generel, Output og meldinger), som du kan skifte imellem ved hj�lp af de s�dvanlige Windows genvejstaster Ctrl+tab og Ctrl+Shift+Tab.

4.1. Fanebladet Generel

Fanebladet Generel i SkypeTalkings indstillings-dialogboks har f�lgende indstillingsmuligheder.

4.1.1. Sprog

Combo-boksen Sprog viser alle de tilg�ngelige sprog, som SkypeTalking i �jeblikket underst�tter. Her kan du v�lge dit foretrukne sprog, og dit valg f�r omg�ende virkning, s� snart du har gemt dine valg. Som standard bruger SkypeTalking sproget i dit operativsystem.

4.1.2. Start Skype automatisk, hvis programmet ikke allerede k�rer

Hvis denne indstilling er sl�et til, starter SkypeTalking automatisk selve Skype-programmet, hvis du har glemt at starte Skype, f�r du startede SkypeTalking. Det kan ogs� v�re nyttigt, hvis du har brug for at f� �jeblikkelig tale p� Skype. Indstillingen er sl�et til som standard, hvilket betyder at SkypeTalking starter Skype, hvis Skype ikke allerede k�rer.

4.1.3. Bekr�ft inden afslutning af SkypeTalking

Indstillingen er sl�et til som standard. Hvis du sl�r den fra, udl�ses SkypeTalking �jeblikkelig, s� snart kommandoen for at afslutte udf�res og meddelelsen til bekr�ftelse springes over.

4.1.4. N�r SkypeTalking afsluttes skal Skype ligeledes afsluttes

Indstillingen er selvforklarende. Den er sl�et til som standard dvs. at SkypeTalking vil afslutte Skype, n�r du afslutter SkypeTalking. Du b�r derfor sl� indstillingen fra, hvis du �nsker at bruge Skype, n�r du har afsluttet SkypeTalking.

4.2. Fanebladet Output

Fanebladet Output rummer indstillinger, der har med output via tale og punktskrift at g�re. Herfra kan du justere f�lgende indstillinger.

4.2.1. Tale-output

Denne combo-boks giver dig mulighed for at v�lge, hvor taleoutput skal foretages. Hvis du v�lger Find Automatisk, bruges din nuv�rende sk�rml�ser eller SAPI5, hvis der ikke k�rer nogen sk�rml�ser, eller hvis SkypeTalking ikke underst�tter din sk�rml�ser. Hvis du v�lger SAPI5, bruger SkypeTalking automatisk den SAPI5-talesyntese, der er valgt som standard p� dit system og ignorerer din sk�rml�ser.

4.2.2. SAPI5 indstillingsmuligheder

De efterf�lgende 3 kontroller er redigerings-spinbokse til styring af lydstyrke og talehastighed for din SAPI5 talesyntese. De f�r virkning, hvis du har valgt SAPI5. Du kan enten �ndre v�rdierne ved hj�lp af piletasterne eller ved at skrive den �nskede v�rdi med tal.

4.2.3. Sl� visning i punktskrift til

Med denne tjekboks f�r du mulighed for at f� SkypeTalkings output vist p� dit punktdisplay. Denne indstilling virker ikke, n�r du bruger SAPI5 til taleoutput.

4.3. Fanebladet Meldinger

I dette faneblad kan du sl� annoncering af de forskellige Skype-meldinger, der i �jeblikket underst�ttes af SkypeTalking, til og fra. Alt, hvad der ikke er markeret/afkrydset her, ignoreres af SkypeTalking. Du kan �ndre annoncering af indg�ende chats, udg�ende chats, onlien status osv.

5. Kontaktpersoner (Contacts Manager)

SkypeTalkings Contacts Manager giver dig mulighed for at administrere dine Skype-kontaktpersoner p� en nemmere og mere tilg�ngelig m�de. Du �bner manageren med genvejstasten Alt+Ctrl+Shift+F11. Hvis du trykker denne kommando 2 gange, vil SkypeTalking igen fokusere p� Skypes oprindelige vindue med kontaktpersoner.

5.1. navigation i Contacts Manager

SkypeTalkings Contacts Manager viser dine kontaktpersoner i en multivalg listboks, hvilket giver dig mulighed for at v�lge �n eller flere kontaktpersoner, som du dern�st kan udf�re en bestemt handling p�. Med piletasterne bev�ger du dig rundt i listen over kontaktpersoner og Mellemrum til henholdsvis at v�lge og frav�lge en kontaktperson. Contacts Manager viser ligeledes kontaktpersonernes status, hum�rbesked samt, for kontaktpesoner der er offline, meddelelse om tidspunkt for, hvorn�r den p�g�ldende kontaktperson sidst blev set online.

5.2. Udf�re en handling p� den valgte kontaktperson

De valgmuligheder, der vises i Contacts Manager, afh�nger af antallet af valgte kontaktpersone. Hvis du ikke har valgt nogen kontaktpersoner, giver SkypeTalking en advarselsbesked. Hvis en enkelt kontaktperson er valgt, er f�lgende handlinger tilg�ngelige:
1. Knappen Ring Op - foretrager et opkald til den valgte kontaktperson - denne knap er standard, s� den aktiveres ogs� ved tryk p� Enter, n�r du st�r p� en kontaktperson.
2. Knappen Chat - �bner et vindue, der indeholder en chat med den valgte kontaktperson.
3. Knappen Vis Profil - �bner Contact Managers profilvisningsvindue med oplysninger om den valgte kontaktpersons profil.
Hvis du har valgt 2 elelr flere kontaktpersoner, kan du foretage f�lgende handlinger:
1. Knappen Opret Telefonm�de - Opretter et telefonm�de med alle de valgte kontaktpersoner - denne knap er standard, s� du kan ogs� aktivere den ved tryk p� Enter, n�r du har valgt kontaktpersonerne.
2. Knappen Opret Multichat - �bner et chatvindue og opretter en multichat med alle de valgte kontaktpersoner.
Du kan med Tab og Shift+Tab bev�ge dig imellem de forskellige handlinger og listen over kontaktpersoner. Du kan til enhver tid trykke Escape eller v�lge knappen Cancel for at lukke Contacts Manager.

5.3. Profilvisning

Profilvisningen er en del af Contacts Manager, der aktiveres ved tryk p� knappen Vis Profil for en enkelt kontaktperson. Den viser detaljerne i den p�g�ldende kontaktpersons profil i en tilg�ngelig dialogboks, der er nem at bruge. Tab og Shift+Tab bruges til at flytte imellem de enkelte detaljer. Du kan desuden bruge piletasterne og de velkendte kommandoer til udv�lgelse af tekst til kopiering af en bestemt detalje, hvis du har brug for det. Tryk Escape eller v�lg knappen Cancel for at lukke Profilvisning og vende tilbage til Contacts Manager.

6. Sende og modtage SMS-beskeder med SkypeTalking

Du kan nemt sende og modtage SMS-beskeder med SkypeTalkings SMS-assistent.

6.1. SMS-assistenten

Du f�r adgang til SMS-assistenten ved at trykke Alt+Ctrl+Shift+S. N�r den �bner, bliver du bedt om at indtaste et telefonnummer. Du skal indtaste et gyldigt telefonnummer inklusive landekode. For eksempel: +11234567. Hvis nummeret ikke er gyldigt, bliver du atter placeret i feltet til indtastning af telefonnummer, s� du kan fors�ge igen. Tryk Enter for at forts�tte eller Escape for at annullere. Hvis nummeret er gyldigt, forts�tter assistenten og du placeres nu i et indtastningsfelt, hvor du skriver din SMS-besked. N�r du st�r i denne dialogboks, kan du til enhver til trykke F2 for at h�re status for den SMS, du er i gang med at skrive. Du h�rer en advarselslyd, n�r det resterende antal tegn i beskeden n�r 0. N�r du er f�rdig med at skrive din SMS, kan du trykke Enter eller bev�ge dig med Tab til knappen Send eller trykke Cancel for at annullere afsendelsen. N�r du har aktiveret knappen Send og din saldo er positiv, sendes din SMS.

7. Afsluttende bem�rkninger og kontaktoplysninger

7.1. Hente kildekoden

SkypeTalking er gratis og open source software, der er skrevet i programmeringssproget PYTHON, som er tilg�ngeligt fra www.python.org. Open source betyder, at kildekoden er tilg�ngelig for alle, der �nsker den. SkypeTalking benytter licensen GNU General Public License version 2.0. Du finder hele teksten til licensen i filen license.txt, som f�lger med SkypeTalking. Hvis du selv er programm�r eller �nsker at bidrage til kildekoden eller afvikler SkypeTalking direkte fra kildekoden, kan du finde kildekoden til SkypeTalking i SVN p� f�lgende adresse:
http://skypetalking.googlecode.com
som er projektets netsted. Herfra kan du ogs� hente den seneste version.

7.2. Bidrage med overs�ttelse

hvis du er overs�tter og �nsker at lokalisere SkypeTalking og programmets dokumentation til dit eget sprog, kan du kontakte mig pr. e-mail for at f� den seneste sprogfil sammen med instruktioner i, hvordan du kan sende dine overs�ttelser tilbage til mig. 

7.3. SkypeTalking postlisten

Du kan tilmelde dig SkypeTalkings e-postliste hos Google Grupper p� f�lgende adresse:
skypetalking+subscribe@googlegroups.com.
Hvis du vil sende mail til listen, skal du sende til:
skypetalking@googlegroups.com.
Bem�rk venligst at sproget p� denne postliste er engelsk. Det er det bedste sted at f� teknisk support samt tips og tricks til brugen af SkypeTalking. Det er ogs� her, du modtager regelm�ssig information om nyheder ang�ende udviklingsarbejdet med SkypeTalking direkte fra kildekodens opbevaringssted p� nettet. Alle sp�rgsm�l er velkomne her, s�vel begyndersp�rgsm�l som sp�rgsm�l om udviklingen.

7.5. Tak til

F�lgende har p� den ene eller anden m�de bidraget til udviklingen af SkypeTalking:
- Hrvoje Kati�, som er hovedmanden bag SkypeTalking-projektet.
- Gianluca Casalino, som har udviklet en r�kke avancerede funktioner til SkypeTalking og har bidraget med en stor arbejdsindsats i programmeringen af SkypeTalking. Takket v�re hans engagement er SkypeTalking blevet endnu bedre end f�r! 
- Ren� Linke, som ogs� i nogen grad bidrager ved at lave rettelser og komme med ideer til nye funktioner.
- Mange supergode mennesker, der har gjort SkypeTalking tilg�ngeligt p� deres eget sprog. Det betyder, at skypeTalking nu taler mere end 15 sprog!
- Og s� naturligvis alle brugerne verden over, der hver dag benytter SkypeTalking og derved er med til at g�re opm�rksom p� programmet, s� stadigt flere kan drage nytte af dette fremragende produkt!
En stor tak til jer alle!!!

7.5. Mine kontaktoplysninger

Min E-Mail adresse til sp�rgsm�l, forslag, support og aflevering af overs�ttelser:  hrvojekatic@gmail.com
Du kan f�lge mig p� Twitter under: www.twitter.com/hkatic
Min side p� Facebook: www.facebook.com/jukebox2009
Mit Klango-Id p� klango.net: DJ_Jukebox
P� MSN er min adresse: hrkatic@hotmail.com
Skype Id: hrvojekatic

Slut p� dokumentet   