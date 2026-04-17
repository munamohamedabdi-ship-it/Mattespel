using System;
using System.Collections.Generic;

Console.WriteLine("Välkommen till Matte quiz");
Console.WriteLine("-------------------------");
int points = 0;
//Lista med frågor,svaralternativ och rättsvar
var frågor = new List<(string fråga, string[] alternativ, string rättsvar)>
{
    // Fråga 1
    ("1. 3x + 1 = 16", new[] { "A)5", "B)8", "C)10", "D)3" }, "A"),

    // Fråga 2
    ("2. Vilket tal är störst?", new[] { "A)1/2", "B)2/3", "C)3/5", "D)0.6" }, "B"),

    // Fråga 3
    ("3. Vad är 7 * 8?", new[] { "A)53", "B)78", "C)40", "D)56" }, "D")
};
// Loppar igenom vraje fråga i listan
foreach (var f in frågor)
{
    Console.WriteLine();
    Console.WriteLine(f.fråga); //Skriver ut själva frågan
    foreach (var alternativ in f.alternativ)
    {
        Console.WriteLine(alternativ);
    }
    //Läser in användarens svar, tar bort mellanslag omvandlar till stora bokstväer 
    string svar = Console.ReadLine()?.Trim().ToUpper() ?? "";
    //kollar om svaret är rätn
    if (svar == f.rättsvar) 
    {
        Console.WriteLine("Rätt svar bra jobbat");
        points++;
    }
    else
    {
        Console.WriteLine("Fel svar tyvärr");
    }
}
// Slutpoäng
Console.WriteLine($"Du fick totalt {points} poäng.");