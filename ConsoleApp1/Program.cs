using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // criacao da lista
        List<int> numeros = new List<int>();

        //adicionando os valores na lista
        numeros.Add(1); // posicao 0
        numeros.Add(2);
        numeros.Add(27);
        numeros.Add(4);
        numeros.Add(538);
        numeros.Add(6);
        numeros.Add(101);
        numeros.Add(8);
        numeros.Add(9);
        numeros.Add(38);
        numeros.Add(11); // posicao 10
        numeros.Add(12);
        numeros.Add(45);
        numeros.Add(14);
        numeros.Add(15);
        numeros.Add(16);
        numeros.Add(174);
        numeros.Add(213);
        numeros.Add(19);
        numeros.Add(255);
        numeros.Add(21); // posicao 20
        numeros.Add(501);
        numeros.Add(8);
        numeros.Add(29);
        numeros.Add(18);
        numeros.Add(26);
        numeros.Add(249);
        numeros.Add(28);
        numeros.Add(488); // posicao 28

        // primeiro numero da lista
        var lala = numeros[28] - numeros[20];

        // Console.writeLine escreve no console
        Console.WriteLine(numeros[4]);

        Console.WriteLine(lala);



        foreach (var numero in numeros)
        {
            var resultado = numero % 2;

            if (resultado == 0)
            {
                Console.WriteLine($"{numero} é par");
                Console.WriteLine($"Will tem o melhor cheiro desse mundo");
            }
            else
            {
                Console.WriteLine($"{numero} é impar");
            }
        }



    }
}


