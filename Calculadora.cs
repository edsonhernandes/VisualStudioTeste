using System;

namespace Calculadora
{
    class Program // Calculadora Console
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação: ");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o segundo número: ");
            float numero2  = float.Parse(Console.ReadLine());

            float resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    resultado = numero1 / numero2;
                    break;

            }
            Console.WriteLine("{0} {1} {2} = {3}", numero1, operacao, numero2, resultado);


            Console.ReadKey();

        }
    }
}
