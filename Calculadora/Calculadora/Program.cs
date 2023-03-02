using System;

namespace Calculadora;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Selecione uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Resto da divisão");

        int opcao = int.Parse(Console.ReadLine());

        double resultado = 0;

        switch (opcao)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero!");
                    return;
                }
                break;
            case 5:
                if (num2 != 0)
                {
                    resultado = num1 % num2;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Opção inválida!");
                return;
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}