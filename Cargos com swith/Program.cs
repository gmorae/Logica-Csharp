using System;

namespace Cargos_com_swith
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número do cargo para descobrir o salário: ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("( 1 ) - Diretor ");
            Console.WriteLine("( 2 ) - Gerente ");
            Console.WriteLine("( 3 ) - Professor ");
            Console.WriteLine("( 4 ) - Coordenador ");
            Console.WriteLine("( 5 ) - Atendente ");
            Console.WriteLine("----------------------------------------");

            string resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1": Console.WriteLine("O salário é de R$ 18.000,00 reais"); break;
                case "2": Console.WriteLine("O salário é de R$ 12.000,00 reais"); break;
                case "3": Console.WriteLine("O salário é de R$ 3.500,00 reaus"); break;
                case "4": Console.WriteLine("O salário é de R$ 9.000,00 reais"); break;
                case "5": Console.WriteLine("O salário é de R$ 1.500,00 reais"); break;
                default: Console.WriteLine("Digite um número de 1 à 5"); break;
            }
        }
    }
}
