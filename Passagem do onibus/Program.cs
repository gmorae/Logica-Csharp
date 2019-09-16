using System;

namespace Passagem_do_onibus
{
    class Program
    {
        static void Main(string[] args)
        {
            float passagem;
            int usuarios;
            string motorista;
            Console.WriteLine("Olá motorista, digite o seu nome: ");
            motorista = Console.ReadLine();
            Console.WriteLine($"Olá {motorista}, digite o valor atual da passagem: ");            
            passagem = float.Parse(Console.ReadLine());
            Console.WriteLine($"Muito bem {motorista}, agora você deve digitar a quantidade de passageiros que tem no ônibus: ");
            usuarios = int.Parse(Console.ReadLine());

            float total = passagem * usuarios;
            Console.WriteLine($"{motorista}, o total que você arrecadou nesta viagem foi: {total} reais");
        }
    }
}
