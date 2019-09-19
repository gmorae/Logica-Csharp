using System;

namespace validação_com_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação com do while");

            String nome;
            do
            {
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
            } while (nome.Length <= 1);
        }
    }
}
