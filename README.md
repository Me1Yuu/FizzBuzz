Eine kurze Übung in C#.

Code:

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

Die Konsole zählt nur bis 100 auf, wird danach geschlossen. || Sollte ich noch ändern
Die Zahlen, die durch 3 teilbar sind, bekommen als Antwort "Fizz".
Die Zahlen, die durch 5 teilbar sind, bekommen als Antwort "Buzz".
Und wenn die Zahl durch beides teilbar ist, wird es zum "FizzBuzz".
