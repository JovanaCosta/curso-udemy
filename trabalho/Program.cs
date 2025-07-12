using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        List<int> meusNumeros = new List<int>();

        meusNumeros.Add(55);
        meusNumeros.Add(64);
        meusNumeros.Add(78);
        meusNumeros.Add(102);
        meusNumeros.Add(177);
        meusNumeros.Add(199);
        meusNumeros.Add(167);
        meusNumeros.Add(205);
        meusNumeros.Add(279);
        meusNumeros.Add(255);
        meusNumeros.Add(208);
        meusNumeros.Add(300);
        meusNumeros.Add(388);
        meusNumeros.Add(400);

        meusNumeros.RemoveAll(numero => numero % 2 != 0);

        foreach (int numero in meusNumeros)
        {
       
          
                Console.WriteLine($"{numero} Este número é par!");
                Console.WriteLine($"Will é o melhor namorado de todos!:)");
            
  





        }
    }
}
