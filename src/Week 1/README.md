# Uge 1

## Introduktion (20 min)

- Målsætning
- Form
  - Overbliksprægede introduktioner (~30-40%)
  - Masser af øvelser (~60-70%)
  - **Afbryd og stil spørgsmål med det samme**
- At bryde igennem muren
- Præsentationsrunde
- Status på udviklingsmiljø

## Kode

### Github (15 min)

- Brugernavne: alle skriver deres brugernavne på den lukkede gruppe på FB, så I kan få skriveadgang.
- Git og Github: en minimal survival guide

### Editoren og projektstruktur (15 min)

- Solution og projekt: Visual Studios organisation af kode.
- Logik og erklæring: 
- `Namespace -> Class -> Method -> Logic`
- `static void Main(string[] args)`: stedet, hvor det hele starter.

### Variabler (40 min)

I det imperative programmeringsparadigme anskuer vi programmet og maskinen som en tilstand, der ved applicering af en transformativ logik bringes i en ny tilstand. Atomet for denne tilstand er variablen.

En variabel er en navngivet kasse i hukommelsen, hvor vi kan gemme en værdi til senere brug og manipulation.

- En variabel _erklæres_ (declaration) altid med en type og et navn.
```csharp
int x;
```

- En variabel kan initialiseres til en værdi eller et udtryk.
```csharp
int x = 7;
int y = 10 + 8;
```

- Et udtryk (expression) er en kombination af værdier, variabler og operatorer, der kan evalueres til en enkelt værdi.
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

### Boolean expressions (20 min)

- Boolean expressions
- If then else