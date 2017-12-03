# Uge 3: lister og objekter
Indtil nu har vi kun arbejdet med simple _built-in_ typer (`string`, `ìnt`, `bool`, osv.). Der er i virkeligheden 15 built-in typer i C#, men de fleste bruges sjældent.

Built-in typerne er kendetegnet ved, at de er datatypernes grundstoffer. Når vi denne gang stifter bekendtskab med den første _komplekse type_, er det værd at bemærke, at alle komplekse typer dybest set er opbygget af _built-ins_, hvis vi graver dybt nok.

Vi har arbejdet i konteksten af komplekse typer før. Nøgleordet `class` erklærer en ny, kompleks type. Alle øvelser vi laver foregår i en class ved navn `Program`, som er et eksempel på en kompleks type.

Den første komplekse type vi skal kigge på, er `List`, og man vil med det samme bemærke flere ting i erklæringen, der stikker ud i forhold til en simpel datatype.

## Indhold

- [Methods and properties](#methods-and-properties)
- [List og foreach loops](#list-og-foreach-loops)

## Methods and properties

Alle datatyper er _objekter_, hvilket betyder, at de har _methods_ og _properties_.

Betragt følgende eksempel:

```csharp
string name = "Donald Trump";
string presentation = "Der er " + name.Length + " tegn i navnet " + name + ".";
```

Resultatet er:

```
Der er 12 tegn i navnet Donald Trump.
```

For at finde strengens længde, refererede vi til en _property_ ved `name`, nemlig `name.Length`. Alle variabler af typen `string` har denne property, og bærer derfor informationen om sin egen længde med sig (bemærk at space også er et tegn - der er jo kun 11 _bogstaver_ i navnet). Det præcise sæt af properties og methods er alene afgjort af datatypen, og alle individuelle tilfælde af datatypen udstiller samme sæt.

På samme måde har alle variabler af typen `List` en property `Count`, der angiver det aktuelle antal elementer i listen.

Når vi skal tilgå properties eller methods, bruger vi punktum efter variablens navn. Punktum betyder, at vi nu vil kigge nærmere på objektets funktionalitet. Det, der følger efter punktum, vil nødvendigvis være en reference til et facet af objektet.

Hvis properties er _egenskaber_ ved objektet, på samme måde som antallet af hjul er en af bilens egenskaber - så er methods _funktioner_, på samme måde som acceleration er en af bilens funktioner.

```csharp
string name = "Vladimir Putin";
string presentation = "LÆNGE LEVE " + name.ToUpper();
```

Dette resulterer i:

```
LÆNGE LEVE VLADIMIR PUTIN
```

Metoden `ToUpper()` _returnerer_ en variant af strengen, der er sat i versaler.

Dette kaldes et _method call_ (metodekald). Hvor henvisning til en property dybest set bare er en variabel der læses, er et method call en kodeblok, der kaldes og eksekveres. Det er en operation.

Methods kan kendes på parentes-sættet, der altid afslutter metodekaldet. At parenteserne i `ToUpper()`-kaldet er tomme, betyder at metoden ikke tager _parametre_.

Metoder, der tager parametre, har en dynamisk adfærd. Betragt følgende eksempel:

```csharp
string name = "Vladimir Putin";
bool correctStart = name.StartsWith("Donald");

if (correctStart) 
{
    Console.WriteLine("Navnet starter med Donald.");
}
else 
{
    Console.WriteLine("Navnet starter ikke med Donald.");
}
```
Dette resulterer i:

```
Navnet starter ikke med Donald.
```

Havde vi i stedet kaldt `name.StartsWith("Vladimir")`, så ville beskeden have været positiv. 

Vi siger, at `StartsWith` er en metode, der tager en parameter af typen `string`. Den _returnerer_ herefter en `bool` (`true` eller `false`), der angiver om variablen starter med den givne parameter.

En method kan sommetider tage _flere_ parametre, og her er rækkefølgen vigtig.

For eksempel:

```csharp
string text = "The quick brown fox jumps over the lazy dog.";
string changed = text.Replace("fox", "bear");
Console.WriteLine(changed);
```

Output:

```
The quick brown bear jumps over the lazy dog.
```

`Replace` er en method, der finder forekomster af den først givne parameter, og skifter dem ud med den anden parameter. Den første parameter er altså teksten vi leder efter. Den anden er teksten, som skal stå i stedet. Bytter vi om på rækkefølgen, ændrer vi også betydningen.

### Flere eksempler på `string` methods

```csharp
string name = "Shinzo Abe";

// Test for occurence of a substring within the string
name.Contains("zo");   // => true
name.Contains("wuut"); // => false

// Like StartsWith, but tests if the string ends with the parameter
name.EndsWith("Abe");  // => true
name.EndsWith("Shin"); // => false

// Set all characters to their lower variant
name.ToLower();        // => shinzo abe

// Find the index (position) of the first occurence of substring within the string
name.IndexOf("Ab");    // => 7
name.IndexOf("Shin");  // => 0
name.IndexOf("wuut");  // => -1

// Find the index (position) of the first occurence of substring starting at a specific index
"Hurra Hurra Hurra!".IndexOf("H", 3);   // => 6
"Hurra Hurra Hurra!".IndexOf("H", 6);   // => 6
"Hurra Hurra Hurra!".IndexOf("H", 7);   // => 12

// Find the index (position) of the last occurence of substring within the string
"ABBA".LastIndexOf("B")  // => 2

// Get a substring from a start index and a count
name.Substring(4, 4);  // => "zo A"

// Split a string into an array of strings by defining a delimiter
name.Split(" ")              // => string[] { "Shinzo", "Abe" }
name.Split(" ").ToList()     // => List<string> { "Shinzo", "Abe" }
```

### Øvelse: manipulation og undersøgelse af `string`s

Solution: `MethodsAndProperties.sln`

Vi skal benytte properties og methods i kombination for at få struktureret information ud af teksterne.

## `List` og `foreach` loops

En liste erklæres som typen `List`, men til `List` hører et såkaldt _type-argument_.

Når man laver en liste, skal vi angive hvilken type elementer listen kan indeholde. En liste kan konstrueres til at tage imod enhver type, men alle elementer skal være af den angivne type.

I det følgende erklærer vi en liste, der tager imod `string`'s. Listen starter med fire frugter. Herefter tilføjer vi en, og fjerner en anden.

```csharp
List<string> fruits = new List<string>() 
{
    "Apple",
    "Orange",
    "Banana",
    "Pineapple"
};

fruits.Add("Mango");
fruits.Remove("Orange");
```

Vi kan herefter benytte en `foreach` loop til at besøge hvert element i koden.

Som vi husker fra sidste gang, er en loop en blok af kode, der kører flere gange. Til forskel fra `while`, der kørte så længe en betingelse var opfyldt, kører `foreach` én gang for hvert element i en liste, og sørger samtidig for, at den centrale variabel skiftes ud med det enkelte element.

```csharp
foreach (string fruit in fruits) 
{
    string presentation = "In my basket I have: " + fruit;
    Console.WriteLine(presentation);
}

Console.WriteLine("There are currently " + fruits.Count + " fruits in the basket.");

Console.WriteLine("The fruit at position 2 is: " + fruits[2]);
```

Dette resulterer i:

```
In my basket I have: Apple
In my basket I have: Banana
In my basket I have: Pineapple
In my basket I have: Mango
There are currently 4 fruits in the basket.
The fruit at position 2 is: Pineapple
```

Inde i `foreach`-blokken peger `fruits` på listen, mens `fruit` er det aktuelle element. Hver gang blokken kører, er `fruit` rykket til det næste element i listen, og ikke overraskende kører blokken, indtil det sidste element er besøgt.

Bemærk, at vi kan tilgå enkelte elementer i listen ved hjælp af et _index_. `fruits` er en liste, og lister kan tage imod et index, hvis vi ønsker direkte adgang til det enkelte element. Index starter altid fra `0`, så det første element er `fruits[0]`, mens det sidste kan findes på `fruits[fruits.Count - 1]`.

### Flere eksempler på `List` methods
```csharp
List<string> fruits = new List<string>() 
{
    "Apple",
    "Orange",
    "Banana",
    "Pineapple"
};

// Test for occurence of an element in the list
fruits.Contains("Banana");       // => true
fruits.Contains("Pair");         // => false

// Find the index (position) of the first occurence of an item
fruits.IndexOf("Orange");        // => 1
fruits.IndexOf("Pineapple");     // => 3
fruits.IndexOf("Ban");           // => -1

// Find the index (position) of the last occurence of an item
fruits.LastIndexOf("Orange");    // => 1

// Sort the elements
fruits.Sort();                   // => [void] (now sorted to Apple, Banana, Orange, Pineapple)

// Reverse the order of the elements
fruits.Reverse();                // => [void] (now sorted to Pineapple, Orange, Banana, Apple)

// Remove all elements from the list
fruits.Clear();                  // => [void]
```

## Afsluttende øvelse: _detaljer følger_