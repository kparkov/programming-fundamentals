# Uge 3: lister
Indtil nu har vi kun arbejdet med simple _built-in_ typer (`string`, `ìnt`, `bool`, osv.). Der er i virkeligheden 15 built-in typer i C#, men de fleste bruges sjældent.

Built-in typerne er kendetegnet ved, at de er datatypernes grundstoffer. Når vi denne gang stifter bekendtskab med den første _komplekse type_, er det værd at bemærke, at alle komplekse typer dybest set er opbygget af _built-ins_, hvis vi graver dybt nok.

Vi har arbejdet i konteksten af komplekse typer før. Nøgleordet `class` erklærer en ny, kompleks type. Alle øvelser vi laver foregår i en class ved navn `Program`, som er et eksempel på en kompleks type.

Den første komplekse type vi skal kigge på, er `List`, og man vil med det samme bemærke flere ting i erklæringen, der stikker ud i forhold til en simpel datatype.

## `var` type inference
Indtil nu har vi erklæret variabler ved at starte med datatypen, fx:

```csharp
string president = "Trump";
int age = 20;
bool isAdult = true;
```

Når værdien sættes direkte efter erklæringen (_declaration and assignment_), kan vi starte med ordet `var` i stedet:

```csharp
var president = "Trump";
var age = 20;
var isAdult = true;
```

Resultatet er præcis det samme som før - altså, at den første bliver en `string`, den anden er en `int` og den tredje er en `bool`. Programmet _antager_ typen ud fra den initialiserede værdi. Dette hedder _type inference_. Fordi vi sætter den første linie til en tekst, må variablen jo være en `string`. Fordi den tredje sættes til `true`, må det jo være en `bool`. 

Men hvad med tallet? 

I princippet kunne tallet jo være tænkt som en `decimal`, der bare tilfældigvis ikke starter med nogle decimaler. Men fordi vi giver `20`, vil `age` blive en `int`. Man skal være opmærksom på, at dette er tilfældet, for typen af en variabel kan som bekendt ikke ændres efterfølgende - så når senere forsøger at opdatere med et decimaltal, får man en fejl.

```csharp
var money = 20m;
``` 

Her bruger vi suffix-symbolet `m`, der angiver at tallet er en decimal. Så vil `money` ikke blive misforstået som en `int`. Men så kunne vi næsten lige så godt bare have skrevet `decimal` til at starte med.

`var` er en bekvem genvej nu, men bliver _meget_ bekvem senere i forløbet. Prisen for den højere hastighed er en lidt mindre transparent og mindre læsbar kode.

## Lists and foreach loops

En liste erklæres som typen `List`, men til `List` hører et såkaldt _type-argument_.

Når man laver en liste, skal vi angive hvilken type elementer listen kan indeholde. En liste kan konstrueres til at tage imod enhver type, men alle elementer skal være af den angivne type.

I det følgende erklærer vi en liste, der tager imod `string`'s.

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

foreach (string fruit in fruits) 
{
    string presentation = "In my basket I have: " + fruit;
    Console.WriteLine(presentation);
}

Console.WriteLine("There are currently " + fruits.Count + " fruits in the basket.");
```

Dette resulterer i:

```
In my basket I have: Apple
In my basket I have: Banana
In my basket I have: Pineapple
In my basket I have: Mango
There are currently 4 fruits in the basket.
```


## for loops
## Scopes?
## DOT notation?
## Functions and methods

