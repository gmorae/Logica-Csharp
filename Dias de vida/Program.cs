using System;

namespace Dias_de_vida
{
    class Program
    {
        static void Main(string[] args)
        {
            float idade; 
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            // Processamento
            
            float meses = idade * 12;
            float dias = idade * 365;
            float horas = dias * 24;
            float minutos = horas * 60;

            // Respostas

            Console.WriteLine($"meses = {meses},\n dias = {dias},\n horas = {horas}\n minuto = {minutos}");
        }
    }
}
