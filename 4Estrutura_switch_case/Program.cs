
Console.WriteLine("## Estrutura switch- case ##");

Console.WriteLine("Informe o numero inteiro");
var numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2)
{
    case 0:
        Console.WriteLine("\n" + numero + "é par");
        break;
        case 1:
        Console.WriteLine("\n" + numero + "é ímpar");
        break;
}
Console.WriteLine("\n Fim de Processamento ...");
Console.ReadKey();
