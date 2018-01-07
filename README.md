# Grundlæggende programmering i C#

Et grundlæggende kursus i grundlæggende programmering med valg af sproget C# (udtales "*C sharp*"). Sproget er valgt fordi:

- Klassisk i opbygning: det er et meget stringent og eksemplarisk sprog, der lægger sig tæt op ad Java, og er derfor også rimelig tilgængeligt.
- Moderne og opdateret: det følger med tiden, og der er stor efterspørgsel efter programmører, der kan kode i C#.
- All purpose: det benyttes i alle domæner, fra finansielle systemer, over web til spil.
- Gratis: udviklingsværktøjerne er gratis, og sproget er open source.

## Program

- [Lektion 1](src/Week%201/README.md)
- [Lektion 2](src/Week%202/README.md)
- [Lektion 3](src/Week%203/README.md)

## Tutorials

- [Sådan laver du din egen branch i Github Desktop](gd-branching.md)

## Hvad kigger jeg på?

Du kigger lige nu på forsiden af et større kodeprojekt (en mappe med filer), der ligger på Github. Github er en tjeneste, der er vært for softwareprojekter. Alle såkaldte open source projekter er offentligt tilgængelige. Github kan sammenlignes lidt med softwareudviklernes Dropbox: når man lægger nye ændringer op i Github, kan de øvrige udviklere synkronisere deres lokale maskine med Github, hvorefter de får den nyeste version af koden. Githubs standard-adfærd er at vise indholdet af `README.md` fra top-folderen på forsiden, og det er indholdet af den fil du læser.

Når du har læst resten af denne instruktion igennem, kan du navigere rundt i folderstrukturen ovenfor, for at se koden. Målet med instruktionen er, at du skal opsætte en lokal, synkroniseret kopi på din egen maskine.

## Reglerne

1. Man skal medbringe en laptop selv.
1. Vi arbejder kun i Windows. Vælger man alligevel at arbejde på en Mac, vil man ikke få support til udviklingsværktøjet. Bemærk at [Windows kan installeres på Mac](https://support.apple.com/da-dk/HT201468).
1. **Man skal gennemføre forberedelsesvejledningen** nedenfor og konstatere at det virker, inden første gang. Hvis man ikke kan få det til at fungere, skal man give mig besked inden første gang. Giv mig besked i så god tid, at vi kan nå at løse det sammen.
1. Hvis man indser, at man ikke har mod på at følge kurset længere, skal man give besked så hurtigt som muligt.
1. Hvis man er tilfreds med kurset og underviseren efterfølgende, skal man skrive en kommentar, der kan bruges på LinkedIn eller hjemmeside... ;-)

## Forberedelse til første gang

### 1. Installation af Visual Studio Community 2017 

Først skal du downloade og installere [Visual Studio Community 2017](https://www.visualstudio.com/downloads/) på den laptop, du skal anvende. Det er udviklingsværktøjet, som vi skriver den faktiske kode i. Vær sikker på, at du vælger Community-udgaven, som er den gratis version.

Når installationen i starten spørger, hvilke komponenter du ønsker at tilføje, skal du vælge følgende 3:

- Windows > .NET desktop development
- Web & cloud > ASP.NET and web development
- Other toolsets > .NET Core cross-platform development

Hvis du allerede har installeret Visual Studio, og ikke har fået disse tre komponenter med, kan du modificere installationen ved at åbne værktøjet *Visual Studio Installer* og vælge *Modify*.

### 2. Opret en bruger på Github

[Opret nu en bruger](https://github.com/join?source=header-home) på dette site, Github. Hvis du allerede har en bruger, kan du fortsætte til næste punkt.

### 3. Installation af Github Desktop

Download og installér [Github Desktop](https://desktop.github.com/). Github Desktop anvendes til at hente koden fra dette projekt ned til din lokale computer, og til efterfølgende at hente nye versioner, når koden opdateres.

### 4. Hent koden med Github Desktop

Åbn Github Desktop og login. Brug værktøjet til at *klone* dette projekt ud fra den grønne "clone or download" knap ovenfor, til din lokale maskine. Tryk på den grønne knap, og vælg muligheden  "Open in Desktop". Hvis dette ikke virker, kan du kopiere URL'en og anvende URL'en til at sætte ind i Github Desktops dialog-boks til at klone.

Se eventuelt [den officielle dokumentation](https://services.github.com/on-demand/github-desktop/clone-repository-github-desktop).

### 5. Åbn projektet i Visual Studio

Åbn Visual Studio Community og tryk på *open project / solution*. Åbn filen `<projektmappe>\src\Week 1\HelloWorld\HelloWorld.sln`. 

Projektmappen er, hvis du ikke selv valgte en lokation, i mappen "Github" i din Dokumenter-mappe. Tryk F5 eller tryk på det grønne play-tegn, når projektet er åbent.

Hvis du ser en opmuntrende besked, er alt korrekt opsat.