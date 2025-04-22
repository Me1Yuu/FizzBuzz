//Erstellen Sie einen Algorithmus der das Spiel FizzBuzz bis zur 100 durchführt.
//Regeln siehe https://de.wikipedia.org/wiki/Fizz_buzz.

//Modulo gibt uns den Rest einer Division als Ganzzahl zurück. Das Zeichen für den Operanten ist %
//Beispiel: 4 % 2 = 0
//Bitte selbst Recherchieren
int fizz = 0;
int buzz = 0;
int fizzBuzz = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)//dieser code prüft ob die variable i durch 3 oder 5 teilbar ist und ohne Rest abgibt. 
    {
        Console.WriteLine("FizzBuzz");
        fizzBuzz++;
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
        fizz++;
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
        buzz++;
    }
    else
    {
        Console.WriteLine(i);
    }

    Thread.Sleep(100);

    if (i == 100)
    {
        Console.WriteLine("\nTotale Anzahl an Fizz: " + fizz);
        Console.WriteLine("Totale Anzahl an Buzz: " + buzz);
        Console.WriteLine("Totale Anzahl an FizzBuzz: " + fizzBuzz);
    }
}




//LÖSUNG von Fabian

//for (int i = 1; i <= 100; i++)
//{
//    if(i % 15 == 0)
//        Console.WriteLine("FizzBuzz");
//    else if(i % 3 == 0)
//        Console.WriteLine("Fizz");
//    else if(i % 5 == 0)
//        Console.WriteLine("Buzz");
//    else
//        Console.WriteLine(i);
//}