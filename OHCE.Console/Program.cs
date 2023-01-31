using OHCE;
using OHCE.Console.Adapters;


var ohce = new Ohce(SystemLangueAdapter.langueSystem, SystemTimePériodeJournéeAdapter.PériodeActuelle);
//Console.WriteLine(ohce.Saluer());
Console.WriteLine(">");
Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? String.Empty));
//Console.WriteLine(ohce.AuRevoir());