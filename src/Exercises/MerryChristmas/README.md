# Øvelse: Merry Christmas

## Inden vi går i gang

Vi har i mange øvelser brugt `Console.WriteLine(string text)`:

```csharp
string name = "Santa";
Console.WriteLine(name);
Console.WriteLine(name);
```

Denne metode skriver udtrykket til konsollen _og afslutter med et linieskift_:

```
Santa
Santa
```

Der findes også en anden variant, der **ikke** afslutter med et linieskift, nemlig `Console.Write(string text)`:

```csharp
string name = "Santa";
Console.Write(name);
Console.Write(name);
```

Dette står på denne måde:

```
SantaSanta
```

## Øvelsen

Solution: `src\Exercises\MerryChristmas\MerryChristmas.sln`

I denne øvelse skal vi konstruere julemandens hilsen.

Der er erklæret 5 variabler på forhånd, og du skal forsøge at **undgå at lave nye string-variabler** i alle øvelserne.

```csharp
string laugh = "ho";
string hyphen = "-";
string greeting = "Merry christmas";
string exclamation = "!";
int hoCount = 3;
```

### Opgave 1

Vi ønsker at udskrive en julehilsen til konsollen, således at den indledende latter tilsvarer den værdi, vi har sat i `hoCount`. Hvis vi sætter `hoCount` til `3`, skal beskeden være:

```
ho ho ho Merry christmas
```

### Opgave 2

Vi ønsker nu at justere teksten en smule, så vi får lidt tryk på udsagnet. Den skal nu udskrive:

```
HO HO HO MERRY CHRISTMAS!
```

### Opgave 3

Til afslutning vil vi gerne have det til at stå helt rigtigt, for der skal jo bindestreg _mellem_ de enkelte "ho", men ikke før eller efter:

```
HO-HO-HO MERRY CHRISTMAS!
```