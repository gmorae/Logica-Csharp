using System;

namespace lista_de_frutas__array_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua lista de compra: \n");
            
            Console.WriteLine("Digite quantos produtos você vai comprar: ");
            int valor = int.Parse(Console.ReadLine());

            String[] listas = new String[valor];
            int n = 0;
            do{
                Console.WriteLine("Digite o seu produto: ");
                listas[n] = Console.ReadLine();
                Console.WriteLine("-----PRÓXIMO-----");
                n++;
            }while (n < valor);
            n = 0;
            do{
                Console.WriteLine($"produto => {listas[n]}");
                n++;
            }
            while (n < valor);
        }
    }
}
