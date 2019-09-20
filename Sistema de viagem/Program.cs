using System;

namespace Sistema_de_viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de arrays
            String[] nome = new String[2];
            String[] origem = new String[2];
            String[] destino = new String[2];
            DateTime[] data = new DateTime[2];
            // Declaração de varial
            int opcao = 0;
            int contador = 0;

            // Iniciando o sistema
            Console.WriteLine("Sistema de viagem\n");
            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - CADASTRAR PASSAGENS");
                Console.WriteLine("2 - LISTAR PASSAGENS");
                Console.WriteLine("0 - SAIR\n");
                Console.Write("=> ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\nCadastro de usuários\n");
                        String resposta = "";
                        do
                        {
                            if (contador < 2)
                            {
                                Console.WriteLine("Digite o nome do passageiro: ");
                                nome[contador] = Console.ReadLine();

                                Console.WriteLine("Digite a origem: ");
                                origem[contador] = Console.ReadLine();

                                Console.WriteLine("Digite o destino: ");
                                destino[contador] = Console.ReadLine();

                                Console.WriteLine("Digite a data da viagem: ");
                                data[contador] = DateTime.Parse(Console.ReadLine());

                                Console.WriteLine("\nVocê deseja cadastrar mais um ? S/N");
                                resposta = Console.ReadLine();
                                contador++;

                            }
                            else
                            {
                                Console.WriteLine("Número de passagens exedidas");
                                break;
                            }
                        } while (resposta == "S" || resposta == "s");
                        break;
                    case 2:
                        Console.WriteLine("Listand os passageiros\n");
                        int cont = 0;
                        while (cont < 2)
                        {
                            Console.WriteLine($"Passageiro => {nome[cont]}, origem => {origem[cont]}, destino => {destino[cont]} e data => {data[cont]}");
                            cont++;
                        }
                        break;
                    case 0:
                        // Mensagem de saindo do sistema
                        Console.WriteLine("***Obrigado por usar nosso sistema***");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida !\n");
                        break;
                }
            } while (opcao != 0);

        }
    }
}