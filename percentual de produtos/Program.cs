using System;

namespace percentual_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            int porcentagem;
            int valor;

            Console.WriteLine("Digite o valor do produto: ");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da porcentagem: ");
            porcentagem = int.Parse(Console.ReadLine());

            int total1 = (valor * porcentagem)/100;
            int total2 = total1 + valor;

            Console.WriteLine($"O valor agora é = {total2}");
        }
    }
}
