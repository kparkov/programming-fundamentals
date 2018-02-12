# Tips & Tricks

I forberedelsen til den sidste gang, lapper vi en række mindre huller undervejs. Disse tips og tricks er ting, som man for det meste kan opnå ad anden vej, men som alligevel er virkelig nyttige genveje.

## `for`-loop

Vi har mange gange set følgende konstruktion med en `while`-loop:

```csharp
int counter = 0;

while (counter < 10) 
{
    // Do something

    counter += 1;
}
```

Netop fordi vi ser den så ofte, findes der en anden type loop, der er designet til at fungere specifikt sådan, nemlig `for`.

```csharp
for (int i = 0; i < 10; i++) 
{
    // Do something
}
```

Den samler de tre hovedoperationer i en enkelt linie:

1. Initialisering af en tæller.
2. Kriteriet for, hvornår løkken skal køre en gang til.
3. Manipulation af tælleren inden løkkens afslutning.

```csharp
for (initialization; condition; iteration)
{
    ...
}
```

Vi kan bruge `for`, når løkken er baseret på en counter.

Vi bør i almindelighed foretrække `foreach`, når vi skal køre løkken én gang for hvert element i en liste. _Dog undtaget_ er de tilfælde, hvor vi _både_ har brug for elementet **og** dets position i listen, inde i blokken:

```csharp
var list = new List<string> { "Orange", "Apple", "Banana" };

for (int i = 0; i < list.Count; i++) 
{
    Console.WriteLine(list[i] + " can be found on index " + i + ".");
}
```

Dette resulterer i:

```
Orange can be found on index 0.
Apple can be found on index 1.
Banana can be found on index 2.
```

Dette vil man ikke kunne opnå på elegant vis med en `foreach`. Til gengæld er det rimelig sjældent, at vi har brug for indekset sammen med elementet.

Man bør foretrække `while` frem for de to andre typer, når man ikke har nogen fast idé om antallet af gange løkken kommer til at køre. Her er betingelsen ikke baseret på en tæller, men et andet bool'sk udtryk. Sådan et tilfælde har vi i vores Gladiator-spil, hvor kampen skal fortsætte så længe begge gladiatorer har et positivt antalt hit points. Vi kan ikke spå om, hvor mange ture i løkken der skal til, før betingelsen bliver negativ.

## Dictionary

Ofte har vi brug for en liste, hvor indekset ikke er en position i listen, men snarere en meningsfuld _nøgle_. En nøgle er en **kort og unik værdi, der entydigt peger på en identitet**.

I den virkelige verden er CPR-nummeret en nøgle. I programmering giver vi ofte objekter tilfældige eller fortløbende id-numre, så vi hurtigt kan tjekke deres identitet.

`Dictionary` kan bruges til at sammenkoble en unik nøgle på venstre side med en (ikke nødvendigvis unik, men entydig) værdi på højre side:

```sharp
var cardNames = new Dictionary<int, string>();
```

Her laver vi et nyt `Dictionary`, og med type-argumenterne angiver vi, at vores nøgler er `int`, mens vores værdier er `string`.

```csharp
cardNames.Add(1, "Ace");
cardNames.Add(2, "2");
cardNames.Add(3, "3");
cardNames.Add(4, "4");
cardNames.Add(5, "5");
cardNames.Add(6, "6");
cardNames.Add(7, "7");
cardNames.Add(8, "8");
cardNames.Add(9, "9");
cardNames.Add(10, "10");
cardNames.Add(11, "Jack");
cardNames.Add(12, "Queen");
cardNames.Add(13, "King");
```

Dette `Dictionary` har til formål at give os _navnet_ på et spillekort ud fra _den numeriske værdi_.

Hvis vi har den numeriske værdi, kan vi finde navnet:

```csharp
int value = 12;
string name = cardNames[value];
Console.WriteLine(name);
```

Hvilket ikke overraskende giver:

```
Queen
```

Det er værd at bemærke at:

- Et forsøg på at tilføje den samme nøgle flere gange vil fejle. Dog må den samme værdi gerne optræde flere gange.
- Et forsøg på at hente en ikke-eksisterende nøgle vil fejle. Man kan dog tjekke først, om nøglen eksisterer med `.ContainsKey(TKey key)`.
- Et `Dictionary` bruges til at lave opslag fra nøgle til værdi, og det er ikke en triviel eller billig operation at lave opslag den anden vej - bl.a. fordi værdierne på værdi-siden ikke forventes at være unikke.

Man kan godt bruge `foreach` på et `Dictionary`, men hvert element vil være af typen `KeyValuePair<TKey, TValue>`, og man kan på dette tilgå nøglen på `.Key` og værdien på `.Value`. Ønsker man kun at iterere over værdierne, kan man benytte:

```csharp
foreach (string cardName in cardNames.Values)
{
    ...
}
```

Somme tider ønsker man kun at iterere over nøglerne (dog sjældent):

```csharp
foreach (int cardValue in cardNames.Keys)
{
    ...
}
```

## Enums og casting

En enum er et defineret, endeligt sæt af konstanter underliggende `int`-værdier. Sommetider er vi interesseret i at repræsentere et valg som en begrænset liste. Uden enums ville vi have en tendens til at repræsentere disse valg med en `int` eller en `string`, og herefter acceptere, at den bagvedliggende konceptualisering ikke er formaliseret i programmet.

F.eks. så vi i SU-udregningsopgaven, at en person kan være hjemmeboende eller udeboende. Dette valg blev repræsenteret ved 1 eller 2. 

Det første problem ved denne metode er, at vi i programmet kunne sende værdien 3 (fordi det er en valid værdi for `int`), men det ville logisk set være meningsløst i forhold til repræsentationen.

Det næste problem er, at vi som programmører har besluttet, at 1 er hjemmeboende, og 2 er udeboende - men det skal vi selv holde styr på overalt i programmet. Det inviterer til, at vi kommer til at bytte rundt på dem.

Løsningen er `enum`, som er simple **typer** på samme niveau som `class`:

```csharp
public enum ResidenceStatus
{
    WithParents,
    MovedOut
}
```

Da ovenstående er en type, kan vi begrænse mulighedsrummet i fx en metode:

```csharp
public decimal CalculateRate(ResidenceStatus status, int age)
{
    if (status == ResidenceStatus.WithParents) 
    {
        ...
    }
}
```

Dette betyder, at **1)** vi har en formaliseret struktur, der indeholder vores mulighedsrum, så compileren fejler, hvis vi angiver en ikke-eksisterende værdi og **2)** vi skal ikke længere huske på, hvilke værdier der svarer til hvad.

Men hvad så med brugerindtastningen? Brugeren indtaster "1" for hjemmeboende, så hvordan bliver det til en `ResidenceStatus`?

Enum-værdier _er som standard tilknyttet_ `int`-værdier. Vi kan vælge at tilknytte hver nøgle en specifik int-værdi, ellers sker det automatisk. Det følgende eksempel vil resultere i præcis samme kode:

```csharp
public enum ResidenceStatus
{
    WithParents = 0,
    MovedOut = 1
}
```

Eftersom en variabel med en enum-type vil have `default`-værdien `0`, skal man være forsigtig med at lade 0-nøglen være en værdi, der ikke har karakter af at være "standard".

Lad os ændre lidt på vores definition:

```csharp
public enum ResidenceStatus
{
    Unknown = 0,
    WithParents = 1,
    MovedOut = 2
}
```

Det er generelt en fornuftig disposition at indføre en _ukendt/uafgjort_ værdi i en enum.

Fordi en enum-værdi er en `int`, kan der _castes_ imellem de to typer:

```csharp
int x = 1;
ResidenceStatus currentResidence = (ResidenceStatus) x;
int backToInt = (int) currentResidence;
```

Casting er et stort og kompliceret emne, men for nu kan vi sige, at det beder kompileren om at returnere værdien under en ny type. Det _vil kun lykkes, hvis de to typer er konvertérabare imellem hinanden_. Fx kan vi ikke caste en `string` til en `int` - her benytter vi i stedet en metode til det, `int.Parse(string)`.

Med disse informationer kan vi skrive en metode, der indhenter valget, angivet som et tal, og returnerer det som `ResidenceStatus`:

```csharp
public ResidenceStatus AskUserResidenceStatus() 
{
    string userInput = Console.ReadLine();
    int inputAsInt = int.Parse(userInput);
    return (ResidenceStatus) inputAsInt;
}
```