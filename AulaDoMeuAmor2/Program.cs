
//Lists

//criando uma lista
using System.Reflection.Metadata;

var frutas = new List<string>();

frutas.Add("Pesco");
frutas.Add("Banana");
frutas.Add("Limao");
frutas.Add("Morango");
frutas.Add("Uva");


foreach (string fruta in frutas)
{
    if (fruta == "Limao")
    {
        Console.WriteLine("Preço aumentou");
    }
}

var resultado = 2025 - 2003;

Console.WriteLine(resultado);

var anoDeNascimentos = new List<int>();

anoDeNascimentos.Add(2000);
anoDeNascimentos.Add(2008);
anoDeNascimentos.Add(2005);

foreach (int anoDeNascimento in anoDeNascimentos)
{
    int idade = ( 2025 - anoDeNascimento);
   
    Console.WriteLine("minha idade é " + idade );

}


//Arrays

