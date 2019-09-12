using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;
            int soma;
            Console.WriteLine("Digite uma nota: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            n3 = int.Parse(Console.ReadLine());
            soma = (n1 + n2 + n3) / 3;
            Console.WriteLine($"A média do aluno é = {soma}");
        }
    }
}
