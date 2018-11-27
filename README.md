# OpgaveService C# - PropertyChanged

Her en lille simpel opgave i brugen af hændelser/delegates, som samtidig kan bruges som inspiration ved design af klasser. Opgaven er i sig selv simpel – sørg at et objekt smider en hændelse når en egenskab tilrettes. Det kan bruges til mange ting som eksempelvis log, fejlhåndtering og databinding på brugerflader.

Start med at skabe en konsol app og tilføj en simpel Person-klasse som eksempelvis:

Klassen består af et antal private felter og tilhørende egenskaber (get/set). Du skal nu tilføje en hændelse (event) til klassen kaldet PropertyChanged.

I første omgang kan du bruge den indbyggede EventHandler-delegate, navngive denne PropertyChanged, og blot kalde den med en ny instans af EventArgs hver gang en af egenskaberne ændre sig. Du bør placere kaldet til hændelsen i en privat metode (måske navngivet OnPropertyChangedEventHandler), og så blot kalde den i egenskabernes Set. Test koden i Main som eksempelvis:

```csharp
Person1 p1 = new Person1();
p1.PropertyChanged += (s, e) => Console.WriteLine("Egenskab rettet");
p1.Id = 1;  // skulle gerne resulterer i "Egenskab rettet" på consol
```

Men den indbyggede EventArgs giver ikke mulighed for at oplyse hvilken egenskab der er rettet. Så næste skridt er at skabe en klasse der arver fra EventArgs, og som giver mulighed for at oplyse navnet på egenskaben der er rettet. Det vil kræve en tilretning af OnPropertyChangedEventHandler så der kan angives et navn på egenskaben der tilrettes. Men så bliver følgende kode mulig:

```csharp
Person2 p2 = new Person2();
p2.PropertyChanged += (s, e) => Console.WriteLine("Egenskab " + 
    ((PropertyChangedEventArgs)e).PropertyName + " rettet");
p2.Id = 1;  // skulle gerne resulterer i "Egenskab Id rettet" på consol
```

Det er dog lidt træls at skulle typecaste EventArgs til PropertyChangedEventArgs så sidste skridt må være at skabe sin egen delegate så den kan kaldes med en sender (Object) og den rigtige event (PropertyChangedEventArgs). Så bliver følgende muligt:

```csharp
Person3 p3 = new Person3();
p3.PropertyChanged += (s, e) => Console.WriteLine("Egenskab " +
    e.PropertyName + " rettet");
p3.Id = 1;  // skulle gerne resulterer i "Egenskab Id rettet" på consol
```

Start med at skabe din helt egen PropertyChangedEventHandler, og herefter i stedet bruge den anbefalede og indbyggede EventHandler<> (se evt. løsning).

Når du har fået det hele til at spille kan du se på Microsofts forslag til en ”best-practice” – nemlig implementation af INotifyPropertyChanged (fra System.ComponentModel). Dette interface benyttes blandt andet til databinding i WinForm og WPF applikationer.

I øvrigt er der en del forslag på nettet til en ”PropertyChange” feature – se eksempelvis https://goo.gl/uEPdw. 
