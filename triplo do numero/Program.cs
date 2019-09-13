using System;

namespace triplo_do_numero
{
    class Program
    {
        static void Main(string[] args)
        {
           int n;
           Console.WriteLine("Entre com um número");
           n = int.Parse(Console.ReadLine());

           int triplo = n * n* n;

           Console.WriteLine($"O triplo de {n} é {triplo}");
        }
    }
}
