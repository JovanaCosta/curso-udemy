
Console.WriteLine("## Inferência tipos (var) ##\n");

var idade = 20;
var nome = Jovana;
var salario = 1600.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString(c)}");

var salario = null;
var titulo;
var salario, imposto, total;

//nao posso ,udar o tipo apos inicializar
var num = 10;
num = num + 20;
num = "teste";

var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();
class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu Método");
    }
}
