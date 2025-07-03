
Console.WriteLine("## Operadores Aritmetricos ##\n");

Console.WriteLine("Inform o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"\n Raiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"\n Potência de x elevado a y = {Math.Pow(x,y)}");
Console.WriteLine($"\n Valor minímo entre x e y  = {Math.Min(x,y)}");
Console.WriteLine($"\n Valor máximo entre x e y  = {Math.Max(x,y)}");
Console.WriteLine($"\n Coseno de x = {Math.Cos(x)}");
Console.WriteLine($"\n Seno x = {Math.Sin(x)}");
Console.WriteLine($"\n Exponencial de x = {Math.Exp(x)}");

Console.ReadKey();

//Console.WriteLine($"soma de x+y = {x+y}");
//Console.WriteLine($"subtração de x-y = {x-y}");
//Console.WriteLine($"multiplicação de x*y = {x*y}");
//double divisão = (double)x / y;
//Console.WriteLine($"divisãode x/y = {x/y}");
//Console.WriteLine($"modulo de x%y = {x%y}");
