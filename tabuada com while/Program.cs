using System;

namespace tabuada_com_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número e eu direi a tabuada: ");
            int tabuada = int.Parse(Console.ReadLine());
            int i = 0;
            Console.WriteLine("---------------------------------------");
            while (i <= 10)
            {
                Console.WriteLine($"{tabuada} x {i} = {tabuada*i}");
                i++;
            }

            Console.WriteLine("Fim");
        }
    }
}
