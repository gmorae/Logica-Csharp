using System;

namespace aumento_de_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            float salarioAtual;

            Console.WriteLine("Digite seu salario atual: ");
            salarioAtual = float.Parse(Console.ReadLine());

            float reajuste = salarioAtual * 30 / 100;
            float novoSalario = reajuste + salarioAtual;

            if (salarioAtual > 990)
            {
                Console.WriteLine("Você não receberá o aumento");
            }else{
                Console.WriteLine($"O seu novo salario é = {novoSalario}");
            }
        }
    }
}
