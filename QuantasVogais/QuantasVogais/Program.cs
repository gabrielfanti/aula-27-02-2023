using System;
namespace QuantasVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra ou frase: ");
            string entrada = Console.ReadLine();
            int contagem = 0;

            foreach (char letra in entrada)
            {
                if ("aeiouAEIOU".IndexOf(letra) >= 0)
                {
                    contagem++;
                }
            }

            Console.WriteLine("A quantidade de vogais na palavra ou frase é: " + contagem);
            Console.ReadKey();
        }
    }
}
