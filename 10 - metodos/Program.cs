// See https://aka.ms/new-console-template for more information

var conta1 = new ContaCorrente();
conta1.NumeroConta = "001-002";
conta1.Saldo = 10;
//conta1.ImprimirInfoConta();

conta1.Deposito(100);
System.Console.WriteLine(conta1.ListarInfo());



class ContaCorrente{
     public string NumeroConta;
     public decimal Saldo;

     public void ImprimirInfoConta(){
        System.Console.WriteLine($"numero da conta: {NumeroConta} | saldo: {Saldo}");
     }

     public string ListarInfo(){
        return $"NUMERO: {NumeroConta} | SALDO: {Saldo}";
     }

     public void Deposito(decimal Cash){
        Saldo += Cash;
    }

}