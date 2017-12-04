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