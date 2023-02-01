// See https://aka.ms/new-console-template for more information

var aluno1 = new Aluno();
aluno1.Nome = "Reniver";
aluno1.Idade = 31;


var aluno2 = new Aluno();
aluno2.Nome = "Viviane";
aluno2.Idade = 32;

System.Console.WriteLine(aluno1.Nome);
System.Console.WriteLine(aluno1.Idade);
System.Console.WriteLine("");
System.Console.WriteLine(aluno2.Nome);
System.Console.WriteLine(aluno2.Idade);



class Aluno{
    public string? Nome{get; set;}
    public int Idade {get; set;}
}