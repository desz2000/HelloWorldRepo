using System;
using System.ComponentModel;

public static class CalculadoraSimples
{
    public static void Calculadora(int numero1, int numero2)
    {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");

            Console.Write("Digite o número da operação desejada: ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (escolha)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    if (numero2 != 0)
                        resultado = numero1 / numero2;
                    else
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Escolha uma operação válida (1 a 4).");
                    break;
            }

        Console.WriteLine($"Resultado: {resultado}");
    }
}