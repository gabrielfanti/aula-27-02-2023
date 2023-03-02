using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine();

        Console.Write("Vogais encontradas: ");

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.Write(c);
            }
        }

        Console.WriteLine();
    }
}
