using System;

namespace numero_impar_e_par
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            int n2 = int.Parse(Console.ReadLine());
            if( n1%2 != 1){
                Console.WriteLine($"O número {n1} é par \n");
            }else{
                Console.WriteLine($"O número {n1} é impar \n");
            }
            if( n2%2 != 1){
                Console.WriteLine($"O número {n2} é par \n");
            }else{
                Console.WriteLine($"O número {n2} é impar \n");
            }

            if (n1 > n2)
            {
                Console.WriteLine($"O número {n1} é maior \n");
            }else
            {
                Console.WriteLine($"O número {n2} é maior \n");
            }
        }
    }
}
