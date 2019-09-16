using System;

namespace Salario_com_o_nome
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            float comissao, salario, vendas;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o quando você ganha de comissão em porcentagem: ");
            comissao = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu salario fixo: ");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas que você teve no mês: ");
            vendas = float.Parse(Console.ReadLine());

            float totalVendas =  salario * comissao / 100;
            float total = totalVendas + salario;

            Console.WriteLine($"Olá {nome}, o seu salário fixo é {salario}, mas com suas vendas ficou = {total}");
        }
    }
}
