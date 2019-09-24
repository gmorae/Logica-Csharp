using System;

namespace Cadastro_de_produtos_com_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de produtos com o for");
            string[] produtoNome = new String[2];
            double[] produtoPreco = new double[2];
            double soma = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Digite o nome de um produto: ");
                produtoNome[i] = Console.ReadLine();
                Console.Write("Digite o valor: ");
                produtoPreco[i] = double.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Produto => {produtoNome[i]} = {produtoPreco[i]} reais");
            }
            for (int i = 0; i < 2; i++)
            {
                soma += produtoPreco[i];
            }
            Console.WriteLine($"soma dos produtos => {soma} reais");
        }
    }
}
