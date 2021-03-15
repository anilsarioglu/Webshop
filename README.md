# Webshop

DotNET academy is een organisatie die young potential developers helpt om hun te liften naar een professioneel niveau, door middel van een extra opleiding na hun schoolcarrière. Hierdoor kunnen ze na de opleiding meteen meedraaien als volwaardige developer in een bedrijf. 

### 1 Kadering project 

De dotNET academy wil **een e-commerce platform** ontwikkelen om zo online hun producten te kunnen managen. In het platform zou een webshop moeten verwerkt worden alsook een admin module.

### 2 Use cases webshop 

#### 2.1 Weergeven van alle beschikbare producten 

De webshop moet een overzicht van alle beschikbare producten kunnen weergegeven op een webpagina, waar men eventueel ook filtering kan op toepassen. 

Dit is een pagina waar alle producten met een beknopte omschrijving zichtbaar zijn (eventueel ook met een foto erbij). Wanneer men doorklikt op een specifiek product dan moet alle gedetailleerde info van het product weergeven worden. 

Een product kan een training zijn bijvoorbeeld ASP.NET MVC. Maar een product kan ook een traject zijn van verschillende cursussen. (Bijvoorbeeld front-end traject → html5/css3, sass/less, javascript, typescript, angular, reactjs, vuejs)

#### 2.2 Bestellen van een product

De producten in de webshop moeten kunnen worden besteld. Het is de bedoeling dat de klant meerdere producten kan bestellen. Hiervoor zouden we een winkelmandje willen implementeren. 

Wanneer men de producten in het winkelmandje besteld/aankoopt, dan is het voor nu (in een eerste fase) ok dat hier nog geen betalingssysteem aan gekoppeld is en dit voorlopig enkel in de database bewaard wordt. 

Men kan een aankoop enkel definitief plaatsen als de klant ingelogd is op het platform. Wanneer iemand een aankoop wil doen en nog geen account heeft, dan moet hij doorverwezen worden naar een pagina waar hij een account kan aanmaken.

#### 2.3 Accountregistratie 

Als gast moet het dus mogelijk zijn om een account aan te maken op het platform. Wanneer de gebruiker een account aanmaakt krijgt hij als eerste stap een email waarin hij een activatie link terug kan terugvinden zodat hij zijn identiteit kan verifiëren. Als hij deze niet activeert kan de gebruiker niet inloggen op het platform. 

#### 2.4 Wachtwoord opnieuw instellen

Het platform moet ook voorzien dat de gebruiker de mogelijkheid heeft om zijn wachtwoord opnieuw in te stellen. In geen enkel geval mag het wachtwoord in plain text bewaard worden of visueel zichtbaar zijn.

#### 2.5 Facturatie + registratie intern platform na aankoop

Wanneer er een aankoop gedaan is moet de klant een factuur ontvangen (.PDF) via e-mail. 

Er moet ook een account aangemaakt worden in ons LMS-systeem (TalentLMS), indien de gebruiker nog geen account heeft op dit platform. De klant ontvangt dus ook een e-mail waarin de login gegevens staan van TalentLMS en ook de producten die hij aangekocht heeft. (in een eerste fase is het ok om de login gegevens zelf te genereren en op te slagen in de database)

TalentLMS is een learning management system waar al onze cursussen verzameld zijn. In dit systeem bepalen we wie toegang krijgt tot welke cursussen.

### 3 Use cases admin gedeelte

#### 3.1 Security

Het platform moet kunnen worden beheerd via een admin module. Deze moet volledig afgeschermd worden achter een login pagina.

De admin module maakt een onderscheid tussen 2 type gebruikers (klant, admin). Hou er rekening mee dat er in de toekomst nog type gebruikers kunnen bijkomen.

#### 3.2 Overzicht aangekochte producten 

De klant moet in de admin module een overzicht kunnen opvragen van zijn aangekochte producten met bijhorende facturen. 

#### 3.3 Beheer producten 

De admin moet alle producten kunnen beheren. (create, read, update) De volgorde waarin de producten zichtbaar zijn op de webpagina zou hier ook aangepast moeten kunnen worden.

#### 3.4 Beheer gebruikers 

De admin moet alle gebruikers kunnen beheren. (create, read, update) 

#### 3.5 Rapportage 

De admin moet een rapportering kunnen opvragen per klant en per product. 

### 4 Overige vereisten en aandachtspunten 
Een vereiste is ook dat het gehele e-commerce platform mobile-friendly is. Probeer zoveel mogelijk te denken aan uitbreidbaarheid. In een later stadium zou het platform nog uitgebreid moeten kunnen worden met andere features.
