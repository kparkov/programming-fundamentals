# Metoder, fortsat

I denne uge laver vi kun øvelser. Metoderne skal lige rodfæstes lidt bedre, før vi er klar til at fortsætte til næste emne.

Vi benytter chancen til at lave en lidt mere kompliceret øvelse, hvor løsningen er åben. Løsningen er ikke nødvendigvis mere kompliceret, end det vi har lavet tidligere, men denne gang starter du med en blinkende cursor i et tomt dokument - og det er en stor udfordring i sig selv.

Der vil være rig mulighed for at skrive metoder, og med anvendelsen vil du med tiden se, hvordan de hjælper til at nedbryde få store, uløselige problemer i mange overskuelige delproblemer.

## Øvelse: SU-satser

Når man skal finde ud af, hvor meget man som studerende er berettiget til at modtage i SU-grundsats, afhænger det af en kombination af uddannelsesniveau, alder, bopæl, dato for uddannelsesstart og eventuel dispensation.

Se kilden her: http://www.su.dk/satser/

Hvis vi tager informationsarkitekturen på den ovenstående side, og oversætter den direkte til et beslutningstræ, ser vi følgende struktur:

### Grundsats beslutningstræ
![](../../res/Grundsatser_SU.svg)

Udover grundsatserne, er der også en husstandsbaseret (forældrenes husstand) tillægsydelse, der gives til den studerende. 

Denne logik leder til en masse specifikke tabeller, **som vi vælger at se bort fra**. For at reducere kompleksiteten, antager vi at:

- Udeboende modtager en fast tillægsydelse på 3.000 kr. pr. md.
- Hjemmeboende modtager en tillægsydelse, der er afgjort ved opslag i følgende tabel:

| Forældrehusstandens indkomst | Tillægsydelse |
|---|---|
| Under 100.000 kr. pr. år | 3.000 kr. pr. md. |
| 100.000 - 299.999 kr. pr. år | 2.000 kr. pr. md. |
| 300.000 - 499.999 kr. pr. år | 1.000 kr. pr. md. |
| 500.000 eller derover | 0 kr. pr. md. |

### Overordnet mål med øvelserne

Det overordnede mål med øvelserne i denne uge er at lave et program henvendt til den studerende, der på en let måde kan indsamle de nødvendige oplysninger, og herefter præsentere grundsats og tillægsydelse.

### Øvelse 1: analyse

Det kræver en meget rutineret udvikler at gå i gang med programmeringen, før vi har en fuld forståelse for problemet og dets idé om, hvor vi vil hen.

Vi skal foretage en indledende analyse, der skal belyse problemet og foreslå en plausibel løsning.

Det kan anbefales enten at besvare følgende spørgsmål i grupper af to, eller at tage noter og tegne:

- Hvilke informationer kan programmet have i forvejen? Hvilke informationer skal vi indhente fra brugeren?
- Hvad skal der i overordnede træk ske i programmet, og i hvilken rækkefølge, for at vi kan løse problemet?
- Kan brugeren give en information, som betyder, at man ikke er SU-berettiget, og at programmet derfor ikke kan fortsætte? Er der situationer, som beslutningstræet ikke har med som muligheder? Hvordan kan vi sikre, at brugeren ikke skal besvare flere spørgsmål, når det er givet, at brugeren er diskvalificeret?
- Kan brugeren give en information, som betyder, at andre spørgsmål bliver ligegyldige, fordi den endelige sats allerede er givet? Kan vi sikre, at de overflødige spørgsmål ikke stilles?
- Hvordan skal spørgsmålene stilles? Hvordan spørger vi ind til f.eks. uddannelsesniveau på en måde, som efterfølgende kan anvendes i programmet? Hvordan sikrer vi, at brugeren ikke kan give svar, som er uventede?
- Repræsenterer SU-styrelsens opstilling af beslutningstræet den "optimale" opstilling? Hvilken konsekvens ville det have for træets form og dybde, hvis den første beslutning var fx alder eller bopæl? (_jeg kender ikke svaret_)
- Forestil dig _den mest behagelige og umisforståelige_ brugeroplevelse vi kan levere. Hvad skal brugeren gøre, og i hvilken rækkefølge? Hvordan kan vi efter dataindsamlingen give brugeren den mest overskuelige præsentation af resultatet?

Med udgangspunkt i dine refleksioner ovenfor kan du tage fat på disse _software-arkitektoniske_ spørgsmål:

- Hvad er den overordnede kontrolstruktur, der styrer programmet? Forventer du at anvende `while` / `if` / `foreach` og på hvilken måde?
- Hvilke processer får vi brug for at gentage, som vi med fordel kan lave metoder til?
- Opstil den detaljerede rækkefølge af ting, der skal ske, hvilke data og datatyper der skal indhentes, og hvordan de skal anvendes.

### Øvelse 2: implementering

Solution: `src\Week 6\SU\SU.sln`

Applikationen skal kodes efter dit design.

**Et godt råd**: Lad være med at begynde at kode den overordnede kontrolstruktur. Start i stedet med at eksperimentere med at lave metoder til de små ting: metoder til at indhente og præsentere data, metoder til at regne udregne totaler, etc.

Det er kombinationen af de små byggesten, der udgør de større moduler. Derfor er den overordnede kontrolstruktur nemmere at se, når man har forberedt byggestenene.