using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra ou texto:");
            string str = Console.ReadLine();
            string stringInvertida = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                stringInvertida += str[i];
            }

            Console.WriteLine(stringInvertida);
        }
        }
    }

