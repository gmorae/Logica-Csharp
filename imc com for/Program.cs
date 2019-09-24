using System;

namespace imc_com_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de pacientes");
            int pacientes = int.Parse(Console.ReadLine());
            String[] nomes = new string[pacientes];
            String[] sexo = new string[pacientes];
            int[] idade = new int[pacientes];
            double[] altura = new double[pacientes];
            double[] peso = new double[pacientes];
            double homem = 0, mulher = 0, somaM = 0, somaF = 0, mediaF = 0, mediaM = 0;
            for (int i = 0; i < pacientes; i++)
            {
                Console.Write($"Digite o nome da {i + 1}º pessoa: ");
                nomes[i] = Console.ReadLine();
                Console.Write($"Digite o sexo da {i + 1}º pessoa: ");
                sexo[i] = Console.ReadLine();
                 Console.Write($"Digite a idade da {i + 1}º pessoa: ");
                idade[i] = int.Parse(Console.ReadLine());
                if (sexo[i] == "H" || sexo[i] == "h")
                {
                    homem++;
                    somaM += idade[i];
                }
                else
                {
                    mulher++;
                    somaF += idade[i];
                }
               
                Console.Write($"Digite a altura da {i + 1}º pessoa: ");
                altura[i] = double.Parse(Console.ReadLine());
                Console.Write($"Digite o peso da {i + 1}º pessoa: ");
                peso[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------");
            }
            mediaM = somaM / homem;
            mediaF = somaF / mulher;
            double imc;
            for (int i = 0; i < pacientes; i++)
            {
                Console.WriteLine($"imc do {nomes[i]} => {imc = peso[i] / (altura[i] * altura[i])}");
            }
            Console.WriteLine(mediaM);
            Console.WriteLine(mediaF);
            Console.WriteLine($"Total de homens = {homem}");
            Console.WriteLine($"Total de mulheres = {mulher}");

        }
    }
}
