using System;

namespace Categoria_de_nadadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 7)
            {
                Console.WriteLine("Categoria infantil A");
            }
            else if (idade <= 10)
            {
                Console.WriteLine("Catedoria infantil B");
            }
            else if (idade <= 13)
            {
                Console.WriteLine("Categoria Juvenil A");
            }
            else if (idade <= 17)
            {
                Console.WriteLine("Categoria Juvenil B");   
            }
            else if(idade > 18){
                Console.WriteLine("Categoria adulto");
            }
        }
    }
}
