﻿using System;

namespace Ano_de_nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento, anoAtual;

            Console.WriteLine("Digite seu ano de nascimento");
            anoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano atual");    
            anoAtual = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNascimento;
            int dias = idade * 365;
            int semana = dias / 7;
            Console.WriteLine($"A sua idade é = {idade} anos");
            Console.WriteLine($"E você viveu {semana} semanas");

        }
    }
}
