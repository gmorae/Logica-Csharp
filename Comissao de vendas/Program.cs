using System;

namespace Comissao_de_vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            float comissao, salario, vendas;

            Console.WriteLine("Digite o quando você ganha de comissão: ");
            comissao = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu salario: ");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas que você teve no mês: ");
            vendas = float.Parse(Console.ReadLine());

            float totalVendas =  (vendas * comissao)/100;
            float total = totalVendas + salario;

            Console.WriteLine($"O seu salário mensal agora é = {total}");
        }
    }
}
