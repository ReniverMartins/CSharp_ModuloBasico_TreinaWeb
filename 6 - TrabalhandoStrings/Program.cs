// See https://aka.ms/new-console-template for more information

string nome = "Reniver";
string sobrenome = "Kennyster";

// concatenando Strings
    string nomeCompleto = nome + sobrenome;
    string nomeCompleto2 = nome + " " + sobrenome;
    string nomeCompleto3 = $"{nome} {sobrenome}.";


System.Console.WriteLine(nomeCompleto);
System.Console.WriteLine(nomeCompleto2);
System.Console.WriteLine(nomeCompleto3);

//Maiusculo e Minusculo
System.Console.WriteLine(nomeCompleto.ToUpper());
System.Console.WriteLine(nomeCompleto2.ToLower());

//Parte de Strings
System.Console.WriteLine(nomeCompleto.Substring(3));
System.Console.WriteLine(nomeCompleto.Substring(3,4));


//Pesquisa de Strings
System.Console.WriteLine(nomeCompleto.Contains('R'));
System.Console.WriteLine(nomeCompleto.Contains("le"));

//String começa com ou termina com 
System.Console.WriteLine(nomeCompleto.StartsWith("R"));
System.Console.WriteLine(nomeCompleto.EndsWith("L"));

//Localizar indice
System.Console.WriteLine(nomeCompleto.IndexOf('R'));
System.Console.WriteLine(nomeCompleto.IndexOf('K'));

