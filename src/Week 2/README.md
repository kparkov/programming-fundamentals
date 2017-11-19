# Uge 2

## Gruppernes eget rum på Github (15 min)

Vi introducerer til en lidt mere solid måde, hvorpå de enkelte grupper kan beholde deres egen kode, mens det samtidig er muligt at opdatere fælleskoden.

- Brugernavne: alle skriver deres Github-brugernavne på den lukkede gruppe på FB, så I kan få skriveadgang.
- Branches og _"update from default branch"_.
- Commit
- Push

## Boolean expressions (30 min)

Når vi anvender relationelle operatorer i et udtryk, bliver udtrykket bool'sk. Det betyder, at resultatet af udtrykket altid bliver `true` eller `false`.

## If then else (30 min)

Den mest basale kontrolstruktur er _if-then-else_-strukturen: **hvis** et bool'sk udtryk er sandt, så skal vi udføre en kodeblok - **ellers** (hvis det er falsk) skal vi udføre en anden kodeblok. _Else_-delen er ikke obligatorisk.

```csharp
int age;

...

if (age > 20) 
{
    // Denne blok kører, hvis age er større end 20.
}
else
{
    // Denne blok kører, hvis age er 20 eller mindre.
}
```

## Arrays og loops (45 min)

Arrays eller _lists_ er en liste af en type gemt under et enkelt navn, og er et helt essentielt værktøj til at arbejde med data på en struktureret måde.

Den naturlige forlængelse af denne konstruktion er en løkke (loop), hvor vi for hvert element _besøger_ elementet med den samme kodestump.

```csharp
var fruits = new List<string> 
{
    "Apple",
    "Banana",
    "Orange"
};

foreach (var fruit in fruits) 
{
    // Denne blok ekserkveres én gang per element - 3 gange i alt
    Console.WriteLine("The basket contains a(n) " + fruit)
}
```