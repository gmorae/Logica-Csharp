using System;

namespace rodizio
{
    class Program
    {
        static void Main(string[] args)
        {
            String semana;
            Console.WriteLine("Digite a sua placa: ");
            String placa = Console.ReadLine();
            int cont = placa.Length;
            string final = placa.Substring(cont - 1);
            // int final = int.Parse(placa.Substring(cont - 1))

            if (final == "0" || final == "1")
            {
                semana = "Segunda-feira";

            }else if (final == "2" || final == "3")
            {
                semana = "Terça-feira";

            }else if (final == "4" || final == "5")
            {
                semana = "Quarata-feira";
            }else if (final == "6" || final == "7")
            {
                semana = "Quinta-feira";

            }else{

                semana = "Sexta-feira";
            }

            Console.WriteLine($"O seu rodizio é na {semana}");


        }
    }
}
