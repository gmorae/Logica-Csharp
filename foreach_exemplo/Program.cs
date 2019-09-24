using System;

namespace foreach_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de foreach");

            string[] nomes = { "", "Gabriel" };

            foreach (var item in nomes)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
