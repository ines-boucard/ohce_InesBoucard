using OHCE;
using OHCE.Console.Adapters;



//string? langue = System.Globalization.CultureInfo.InstalledUICulture.NativeName;
//string langue2 = Thread.CurrentThread.CurrentCulture.Name;

var ohce = new Ohce(SystemLangueAdapter.langueSystem, SystemTimePériodeJournéeAdapter.PériodeActuelle);
//Console.WriteLine(langue2);
Console.WriteLine(">");
Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? String.Empty));

