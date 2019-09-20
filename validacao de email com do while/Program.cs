using System;

namespace validacao_de_email_com_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string email, senha;
            do
            {
                Console.WriteLine("Digite seu email: ");
                email = Console.ReadLine();
            } while (!email.Contains("@") || !email.Contains("."));

            do
            {
                Console.WriteLine("Digite sua senha: ");
                senha = Console.ReadLine();   
            } while (senha.Length < 8);

        }
    }
}
