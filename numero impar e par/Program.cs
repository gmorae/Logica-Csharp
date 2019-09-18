using System;

namespace numero_impar_e_par
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            
            if( numero%2 != 1){
                Console.WriteLine("O número é par");
            }else{
                Console.WriteLine("O número é impar");
            }
        }
    }
}
