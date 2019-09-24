using System;

namespace tabuada_com_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero*i}");
            }
        }
    }
}
