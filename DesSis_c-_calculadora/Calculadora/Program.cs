using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 0;
            string operacao = "";
            string condicao = "S";
            while (condicao.ToUpper() == "S")
            {

                Console.WriteLine("Por favor, insira uma operação:");
                operacao = Console.ReadLine();
                try
                {
                    Console.WriteLine("Insira 1º número:");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                
                    Console.WriteLine("Insira 2º número:");
                    valor2 = Convert.ToInt32(Console.ReadLine());
                 }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Insira apenas números inteiros!!!");
                }

                int resultado = 0;
                    switch (operacao)
                    {
                        case "+":
                            resultado = soma(valor1, valor2);
                            break;
                        case "-":
                            resultado = subtracao(valor1, valor2);
                            break;
                        case "/":
                            resultado = divisao(valor1, valor2);
                            break;
                        case "*":
                            resultado = multiplicacao(valor1, valor2);
                            break;
                        default:
                            Console.WriteLine("Operação inválida. Operações suportadas( + | - | * | / )");
                            break;
                    }
                    Console.WriteLine("O resultado é: " + resultado);
                    Console.WriteLine("Deseja continuar? (S/N)");
                    condicao = Console.ReadLine();

            }

            Console.ReadKey();
        }

        public static int soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int subtracao(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public static int divisao(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        public static int multiplicacao(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
    }
}
