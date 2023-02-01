// See https://aka.ms/new-console-template for more information

try{
    var nomes = new [] {"Sr. Roseta", "Dr. Pontera", "Mr. Geodude", "Phd. Manguaça", "Mr. Bicheiro"};

    for( var i=0; i<=nomes.Length; i++){
        System.Console.WriteLine(nomes[i]);
    }

}catch (Exception erro){
    System.Console.WriteLine("ATENÇÃO: "+erro.Message);
}