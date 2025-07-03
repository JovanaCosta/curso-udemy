
Console.WriteLine("## Instrução if-else ##");

Console.WriteLine("Informe o valor de x\t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y\t");
int y = Convert.ToInt32(Console.ReadLine());

if(x > y)
{
    Console.WriteLine("x é maior que y");
}
else
{
    if(x < y)
    {
        Console.WriteLine("x é menor que y");
    }
}

Console.WriteLine("Fim de Processamento");
Console.ReadKey();
