using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraCMD
{
    enum Menu { Soma = 1, Subtração, Divisao, Multiplicacao, Potencia, Raiz, Sair}
    internal class Program
    {
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair) 
            {
                Console.WriteLine("SEJA BEM VINDO! VAMOS CALCULAR, SELECIONE UMA DAS OPÇÕES: ");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtração:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Divi();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair |= true;
                        break;
                }
                Console.Clear();
            }

        } 
        
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("SOMA DE DOIS NÚMEROS");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int soma = a + b;
            Console.WriteLine($"O resultado da soma de {a} + {b} é: {soma}");
            Console.WriteLine("\nAperte ENTER para voltar ao MENU");
            Console.ReadLine();
        }

        static void Sub()
        {
            Console.Clear();
            Console.WriteLine("SUBTRAÇÃO DE DOIS NÚMEROS");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int result = a - b;
            Console.WriteLine($"O resultado da subtração de {a} - {b} é: {result}");
            Console.WriteLine("\nAperte ENTER para voltar ao MENU");
            Console.ReadLine();
        }

        static void Divi()
        {
            Console.Clear();
            Console.WriteLine("DIVISÃO DE DOIS NÚMEROS");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float result = (float)a / (float)b;
            Console.WriteLine($"O resultado da divisão de {a} por {b} é: {result}");
            Console.WriteLine("\nAperte ENTER para voltar ao MENU");
            Console.ReadLine();
        }

        static void Mult()
        {
            Console.Clear();
            Console.WriteLine("MULTIPLICAÇÃO DE DOIS NÚMEROS");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int result = a * b;
            Console.WriteLine($"O resultado da multiplicação de {a} vezes {b} é: {result}");
            Console.WriteLine("\nAperte ENTER para voltar ao MENU");
            Console.ReadLine();
        }

        static void Pot()
        {
            Console.Clear();
            Console.WriteLine("POTÊNCIA DE UM NÚMERO");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int result = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado da exponenciação é: {result}");
            Console.WriteLine("\nAperte ENTER para voltar ao MENU");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.Clear();
            Console.WriteLine("RAIZ DE UM NÚMERO");
            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            double result = Math.Sqrt(a);
            Console.WriteLine($"A raiz de {a} é: {result}");
            Console.WriteLine("\nAperte ENTER para voltar ao MENU");
            Console.ReadLine();
        }
    }
}
