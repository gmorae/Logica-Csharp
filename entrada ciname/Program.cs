using System;

namespace entrada_ciname
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 18 || idade >= 60)
            {
                Console.WriteLine("Você irá pagar meia");
            }else{
                Console.WriteLine("Você irá pagar interia");
            }
        }
    }
}
