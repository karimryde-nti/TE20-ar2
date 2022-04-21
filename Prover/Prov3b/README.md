# prov-3b

Programmet ska skriva ut en lista med namn som är lika långa eller kortare än en siffran du anger.  
I terminalen kan man köra **Prov3b.exe** för att se hur programmet är tänkt att fungera.

## Hjälp till provet
### Tillåtet
* Allt du arbetat med på lektionstid
* [C# referens](https://krank23.gitbook.io/csharp-ref)
* [Progsharp.se](https://progsharp.se)

### Ej tillåtet
Hjälp under provets gång från någon annan än lärare.  
Alla chattprogram och liknande (Discord, Steam, etc) ska stängas av innan provet börjar. Liksom alla webbläsarflikar med sociala medier.

## Uppgiftsbeskrivning
Du ska skriva ett program där användaren kan skriva in en siffra, och sedan få se en lista med namn som är lika långa eller kortare än vad siffran anger. Ledtråd: kom ihåg att man kan undersöka hur lång en string är genom att använda **.Length**.
### Del 1
* Ha en **lista** eller en **array** med följande namn:  
    "Andorra", 
    "Afghanistan", 
    "Antigua och Barbuda",
    "Bulgarien",
    "Vitryssland", 
    "Benin", 
    "Chile", 
    "Kina", 
    "Dominikanska republiken",
    "Eritrea",
    "Indonesien",
    "Kirgizistan",
    "Liechtenstein",
    "Madagaskar",
    "Papua Nya Guinea"
* Låt användaren skriva in en siffra som ska vara **minst 4** och som mest lika mycket som det **längsta namnet**.
* **Skriv ut** de namn i listan som har färre bokstäver än siffran, eller lika många. 
* Programmet frågar om användaren vill köra en omgång till
* Skriv **kommentarer** och se till så att alla variabler är korrekt döpta enligt C#-standard.
* Använd en vettig metod, som anropas direkt i Program.cs.
### Del 2
* Hitta längden på **kortaste namnet** och **längsta namnet** programmatiskt.
* Användaren får bara mata in en längd mellan **kortaste namnet** och **längsta namnet**.
* Dela upp koden i flera genomtänkta metoder.
* Läs in listan på namn från en textfil.

Relevans för spel: Samma princip kan användas för att till exempel sortera ut alla fiender som har under 25% hp kvar, eller alla items i en butik spelaren har råd med, eller alla rustningar spelaren är stark nog att bära.

## Vad som bedöms
* Enstaka, korta kommentarer
* Flera variabler olika datatyp
* Som löser problem
* Minst en if-sats och en loop
* Inlämning i tid
* Inga syntaxfel
* Konsekvent namngivning
* C#-standard
* Pseudokod
* Kraschar inte vid fel input
* Begripligt gränssnitt
* En enkel algoritm (kombination av if-satser och loopar som gör något)
* Minst en array/lista
* Minst en fungerande metod som anropas från koden i Program.cs
