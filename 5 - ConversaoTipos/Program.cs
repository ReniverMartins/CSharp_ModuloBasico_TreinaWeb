// See https://aka.ms/new-console-template for more information

int ano = 2023; 
float ano2 = ano; 
System.Console.WriteLine(ano2);

decimal taxa = 12.98m;
string taxa2 = taxa.ToString(); //.ToString(); converte e retorna valores em formato textual para visualização;
System.Console.WriteLine(taxa2);

DateTime data = DateTime.Now;
string data2 = data.ToString();


string resposta = "12";
int idade = int.Parse(resposta); //.Parse(); converte dado textual em valores
int idade2 = Convert.ToInt32(resposta); //.Convert.formato desejado(); converte dado textual em valores
System.Console.WriteLine(idade);
System.Console.WriteLine(idade2);

