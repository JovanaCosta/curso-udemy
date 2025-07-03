using System;

class Program
{
    static void Main()
    {
        // Laço que vai do número 1 até 30
        for (int i = 1; i <= 30; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("O número " + i + " é par");
            }
            else
            {
                Console.WriteLine("O número " + i + " é ímpar");
            }
        }

        // Espera o usuário apertar uma tecla para encerrar
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
