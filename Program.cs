using System;

Console.WriteLine("Välkommen till Matte quiz");
Console.WriteLine("-------------------------");
int points = 0;

// Fråga 1
Console.WriteLine("1. 3x+1=16");
Console.WriteLine("A) 5");
Console.WriteLine("B) 8");
Console.WriteLine("C) 10");
Console.WriteLine("D) 3");
string svar1 = Console.ReadLine().Trim().ToUpper();
if (svar1 == "A")
{
    Console.WriteLine("Rätt svar bra jobbat");
    points++;
}
else
{
    Console.WriteLine("Fel svar tyvärr");
}

// Fråga 2
Console.WriteLine("2. Vad är 25% av 200");
Console.WriteLine("A) 140");
Console.WriteLine("B) 20");
Console.WriteLine("C) 50");
Console.WriteLine("D) 100");
string svar2 = Console.ReadLine().Trim().ToUpper();
if (svar2 == "C")
{
    Console.WriteLine("Rätt svar bra jobbat");
    points++;
}
else
{
    Console.WriteLine("Fel svar tyvärr");
}

// Fråga 3
Console.WriteLine("3. Vad är 3 upphöjt med 2");
Console.WriteLine("A) 3");
Console.WriteLine("B) 12");
Console.WriteLine("C) 6");
Console.WriteLine("D) 9");
string svar3 = Console.ReadLine().Trim().ToUpper();
if (svar3 == "D")
{
    Console.WriteLine("Rätt svar bra jobbat");
    points++;
}
else
{
    Console.WriteLine("Fel svar tyvärr");
}
// Fråga 4
Console.WriteLine("4. Vilket är medelvärdet av talen 2,5,8 ");
Console.WriteLine("A) ");
Console.WriteLine("B) ");
Console.WriteLine("C) ");
Console.WriteLine("D) ");
string svar4 = Console.ReadLine().Trim().ToUpper();
if (svar4 == "D")
{
    Console.WriteLine("Rätt svar bra jobbat");
    points++;
}
else
{
    Console.WriteLine("Fel svar tyvärr");
}










































// Slutpoäng
Console.WriteLine($"Du fick totalt {points} poäng.");