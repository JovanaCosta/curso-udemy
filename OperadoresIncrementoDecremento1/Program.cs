
Console.WriteLine("## Operadores Incremento Decremento ##");
int x = 0;

Console.WriteLine($"x = {x}");

int resultado1 = x++ + 10;
Console.WriteLine($"pós-incremento {resultado1}");
Console.WriteLine($"Valor de x {x}\n");

int y = 0;
Console.WriteLine($"y = {y}");
int resultado2 = ++y + 10;

Console.WriteLine($"pré-incremento {resultado2}");
Console.WriteLine($"valor de y {y}\n");

Console.ReadKey();
