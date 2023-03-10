using System;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 0, v2 = 1, v3 = 1, n;
           
            Console.WriteLine("Digite o um número para saber se ele é da sequência Fibonacci");
            n = Convert.ToInt32(Console.ReadLine());
  
            while (v3 < n)
            {
                v3 = v1 + v2;
                v1 = v2;
                v2 = v3;
            }

            if (v3 == n)
            {
                Console.WriteLine(n + " Pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine(n +" Não pertence à sequência de Fibonacci.");
            }

        }
    }
}
