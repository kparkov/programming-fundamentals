# Uge 2: control structures

> "I believe myself to possess a most singular combination of qualities exactly fitted to make me pre-eminently a discoverer of the hidden realities of nature."  
>
> Ada Lovelace (1815 - 1852), verdens første programmør 

I denne uge slipper vi matematikken, og dykker ned i programmeringens hjerte. Et program kan reagere på forskellige måder på forskellige inputs, og det er det, der kan give os opfattelsen af en intelligent respons.

De strukturer, der giver os mulighed for at tage forskellige beslutninger, kaldes _control structures_ (kontrolstrukturer).

Før vi kan komme i gang, er vi nødt til at tale om _boolean expressions_ (boolske udtryk).

Herefter kigger vi på to af de basale kontrolstrukturer, `if`/`else` og `while`.

## Indhold

- [Boolean expressions](#boolean-expressions)
- [if / else](#if--else)
- [while](#while)
- [Afsluttende øvelse: gæt et tal mellem 1 og 100](#afsluttende-øvelse-gæt-et-tal-mellem-1-og-100)

## Boolean expressions

Boolean expressions bruges til at vurdere, om en bestemt betingelse er opfyldt. Når vi ved, om betingelsen er opfyldt, ved vi om vi skal fortsætte ad den ene eller den anden vej.

Vi kan spørge, om to værdier er _lig hinanden_, _forskellige fra hinanden_, om det _første er større end det andet_, osv. Dette kaldes de **relationelle operatorer**. 

Vi kan også sammensætte flere af denne type tests ved hjælp af **de logiske operatorer** (AND, OR og NOT).

Boolean expressions kaldes også _conditions_ eller _tests_, lidt afhængig af konteksten, og resultatet af en boolean expression er **altid** en `bool` (`true` eller `false`).

### Relationelle operatorer

De relationelle operatorer sammenligner to værdier for ækvivalens, større end og mindre end.

Det svarer til et spørgsmål, der starter med "Er". I det følgende spørger vi: "Er alder mindre end 18?" Svaret er naturligt enten sandt eller falsk.

```csharp
int age = 20;

// Let 'isChild' be a bool that equals whether age is less than 18
bool isChild = age < 18;
```

I det ovenstående eksempel vil `isChild` blive evalueret til `false`.

De relationelle operatorer er:

- `age < value`: sandt, hvis `age` er mindre end `value`.
- `age > value`: sandt, hvis `age` er større end `value`.
- `age <= value`: sandt, hvis `age` er mindre end eller lig med `value`.
- `age >= value`: sandt, hvis `age` er større end eller lig med `value`.
- `age == value`: sandt, hvis `age` er præcis lig med `value`.
- `age != value`: sandt, hvis `age` ikke er lig med `value`.

#### Datatyper og relationelle operatorer

I det ovenstående eksempel var både `age` og den sammenlignede værdi af typen `int`, og det er umiddelbart intuitivt, at et tal kan være højere, lavere eller lig med et andet tal. 

Men faktisk kan mange datatyper være genstand for sammenligning med boolean expressions. Måden de sammenlignes afhænger af typen. Fx vil to variabler af typen `string` blive sammenlignet ud fra alfabetisk (leksikografisk) sortering: `"A"` er lavere end `"B"`, osv.

Der er dog ingen garanti for, at en sammenligning kan lade sig gøre. Fx er udtrykket `true > "hej"` meningsløst, eller i hvert fald uforudsigeligt.

### Logiske operatorer (AND, OR og NOT)

#### AND (`&&`)

Vi kan med den logiske operator `&&` (AND) sammenstille to boolske udtryk for at sige, at to forskellige betingelser skal være opfyldt samtidig. Hvis ét af de to udsagn er `false`, vil hele udsagnet blive `false`. Dette kaldes også en _conjunction_ (konjunktion):

```csharp
int age = 20;
decimal money = 45m;

int alcoholMinimumAge = 18;
decimal beerPrice = 50m;

// will be true only if both sides of the && are true
bool canBuyBeer = age >= alcoholMinimumAge && money >= beerPrice;
```

Det følgende er ikke kode, men et forsøg på at beskrive, hvordan programmet reducerer udsagnet for at finde den endelige værdi:

```csharp
bool canBuyBeer = age >= alcoholMinimumAge && money >= beerPrice;
                = 20 >= 18 && money >= beerPrice;
                = true && money >= beerPrice;
                = true && 45m >= 50m;
                = true && false;
                = false;

// No beer for you: you had the right age, but not enough money. :-(
```

#### OR (`||`)

Vi kan benytte `||` (OR) til at sige, at udsagnet skal blive sandt, hvis mindst én af de to betingelser er sandt. Dette kaldes også en _disjunction_ (disjunktion):

```csharp
// In the bus, there is a price reduction for children and retired people.
int age = 82;
int childTicketMaxAge = 13;
int retiredTicketMinAge = 65;

// Will be true if either side of the || are true
bool getsPriceReduction = age <= childTicketMaxAge || age >= retiredTicketMinAge;
```

Det følgende er ikke kode, men et forsøg på at beskrive, hvordan programmet reducerer udsagnet for at finde den endelige værdi:

```csharp
bool getsPriceReduction = age <= childTicketMaxAge || age >= retiredTicketMinAge;
                        = 82 <= 13 || age >= retiredTicketMinAge;
                        = false || age >= retiredTicketMinAge;
                        = false || 82 >= 65;
                        = false || true;
                        = true;

// Yay, you can get a price reduction.
```

#### NOT (`!`)

Endelig kan vi altid vende en boolean på hovedet ved at bruge `!` (NOT) operatoren. Når vi vender den, bliver `true` til `false` og `false` til `true`:

```csharp
int age = 20;

bool isChild = age < 18;
bool isAdult = !isChild;
```

Vi kan også benytte NOT på hele udtrykket i stedet:

```csharp
int age = 20;

bool isAdult = !(age < 18);
```

### Et længere eksempel

```csharp
int age = 16;
decimal money = 20;

bool isChild = age < 18;
bool isAdult = !isChild;
bool isRetirementAge = age >= 65;
bool isWorkingAge = isAdult && !isRetirementAge;

bool getsDiscountInTheBus = isChild || isRetirementAge;

decimal ticketPrice = 25;
decimal reducedTicketPrice = 15;

bool canRideTheBus = money >= ticketPrice || (getsDiscountInTheBus && money >= reducedTicketPrice);
```

### Øvelse: Adgangskrav i Tivoli

Solution: `BooleanExpressions.sln`

Vi skal skrive en boolean expression for hver af forlystelserne, der evaluerer, om den beskrevne kunde må prøve forlystelsen. Kunden har en alder (`customerAge`), en højde (`customerHeight`) og en vægt (`customerWeight`).

Hver af forlystelserne har et adgangskrav, der er beskrevet i kommentarerne.

Fx:

```csharp
// To try Grøften, you must be at least 3 years old and weigh between 5 and 600 kg.
```

En gyldig besvarelse på ovenstående ville være:

```csharp
bool canTryGrøften = customerAge >= 3 && customerWeight >= 5 && customerWeight <= 600;
```

## If / else

Boolean expressions er centrale i programmering, fordi de benyttes i mange _control structures_, hvoraf den mest basale er `if`/`else`.

### If

`if` starter altid med en boolean expression. Hvis betingelsen evalueres til `true`, kører den tilhørende kodeblok, og ellers **springes den over**. Vi siger: "Hvis denne betingelse er opfyldt, skal vi køre den tilhørende kodeblok."

```csharp
int age = 21;

if (age > 20)
{
    // This code block gets executed if age was higher than 20.
    Console.WriteLine("Du er gammel nok.");
}

// Execution will continue on this side unconditionally.
```

### Else

`else` supplerer et `if`-udsagn med en udvidet logik: "hvis denne betingelse er opfyldt, så gør dette, **ellers** skal du i stedet gøre dette".

```csharp
int age = 12;

if (age >= 18)
{
    // This code block gets executed if age was 18 or higher.
    Console.WriteLine("Velkommen til.");
}
else
{
    // This code block gets executed if the first block did not.
    Console.WriteLine("Smut, pomfrit.");
}

// Execution will continue on this side unconditionally.
```

### If - Else if - Else

Når programmet forgrener sig, er det ikke altid tilstrækkeligt med to grene. Nogle gange er der flere mulige udfald.

`if/else`-konstruktionen kan udvides til at gennemløbe en serie af tests, hvoraf der kun kan være et positivt udfald. Til dette bruger vi `else if` blokke, der ligger imellem `if` og `else`.

Der er ved at blive åbnet op for, at man kan begynde at tage kørekort som 17-årig, men man må ikke køre alene før man er fyldt 18. Dette udmunder i tre scenarier:

```csharp
int age = 17;

bool canTakeDriversLicense;
bool canDriveAlone;

if (age >= 18)
{
    // Will run if age is 18 or higher.
    Console.WriteLine("Du kan tage kørekort.");

    canTakeDriversLicense = true;
    canDriveAlone = true;
}
else if (age == 17)
{
    // Will only run if the first did not, and if age is 17.
    Console.WriteLine("Du kan begynde at tage kørekort, men må ikke køre alene endnu.");

    canTakeDriversLicense = true;
    canDriveAlone = false;
}
else
{
    // Will run only if no other block ran
    Console.WriteLine("Du må vente.");

    canTakeDriversLicense = false;
    canDriveAlone = false;
}
```

Bemærk, at det kun er den første blok med positiv betingelse, der kører, selvom en senere blok også ville producere en positiv betingelse. _Rækkefølgen_ af de enkelte led i `if`/`else if`/`else` bliver dermed vigtig.

### Øvelse: bliver vi lukket ind i biffen?

Solution: `IfElse.sln`

En øvelse i to dele, hvor man først skal tjekke, om alle krav er opfyldt for at se filmen. 

Herefter ønsker vi at give detaljeret feedback, hvis kravene ikke er opfyldt, og fortælle brugeren, hvilke krav der ikke er opfyldt.

## While

En anden meget central kontrolstruktur i programmering er en _loop_ (løkke), der gentager den samme kodeblok, så længe det er nødvendigt.

Den mest basale form for loop er `while`, der benytter en boolean expression. Så længe denne expression er `true`, vil løkken køre igen.

```csharp
int counter = 0;

while (counter < 5) 
{
    // The code inside this block will run repeatedly.
    Console.WriteLine("Vi kører en tur. Tæller: " + counter);
    counter = counter + 1;
}

Console.WriteLine("SLUT! Tælleren er nu: " + counter);
```

Denne kode vil resultere i følgende output i terminalen:

```
Vi kører en tur. Tæller: 0
Vi kører en tur. Tæller: 1
Vi kører en tur. Tæller: 2
Vi kører en tur. Tæller: 3
Vi kører en tur. Tæller: 4
SLUT! Tælleren er nu: 5
```

Bemærk, at der lægges 1 til `counter` lige før blokkens slutning, så når den får værdien 5, er udtrykket `counter < 5` ikke længere sandt. 

Betingelsen tjekkes altid umiddelbart inden blokken kører igen, så den kører ikke en omgang med værdien 5 i `counter`.

## Afsluttende øvelse: gæt et tal mellem 1 og 100

Solution: `GuessingGame.sln`

Vi skal lave et spil. Computeren tænker på et tilfældigt tal mellem 1 og 100. Spilleren skal gætte tallet.

Spillet bliver ved, så længe tallet ikke er gættet. Når spilleren kommer med et gæt, fortæller computeren, om det næste gæt skal være højere eller lavere.

Spillet slutter, når tallet er gættet. Programmet lykønsker brugeren, når det sker.

**Bonuspoint** hvis man får at vide, hvor mange gæt det krævede, før spillet sluttede.

### Hjælperedskaber

- I har følgende metoder til rådighed, der gør tingene nemmere:
  - `Computer.ThinkOfNumber()`: denne metode giver os et nyt, tilfældigt tal mellem 1 og 100.
  - `User.GetGuess()`: denne metode venter på, at brugeren kommer med et nyt gæt.