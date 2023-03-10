using System;

namespace Exercicio4
{
    internal class Program
    {
        static int tempoDeChegada(int kmh)
        {
            double calculoTempoChegada = (100 / kmh) * 60;
            return (int)Math.Round(calculoTempoChegada);
        }

        static void Main(string[] args)
        {
            int carro = 0, caminhao = 75;

            tempoDeChegada(caminhao);
            Console.WriteLine(caminhao);

            while(carro < 53)
            {
                carro++;
                caminhao--;
                if (carro == caminhao)
                {
                    Console.WriteLine(carro);
                }
            }

            
            
        }
    }
}
