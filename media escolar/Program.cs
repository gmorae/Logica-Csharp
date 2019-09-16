using System;

namespace media_escolar
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;
            String nome;

            Console.Write("Olá professor digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write($"Digite a nota do {nome}: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write($"{nome} digite outra nota: ");
            n2 = float.Parse(Console.ReadLine());

            float media = (n1 + n2) / 2;

            if (media >= 7)
            {
                Console.Write($"Professor, o {nome} foi aprovado");
            }else{
                Console.Write($"Professor, o {nome} foi reprovado");
            }
        }
    }
}
