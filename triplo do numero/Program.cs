using System;

namespace triplo_do_numero
{
    class Program
    {
        static void Main(string[] args)
        {
           int numero, multi;
           Console.WriteLine("Entre com um número: ");
           numero = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite o multiplo que você deseja: ");
           multi = int.Parse(Console.ReadLine());


           int resultado = numero * multi;

           Console.WriteLine($"O triplo de {numero} é {resultado}");
        }
    }
}
