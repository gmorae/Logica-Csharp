using System;

namespace reais_para_dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            float reais, cotacao;

            Console.WriteLine("Digite o valor em reais: ");
            reais = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da cotação do dolar: ");
            cotacao = float.Parse(Console.ReadLine());

            float dolar = reais / cotacao;

            Console.WriteLine($"O valor em dolares é = {dolar}");
        }
    }
}
