using System;

namespace Conta_de_divida
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, contas;

            Console.WriteLine("Digite o seu sálario");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da suas dividas");
            contas = float.Parse(Console.ReadLine());

            float total = salario - contas;

            Console.WriteLine($"O seu sálario agora é de = {total} reais ");
        }
    }
}
