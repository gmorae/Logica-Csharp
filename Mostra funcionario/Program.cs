using System;

namespace Mostra_funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o seu salário: ");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu código");
            int codigo = int.Parse(Console.ReadLine());
            String cargo;
            int percentual;
            float salarioNovo, calc;
            switch (codigo)
            {
                case 1:
                    cargo = "Escriturario";
                    percentual = 50;
                    calc = salario * percentual / 100;
                    salarioNovo = salario + calc;
                    Console.WriteLine($"Olá {nome}");
                    Console.WriteLine($"O seu código é {codigo}");
                    Console.WriteLine($"O seu salário atual é R$ {salario} reais");
                    Console.WriteLine($"O seu cargo é {cargo}");
                    Console.WriteLine($"Você tem um percentual de aumento de {percentual}%");
                    Console.WriteLine($"Seu salário novo é de R$ {salarioNovo} reais");
                    break;
                case 2:
                    cargo = "Secretario";
                    percentual = 35;
                    calc = salario * percentual / 100;
                    salarioNovo = salario + calc;
                    Console.WriteLine($"Olá {nome}");
                    Console.WriteLine($"O seu código é {codigo}");
                    Console.WriteLine($"O seu salário atual é R$ {salario} reais");
                    Console.WriteLine($"O seu cargo é {cargo}");
                    Console.WriteLine($"Você tem um percentual de aumento de {percentual}%");
                    Console.WriteLine($"Seu salário novo é de R$ {salarioNovo} reais");
                    break;
                case 3:
                    cargo = "Caixa";
                    percentual = 20;
                    calc = salario * percentual / 100;
                    salarioNovo = salario + calc;
                    Console.WriteLine($"Olá {nome}");
                    Console.WriteLine($"O seu código é {codigo}");
                    Console.WriteLine($"O seu salário atual é R$ {salario} reais");
                    Console.WriteLine($"O seu cargo é {cargo}");
                    Console.WriteLine($"Você tem um percentual de aumento de {percentual}%");
                    Console.WriteLine($"Seu salário novo é de R$ {salarioNovo} reais");
                    break;
                case 4:
                    cargo = "Gerente";
                    percentual = 20;
                    calc = salario * percentual / 100;
                    salarioNovo = salario + calc;
                    Console.WriteLine($"Olá {nome}");
                    Console.WriteLine($"O seu código é {codigo}");
                    Console.WriteLine($"O seu salário atual é R$ {salario} reais");
                    Console.WriteLine($"O seu cargo é {cargo}");
                    Console.WriteLine($"Você tem um percentual de aumento de {percentual}%");
                    Console.WriteLine($"Seu salário novo é de R$ {salarioNovo} reais");
                    break;
                case 5:
                    cargo = "Diretor";
                    percentual = 0;
                    calc = salario * percentual / 100;
                    salarioNovo = salario + calc;
                    Console.WriteLine($"Olá {nome}");
                    Console.WriteLine($"O seu código é {codigo}");
                    Console.WriteLine($"O seu salário atual é R$ {salario} reais");
                    Console.WriteLine($"O seu cargo é {cargo}");
                    Console.WriteLine($"Você tem um percentual de aumento de {percentual}%");
                    Console.WriteLine($"Seu salário novo é de R$ {salarioNovo} reais");
                    break;
                default:
                    Console.WriteLine("Codigo invalido");
                    break;
            }
        }
    }
}
