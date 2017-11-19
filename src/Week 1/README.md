# Uge 1

## Introduktion (20 min)

- Målsætning
- Præsentationsrunde
- Form
  - _Anvendelsesorienteret_: teori og historie kun i det omfang, at det er absolut nødvendigt.
  - Overbliksprægede introduktioner (~30-40%)
  - Masser af øvelser (~60-70%)
  - Afbryd og stil spørgsmål **løbende** - vent **ikke** til sidst.
- Læringskurven
- Status på udviklingsmiljø

## Github (20 min)

- Brugernavne: alle skriver deres Github-brugernavne på den lukkede gruppe på FB, så I kan få skriveadgang.
- Git og Github: en minimal survival guide.
- Hver gruppe gemmer deres øvelser i en separat _branch_.

## Programmeringen begynder

### Editor, projektstruktur og syntaks (20 min)

- Solution og projekt: Visual Studios organisation af kode.
- Logik og erklæring: 
- `Namespace -> Class -> Method -> Logic`
```csharp
using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            // Her skriver vi den egentlige logik.
        }
    }
}
```

- `static void Main(string[] args)`: stedet, hvor et program starter.
- Scope: Et sæt af tuborgklammer `{...}` definerer et _scope_ - en markering af, hvor meget den førkommende instruktion omfatter, og samtidig et privat rum for variabler.

```csharp
static void Main(string[] args) 
{
    // Main starter ved den ovenstående tuborgklamme.
    // Alt hvad der sker her, er kun synligt for Main.
    // Men Main kan se og anvende alt, hvad der sker i niveauet ovenover.
    // Main slutter ved den følgende tuborgklamme.
}
```
- Execution flow: Vi kører fra toppen og ned, indtil vi støder på et punkt, der flytter os til en underordnet del af koden. Så kører denne færdig, hvorefter vi vender tilbage til det sted vi slap. Når vi er ved bunden af `Main`, stopper programmet.


### Variabler (50 min)

I det imperative programmeringsparadigme anskuer vi programmet og maskinen som en tilstand, der ved applicering af en transformativ logik bringes i en ny tilstand. Atomet for denne tilstand er variablen.

En variabel er en navngivet kasse i hukommelsen, hvor vi kan gemme en værdi til senere brug og manipulation.

- En variabel _erklæres_ (declaration) altid med en type og et navn.
```csharp
int x;
```

- En variabel kan _initialiseres_ til en værdi (literal value) eller et udtryk (expression) i samme ombæring.
```csharp
int x = 7;
int y = 10 + 8;
```

- Et udtryk er en kombination af værdier, variabler og operatorer, der kan evalueres til en enkelt værdi.
```csharp
double pi = 3.1415;
double radius = 7;
double circumference = 2 * radius * pi;
```

- Der er et udvalg af primitive typer, hvoraf vi fokuserer på `string` (tekst), `int` (heltal), `bool` (sandt/falsk), `double` (decimaltal med flydende decimaler) og `decimal` (decimaltal med faste decimaler).
```csharp
string president = "Vladimir Putin";
int birthyear = 1985;
bool doorIsOpen = true;
double pi = 3.1415;
decimal balance = 1275.50m;
```

- En variabel kan opdateres efter erklæring.
```csharp
int x = 0;
int y = 5;
int z = 10;

x = y + z;
```

### Afrunding

- Repetitionsøvelser. I kan løse dem nu eller til næste gang.
- Førstehåndsindtryk: er formen i orden?