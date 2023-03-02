using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma palavra ou frase:");
        string texto = Console.ReadLine();

        string consoantes = "";

        foreach (char letra in texto.ToLower())
        {
            if (!"aeiou ".Contains(letra))
            {
                consoantes += letra;
            }
        }

        Console.WriteLine("As consoantes são: " + consoantes);
    }
}