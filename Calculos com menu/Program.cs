using System;

namespace Calculos_com_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número : ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número : ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite um número de sua preferencia");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("( 1 ) - Soma ");
            Console.WriteLine("( 2 ) - Subtração primeiro pelo segundo ");
            Console.WriteLine("( 3 ) - Subtração segundo pelo primeiro ");
            Console.WriteLine("( 4 ) - Multiplicação ");
            Console.WriteLine("( 5 ) - Divisão do primeiro pelo segudo ");
            Console.WriteLine("( 6 ) - Divisão do segundo pelo primeiro ");
            Console.WriteLine("----------------------------------------");

            string resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                    float soma = n1 + n2;
                    Console.WriteLine($"A soma de {n1} + {n2} = {soma}");
                    break;

                case "2":
                    float subtracao = n1 - n2;
                    Console.WriteLine($"A subtração de {n1} - {n2} = {subtracao}");
                    break;

                case "3":
                    float subtracao2 = n2 - n1;
                    Console.WriteLine($"A subtração de {n2} - {n1} = {subtracao2}");
                    break;

                case "4":
                    float multi = n1 * n2;
                    Console.WriteLine($"A multiplicação de {n1} x {n2} = {multi}");
                    break;

                case "5":
                    float div = n1 / n2;
                    Console.WriteLine($"O valor da divisão de {n1} / {n2} = {div}");
                    break;

                case "6":
                    float div2 = n2 / n1;
                    Console.WriteLine($"O valor da divisão de {n2} / {n1} = {div2}");
                    break;

                default:
                    Console.WriteLine("Digite um número de 1 à 6");
                    break;
            }
        }
    }
}
