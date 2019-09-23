using System;

namespace coding_dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int resposta;
            String[] produtos = new String[10];
            int[] valor = new int[10];

            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produto");
                Console.WriteLine("3 - Calcular os produtos");
                Console.WriteLine("0 sair");
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        string resp = "";
                        do
                        {
                            if (cont < 10)
                            {
                                Console.WriteLine("Digite o nome do produto");
                                produtos[cont] = Console.ReadLine();
                                Console.WriteLine("Digite o valor do produto: ");
                                valor[cont] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Deseja cadastrar outro produto ?");
                                resp = Console.ReadLine();
                                cont++;
                            }
                            else
                            {
                                Console.WriteLine("No momento o estoque está cheio \n");
                                cont++;
                            }
                        } while (resp == "S" || resp == "s");
                        break;
                    case 2:
                        cont = 0;
                        while (cont < 10)
                        {
                            Console.WriteLine($"Produtos = {produtos[cont]} => {valor[cont]} reais");
                            cont++;
                        }
                        break;

                    case 3:
                        cont = 0;
                        float soma = 0;
                        while (cont < 10)
                        {
                            soma = soma + valor[cont];
                            cont++;
                        }
                        Console.WriteLine($"Total = {soma} reais");
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por utilizar nosso sistema");
                        break;
                    
                    default:
                        Console.WriteLine("Número inválido");
                        break;
                }
            } while (resposta != 0);

        }
    }
}
