using System;

namespace AtividadeBanco
{
    class Program
    {
        const int tamanho = 10;
        static string[] fila = new string[tamanho];
        static int fim = 0;

        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("\n1 - Inserir o Cliente");
                Console.WriteLine("2 - Inserir cliente prioritário");
                Console.WriteLine("3 - Listar fila");
                Console.WriteLine("4 - Atender o Cliente");
                Console.WriteLine("q - Sair");
                Console.Write("Escolha: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": InserirCliente(); break;
                    case "2": InserirPrioritario(); break;
                    case "3": ListarFila(); break;
                    case "4": AtenderCliente(); break;
                    case "q": Console.WriteLine("Saindo..."); break;
                    default: Console.WriteLine("Opção inválida!"); break;
                }
            } while (opcao != "q");
        }

        static void InserirCliente()
        {
            if (fim >= tamanho) { Console.WriteLine("A Fila esta cheia!"); return; }
            Console.Write("Nome do cliente: ");
            fila[fim++] = Console.ReadLine();
            Console.WriteLine("Cliente adicionado.");
        }

        static void InserirPrioritario()
        {
            if (fim >= tamanho) { Console.WriteLine("A Fila esta cheia!"); return; }
            Console.Write("Nome do cliente prioritário: ");
            string nome = Console.ReadLine();

         
            for (int i = fim; i > 0; i--) fila[i] = fila[i - 1];
            fila[0] = nome;
            fim++;
            Console.WriteLine("Cliente prioritário adicionado.");
        }

        static void ListarFila()
        {
            Console.WriteLine("\nFila atual:");
            if (fim == 0) { Console.WriteLine("A Fila esta vazia."); return; }
            for (int i = 0; i < fim; i++) Console.WriteLine($"{i + 1}. {fila[i]}");
        }

        static void AtenderCliente()
        {
            if (fim == 0) { Console.WriteLine("A Fila esta vazia."); return; }
            Console.WriteLine($"Atendendo: {fila[0]}");

           
            for (int i = 0; i < fim - 1; i++) fila[i] = fila[i + 1];
            fim--;
        }
    }
}
