# Metoder

I de tidligere lektioner snusede vi lidt til metoder, idet vi har anvendt fx. `.ToUpper()` på en `string` for at sætte den med kapitæler. Vi skal nu til at skrive vore egne metoder.

Introduktionen af metoder er den første store milepæl i at lære programmering. Metoder bruges nemlig til at tage vores atomare byggesten (variabler, løkker, conditions. osv.) og kombinere dem til større, _genbrugelige_ processer. En udvikler, der kan anvende metoder, har et mere overordnet perspektiv på koden, og kan derfor skrive mere komplekse programmer.

Vi arbejder overordnet med to typer metoder: **subroutines** og **functions**. Subroutines bruges til at inddele vores program i underordnede processer, mens functions bruges til at behandle data på en måde, så vi får en modifikation tilbage (i samme forstand som en matematisk funktion). Delingen mellem de to typer er uformel - der er ikke en sproglig eller syntaktisk adskillelse mellem de to typer.

Vi kender allerede én _subroutine_, nemlig `Main`-metoden, som alle programmer starter med.

## Eksempel

```csharp
using System;

namespace InitialsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Angela Dorothea Merkel";
            string initials = GetInitials(name);

            Console.WriteLine(initials);
            Console.ReadKey();
        }

        public static string GetInitials(string name)
        {
            string result = string.Empty;

            if (string.IsNullOrWhiteSpace(name))
            {
                return result;
            }

            foreach (string word in name.Split(" "))
            {
                result += GetFirstLetterCapitalized(word);
            }

            return result;
        }

        public static string GetFirstLetterCapitalized(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            return input.Substring(0, 1).ToUpper();
        }
    }
}

```

Resultatet i konsollen vil være:

```
ADM
```

Når vi anvender metoden, evalueres værdien ved at køre hele den underordnede kode igennem. Dette betegnes _metodekaldet_.

Den metode, der anvender en anden metode, kalder vi _den kaldende kontekst_ eller _den kaldende metode_.

Den metode, der er kaldes, betegner vi _den kaldte metode_.

Når den kaldte metode er færdig med at køre, fortsætter kørslen fra det punkt i den kaldende metode, hvor kaldet skete. Vi siger, at kaldet er _returneret_.

Hvis metoden har en returværdi, erstatter denne værdi metodekaldet i den kaldende metode efter endt kørsel.

Hvis metoden ikke har en returværdi (`void`), er det en syntaktisk fejl at anvende resultatet.

Den kaldende metode kan ikke tilgå den kaldte metodes variabler, og kaldte metode kan ikke tilgå den kaldende metodes variabler. Man kan kun kommunikere fra den kaldende metode til den kaldte metode via _parametre_. Man kan kun kommunikere fra den kaldte metode til den kaldende metode via _returværdien_. 

Dette er en vigtig komponent i den overordnede egenskab vi kalder **encapsulation**: isolering, adskillelse og modularisering af information i programmet. Encapsulation gør det muligt at vedligeholde meget komplekse softwaresystemer.

## Metodens anatomi

### Placering

En metode lever _sideordnet_ og _på samme niveau_ som andre metoder, _direkte underordnet klassens kodeblok_:

```csharp
public class Program 
{
    public static void Main(string[] args) 
    {
        ...
    }

    public static string MyMethod(string input) 
    {
        ...
    }
}
```

### Signatur

En metode _erklæres_ via en **metodesignatur**, der er en kontrakt med den kaldende kontekst om, hvordan metoden anvendes korrekt.

```csharp
public class Program 
{
    public static void Main(string[] args) 
    {
        ...
    }

    public static string MyMethod(string input)   // <-- dette er signaturlinien
    {
        ...
    }
}
```

Hvis vi beskriver signaturen i abstrakte termer, ser den sådan ud:

```
<access modifier> [optional modifiers] <return type> <method name>([parameters])
{
    ...
}
```

En signatur består af følgende informationer, fra venstre mod højre:

- **Access modifiers**. Anvendes til at angive _hvilke dele af programmet, der kan se og tilgå denne metode_. Der skal altid angives præcis 1. Følgende er dem, vi skal forstå på sigt:
  - `public`: alle dele af programmet kan tilgå metoden.
  - `private`: kun kode i samme klasse kan tilgå metoden.
  - `protected`: andre metoder i samme klasse, samt klasser der _arver_ fra klassen, kan tilgå metoden (_forklares i en senere lektion_).
  - ... plus et par andre, som ikke er relevante for kurset.
- **Optional modifiers**. Anvendes til at modificere metodens adfærd og krav i forskellige dimensioner. Der kan angives nul eller flere. Du skal kun i begrænset omfang forstå optional modifiers; de skaber muligheder, men man kan altid arbejde på en måde, hvor de ikke er nødvendige.
  - `static`: kan anvendes på den statiske kontekst, dvs uden at klassen er _instantieret_ (_forklares i en senere lektion_).
  - `abstract`: skal implementeres i en specialisering (_forklares i en senere lektion_).
  - `sealed`: kan ikke specialiseres yderligere  (_forklares i en senere lektion_).
  - `virtual`: kan specialiseres yderligere  (_forklares i en senere lektion_).
  - `override`: specialiserer en metode, der er erklæret `virtual` i den generelle type  (_forklares i en senere lektion_).
  - ... og en del flere, men kun ovenstående vil blive omtalt i løbet af kurset.
- **Return type**. Hvis der er tale om en funktion, vil metoden _returnere_ noget til den kaldende kontekst. kan være enhver datatype, fx `int`, `string` eller `List<string>`. Hvis metoden **ikke** returnerer noget, hvilket er typisk for subroutines, skrives her `void`. `void` er ikke i sig selv en datatype, men det eksplicitte fravær af en datatype. Der kan kun angives én return type.
- **Method name**: navnet, som _du_ giver metoden. Der skal altid gives ét navn.
- **Parameters**: En eller flere _ordnede_ stykker data, som metoden kræver for at køre. Med "ordnet" menes, at rækkefølgen i parametrene i signaturen skal overholdes, når metoden anvendes fra den kaldende metode.

### Kodeblok

En metodes signatur efterfølges af dens kodeblok. Hvis en metode har en returtype (dvs ikke er void), skal alle tænkelige veje igennem metoden afsluttes med `return <value>`, hvor `value` er et udtryk, der evalueres til den rigtige (angivne datatype).

```csharp
public int ProductOfTwo(int x, int y) 
{
    return x * y;
}
```

Havde vi forsøgt at returnere en `string` i det ovenstående eksempel, ville vi have fået en syntaks-fejl.

```csharp
public bool GetsDiscount(int age, bool isRetired) 
{
    if (isRetired || age <= 12) 
    {
        return true;
    }
}
```

Det ovenstående eksempel er **ikke** gyldigt, fordi der findes en vej, der ikke leder til `return`. Det kan rettes meget nemt:

```csharp
public bool GetsDiscount(int age, bool isRetired) 
{
    return isRetired || age <= 12;
}
```

Hvis typen er `void`, er vi ikke forpligtet til at skrive `return`, da dette er implicit når metoden er kørt færdig. Vi _kan vælge_ at skrive `return` tidligere, hvilket afslutter/afbryder metoden og returner til den kaldende kontekst. I dette tilfælde må vi ikke angive en værdi efter `return`, da metoden ikke må returnere data.

Den følgende metode tager en liste af `string` og et index, og sletter så strengen på den angivne position - men kun hvis det givne index svarer til en position på listen.

```csharp
public void DeleteTodoItem(List<string> todo, int deleteIndex) 
{
    if (deleteIndex < 0 || deleteIndex >= todo.Count) 
    {
        return;
    }

    todo.RemoveAt(deleteIndex);
}
```

### Modularisering gennem generalisering

Lad os betragte det sidste eksempel igen.

```csharp
public void DeleteTodoItem(List<string> todo, int deleteIndex) 
{
    if (deleteIndex < 0 || deleteIndex >= todo.Count) 
    {
        return;
    }

    todo.RemoveAt(deleteIndex);
}
```

Denne metode sletter en todo fra en liste af `string`. Men hvorfor kun todo's? Termen "todo" er overflødig, for metoden kan jo anvendes på alle lister af `string`: en liste af navne, 

En af de store, tidsbesparende styrker ved metoder er, at de generaliserer problemer og derfor løsninger. Når vi erkender problemets generelle natur, kan vi med fordel tilrette løsningen derefter:

```csharp
public void DeleteItem(List<string> list, int deleteIndex) 
{
    if (deleteIndex < 0 || deleteIndex >= list.Count) 
    {
        return;
    }

    list.RemoveAt(deleteIndex);
}
```

## Øvelse 1

Solution: `src\Week 5\ShareTheBill\ShareTheBill.sln`

### 1a. Skriv de 4 metoder

Udfyld kodeblokken for de 4 uvirksomme metoder i `BillSharingApplication.cs`, så programmet opfører sig efter hensigten.

### 1b. Overvejelser

- Da du udfyldte metoden `AskUserForDecimal`, brugte du da `AskUserForText` til at løse den? Hvorfor? Hvorfor ikke?
- Vi kan omskrive `PricePerPerson`, så den tager et antal personer som første parameter, i stedet for en liste af personer. Er det en god idé? Hvorfor? Hvorfor ikke?

## Øvelse 2

Solution: `src\Week 5\MethodBasedTodo\MethodBasedTodo.sln`

Todo-applikationen er omskrevet, så den er opdelt i metoder. Kør applikationen, og brug eventuelt debuggeren til at følge logikken rundt.

Sæt herefter kommentarer over hver metode, og beskriv **1)** hvad metoden gør, **2)** hvad parametrene repræsenterer og **3)** hvad returværdien forventes at repræsentere.