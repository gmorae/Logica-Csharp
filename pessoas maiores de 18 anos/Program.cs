using System;

namespace pessoas_maiores_de_18_anos
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, idade, i, menores = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade >= 18)
                {
                    maior++;
                }else{
                    menores++;
                }
            }
            Console.WriteLine($"Quantidades de idades maiores de 18 = {maior} pessoas e menores de 18 = {menores} pessoas");
            
        }
    }
}
