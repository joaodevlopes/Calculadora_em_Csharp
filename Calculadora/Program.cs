using System;

namespace Calculadora;

public class Program
{

    public static void Main()
    {
        bool loopProgram = true;
        while (loopProgram)
        {
            //Inicialização do programa 
            Console.WriteLine("==========Calculadora Simples==========");
            Console.WriteLine("Digite o primeiro numero : ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero : ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            //selecionar o tipo de operação
            Console.WriteLine("\nEscolha uma operação : ");
            Console.WriteLine("1. Adição (+)");
            Console.WriteLine("2. Subtração (-)");
            Console.WriteLine("3. Multiplicação (*)");
            Console.WriteLine("4. Divisão (/)");
            Console.WriteLine("Digite o numero da operação :");
            int operation = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            //Condições

            switch (operation)
            {
                case 1:
                    result = number1 + number2;
                    break;

                case 2:
                    result = number1 - number2;
                    break;

                case 3:
                    result = number1 * number2;
                    break;

                case 4:
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("Não é possivel dividir um numero por 0");
                    }
                    break;

                default:
                    Console.WriteLine("Operação invalida");
                    break;

            }

            //Resultado

            Console.WriteLine("\nResultado : " + result);
            Console.WriteLine("\nDeseja fazer Mais Calculos?");
            Console.WriteLine("1. Sim");
            Console.WriteLine("2. Não, Sair do programa");
            int programContinue = Convert.ToInt32(Console.ReadLine());

            switch (programContinue)
            {
                case 1:
                    loopProgram = true;
                    break;
                case 2:
                    Console.WriteLine("Obrigado por usar o programa.\n Encerrando...");
                    loopProgram = false;
                    break;

            }

        }
    }

}