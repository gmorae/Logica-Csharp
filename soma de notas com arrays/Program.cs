using System;

namespace soma_de_notas_com_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o total de alunos da sala");
            int alunos = int.Parse(Console.ReadLine());
            int[] nota1 = new int[alunos];
            int[] nota2 = new int[alunos];
            double[] media = new double[alunos];
            double soma = 0;
            int cont = 0, aprovados = 0, reprovados = 0;

            for (int i = 0; i < alunos; i++)
            {
                Console.WriteLine($"Digite a nota1 do aluno {cont + 1}º: ");
                nota1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a nota2 do aluno {cont + 1}º: ");
                nota2[i] = int.Parse(Console.ReadLine());
                cont++;
                media[i] = (nota1[i] + nota2[i]) / 2;
                if (media[i] >= 7){
                    aprovados++;
                }else{
                    reprovados++;
                }
            }
            for (int i = 0; i < alunos; i++){
               soma = media[i] +media[i] / alunos;
            }
            Console.WriteLine($"Media da turma = {soma} \nTotal de alunos aprovados = {aprovados} \nTotal de alunos reprovados = {reprovados} ");
        }
    }
}