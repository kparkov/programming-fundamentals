# Skak

Disse opgaver resulterer i en ret kort stump kode, og er først og fremmest hjernevridere. Du kan vælge at beskrive løsningen i ord eller som kode. Det vanskelige består i at udtænke løsningen, og omsætningen til kode er derfor sekundær. 

Opgaverne bliver betydeligt sværere hen ad vejen.

Inden opgaven er det en god ting at stifte bekendtskab med metoderne `Math.Min` og `Math.Abs`:

#### Math.Min

Givet `x` og `y`, returnerer den mindste af de to.
```csharp
int Math.Min(int x, int y);
```

Eksempel:
```csharp
int x = 10;
int y = 5;
int z = Math.Min(x, y);
// z = 5
```

#### Math.Abs

Vender fortegnet til positivt. Hvis tallet allerede er positivt, gør funktionen ingenting.
```csharp
int Math.Abs(int x);
```

Eksempel:
```csharp
int x = 7;
int y = -3;

int absX = Math.Abs(x);
// absX = 7

int absY = Math.Abs(y);
// absY = 3
```

## Øvelse 1: Tårnet

Forestil dig et skakbræt. Der er et hvidt tårn og én modstanderbrik på pladen. Hvid har tur.

Vi skal finde ud af, om tårnet kan slå modstanderbrikken i næste træk. Vi kender tårnets position og modstanderbrikkens position. Nu ønsker vi at skrive en metode, der returnerer, om modstanderbrikken står i slag.

Vi antager, at spillepladen er inddelt i kolonner og rækker, der er indekseret som 0-7 i begge dimensioner:


| |0|1|2|3|4|5|6|7|
|---|---|---|---|---|---|---|---|---|
|0|||||||||
|1|||||||||
|2|||||||||
|3||♖|||||||
|4|||||||||
|5|||||||||
|6|||||♟||||
|7|||||||||

I det ovenstående eksempel står tårnet i række 3, kolonne 1. Men vi er selvfølgelig interesseret i at løse opgaven for alle tænkelige positioner.

Udfyld metoden, med den allerede definerede signatur:

```csharp
public bool CanRookMoveTo(int currentRow, int currentColumn, int targetRow, int targetColumn) 
{
	// Hvad skal der stå her?
}
```

**NB**: vi antager, at vi altid får valide inputs. De fire parametre vil altid være mellem 0 og 7, og de to sæt vil aldrig være ens (`target` kan ikke være det samme som `current`).

## Øvelse 2: Bonden

Løs samme opgave, men for en hvid bonde, der har tur. Antag, at de hvide bønder startede i række 6, og derfor rykker frem mod række 0.

```csharp
public bool CanPawnMoveTo(int currentRow, int currentColumn, int targetRow, int targetColumn) 
{
	// Hvad skal der stå her?
}
```

## Øvelse 3: Kongen

Nu er det kongens tur.

```csharp
public bool CanKingMoveTo(int currentRow, int currentColumn, int targetRow, int targetColumn) 
{
	// Hvad skal der stå her?
}
```

## Øvelse 4: Hesten

Hesten er måske lidt mere tricky.

```csharp
public bool CanKnightMoveTo(int currentRow, int currentColumn, int targetRow, int targetColumn) 
{
	// Hvad skal der stå her?
}
```

## Øvelse 5: Løberen

Nu bliver det ubehageligt.

```csharp
public bool CanBishopMoveTo(int currentRow, int currentColumn, int targetRow, int targetColumn) 
{
	// Hvad skal der stå her?
}
```

## Øvelse 6: Dronningen

Argh! Men på den anden side: hvis du har klaret den hertil, kan du _helt sikkert_ også klare den sidste.

```csharp
public bool CanQueenMoveTo(int currentRow, int currentColumn, int targetRow, int targetColumn) 
{
	// Hvad skal der stå her?
}
```