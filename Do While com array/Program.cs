using System;

namespace Do_While_com_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo arrays com C#");

            int n = 0;
            string[] nomes = new string[5];
            string[] telefone = new string[5];
            string[] email = new string[5];

            
            do{
                Console.WriteLine("Qual o seu nome ?");
                nomes[n] = Console.ReadLine();
                Console.WriteLine("Qual o seu telefone ?");
                telefone[n] = Console.ReadLine();
                Console.WriteLine("Qual o seu email ?");
                email[n] = Console.ReadLine();
                Console.WriteLine("\n-----PRÓXIMO-----\n");
                n++;
            }while (n < 5);
            n = 0;
            do{
                Console.WriteLine($"usuario => nome: {nomes[n]}, telefone: {telefone[n]} e e-mail: {email[n]}");
                n++;
            }
            while (n < 5);

        }
    }
}
