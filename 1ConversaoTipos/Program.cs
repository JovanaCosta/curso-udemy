
Console.WriteLine("## Conversão de tipos ##\n");

double varDouble = 12.456;  //8bytes
int varInt = (int)varDouble;  //4 bytes (perda de prescisão)

Console.WriteLine(varInt);

int num1 = 10;
int num2 = 4;

float resultado = (float)num1 / num2; //10/4 = 2.5

Console.WriteLine(resultado);

Console.ReadLine();
