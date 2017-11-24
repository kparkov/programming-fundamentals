# Uge 2: control structures

I denne uge slipper vi matematikken, og dykker ned i programmeringens hjerte. Et program kan reagere på forskellige måder på forskellige inputs, og det er det, der giver os illusionen af, at computeren har intelligens.

De strukturer, der giver os mulighed for at tage forskellige beslutninger, kaldes _control structures_ (kontrolstrukturer).

Før vi kan komme i gang, er vi nødt til at tale om _boolean expressions_ (boolske udtryk).

Herefter kigger vi på to af de basale kontrolstrukturer, `if`/`else` og `while`.

## Indhold

- [Boolean expressions](#boolean-expressions)
- [if / else](#if--else)
- [while](#while)
- [Afsluttende øvelse: gæt et tal mellem 1 og 100](#afsluttende-øvelse-gæt-et-tal-mellem-1-og-100)

## Boolean expressions

Når vi anvender relationelle operatorer i et udtryk, bliver udtrykket bool'sk. Det betyder, at resultatet af udtrykket altid bliver `true` eller `false`. Boolean expressions kaldes også _conditions_ eller _tests_, lidt afhængig af konteksten.

Det svarer til et spørgsmål, der starter med "Er". I det følgende spørger vi: "Er alder mindre end 18?" Svaret er naturligt enten sandt eller falsk.

```csharp
int age = 20;

// Let 'isChild' be a bool that equals whether age is less than 18
bool isChild = age < 18;
```

I det ovenstående eksempel vil `isChild` blive `false`.

### Relationelle operatorer

De relationelle operatorer er:

- `age < value`: sandt, hvis `age` er mindre end `value`.
- `age > value`: sandt, hvis `age` er større end `value`.
- `age <= value`: sandt, hvis `age` er mindre end eller lig med `value`.
- `age >= value`: sandt, hvis `age` er større end eller lig med `value`.
- `age == value`: sandt, hvis `age` er præcis lig med `value`.
- `age != value`: sandt, hvis `age` ikke er lig med `value`.

### Datatyper og boolean expressions

I det ovenstående eksempel var både `age` og den sammenlignede værdi af typen `int`, og det er umiddelbart intuitivt, at et tal kan være højere, lavere eller lig med et andet tal. Men faktisk kan mange datatyper være genstand for sammenligning med boolean expressions. Måden de sammenlignes afhænger af typen. Fx vil to variabler af typen `string` blive sammenlignet ud fra alfabetisk sortering: `"A"` er lavere end `"B"`, osv.

Der er dog ingen garanti for, at en sammenligning kan lade sig gøre. Fx er udtrykket `true > "hej"` meningsløst, eller i hvert fald uforudsigeligt.

### AND (`&&`)

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

### OR (`||`)

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

### NOT (`!`)

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

## If / else

Boolean expressions er centrale i programmering, fordi de benyttes i mange _control structures_, hvoraf den mest basale er `if`/`else`.

### If

`if` starter altid med en boolean expression. Hvis betingelsen evalueres til `true`, kører den første kodeblok, og ellers **springes den over**. Vi siger: "Hvis denne betingelse er opfyldt, skal vi køre den tilhørende kodeblok."

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
    // This code block gets executed if age was not 18 or higher.
    Console.WriteLine("Smut, pomfrit.");
}

// Execution will continue on this side unconditionally.
```

### If - Else if - Else

Endelig kan vi lave en længere række af betingelser og blokke, hvor vi kun evaluerer den næste blok, hvis den forrige betingelse ikke blev opfyldt. Vi benytter her konstruktionen `else if`.

```csharp
int age = 17;

if (age >= 18)
{
    // Will run if age is 18 or higher.
    Console.WriteLine("Velkommen!");
}
else if (age == 17)
{
    // Will only run if the first was false, and if age is 17.
    Console.WriteLine("Ikke denne gang, men kig ind igen om et års tid.");
}
else
{
    Console.WriteLine("Du er ikke gammel nok.");
}
```

### Øvelse: _detaljer følger_

## While

En anden meget central kontrolstruktur i programmering er en _loop_ (løkke), der kører den samme kodeblok flere gange.

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

### Øvelse: _detaljer følger_

## Afsluttende øvelse: gæt et tal mellem 1 og 100

Vi skal lave et spil. Computeren tænker på et tilfældigt tal mellem 1 og 100. Spilleren skal gætte tallet.

Spillet bliver ved, så længe tallet ikke er gættet. Når spilleren kommer med et gæt, fortæller computeren, om det næste gæt skal være højere eller lavere.

Spillet slutter, når tallet er gættet. Programmet lykønsker brugeren, når det sker.

**Bonuspoint** hvis man får at vide, hvor mange gæt det krævede, før spillet sluttede.

### Hjælperedskaber

- I har følgende metoder til rådighed, der gør tingene nemmere:
  - `Computer.ThinkOfNumber()`: denne metode giver os et nyt, tilfældigt tal mellem 1 og 100.
  - `User.GetGuess()`: denne metode venter på, at brugeren kommer med et nyt gæt.