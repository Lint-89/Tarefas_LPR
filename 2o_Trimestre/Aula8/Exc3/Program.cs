using System;

namespace MarvelEquipe
{
    class Program
    {
        // Struct para armazenar dados de cada herói
        struct Heroi
        {
            public string nome;
            public string poder;
            public int pontuacao;
        }

        static void Main(string[] args)
        {
            menuPrincipal(); // Chama o menu principal
        }

        static void menuPrincipal()
        {
            Heroi[] herois = new Heroi[5]; // Array de heróis cadastrados
            Heroi[] equipe = new Heroi[3]; // Array da equipe selecionada
            int totalHeroisCadastrados = 0;
            bool equipeSelecionada = false;

            while (true)
            {
                // Exibe menu
                Console.WriteLine("\n--- MENU PRINCIPAL ---");
                Console.WriteLine("1 - Cadastrar Heróis");
                Console.WriteLine("2 - Selecionar Equipe");
                Console.WriteLine("3 - Exibir Equipe");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        totalHeroisCadastrados = cadastrarHeroi(herois, totalHeroisCadastrados);
                        break;
                    case "2":
                        equipeSelecionada = selecionarEquipe(herois, totalHeroisCadastrados, equipe);
                        break;
                    case "3":
                        if (equipeSelecionada)
                            exibirEquipe(equipe);
                        else
                            Console.WriteLine("Nenhuma equipe selecionada ainda!");
                        break;
                    case "4":
                        Console.WriteLine("Saindo do programa");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        // Função para cadastrar heróis
        static int cadastrarHeroi(Heroi[] herois, int totalCadastrados)
        {
            if (totalCadastrados >= herois.Length)
            {
                Console.WriteLine("Limite de heróis cadastrados atingido!");
                return totalCadastrados;
            }

            Console.Write("Nome do herói: ");
            herois[totalCadastrados].nome = Console.ReadLine();

            Console.Write("Poder do herói: ");
            herois[totalCadastrados].poder = Console.ReadLine();

            Console.Write("Pontuação do herói: ");
            herois[totalCadastrados].pontuacao = int.Parse(Console.ReadLine());

            totalCadastrados++;
            Console.WriteLine("Herói cadastrado com sucesso!\n");

            return totalCadastrados;
        }

        // Função para selecionar a equipe de 3 heróis
        static bool selecionarEquipe(Heroi[] herois, int totalCadastrados, Heroi[] equipe)
        {
            if (totalCadastrados < 3)
            {
                Console.WriteLine("Cadastre pelo menos 3 heróis antes de formar a equipe!");
                return false;
            }

            Console.WriteLine("\n--- Heróis Cadastrados ---");
            for (int i = 0; i < totalCadastrados; i++)
            {
                Console.WriteLine($"{i + 1} - {herois[i].nome} (Poder: {herois[i].poder}, Pontuação: {herois[i].pontuacao})");
            }

            Console.WriteLine("\nSelecione 3 heróis para a equipe:");
            for (int i = 0; i < equipe.Length; i++)
            {
                int escolha;
                do
                {
                    Console.Write($"Escolha o herói nº{i + 1}: ");
                    escolha = int.Parse(Console.ReadLine());
                    if (escolha < 1 || escolha > totalCadastrados)
                        Console.WriteLine("Escolha inválida!");
                } while (escolha < 1 || escolha > totalCadastrados);

                equipe[i] = herois[escolha - 1]; // Salva o herói escolhido na equipe
            }

            Console.WriteLine("Equipe selecionada com sucesso!");
            return true;
        }

        // Calcula a pontuação total da equipe
        static int calcularPontuacaoTotal(Heroi[] equipe)
        {
            int total = 0;
            for (int i = 0; i < equipe.Length; i++)
            {
                total += equipe[i].pontuacao;
            }
            return total;
        }

        // Exibe a equipe selecionada com suas pontuações
        static void exibirEquipe(Heroi[] equipe)
        {
            Console.WriteLine("\n--- Equipe Selecionada ---");
            for (int i = 0; i < equipe.Length; i++)
            {
                Console.WriteLine($"{equipe[i].nome} - Poder: {equipe[i].poder} - Pontuação: {equipe[i].pontuacao}");
            }
            Console.WriteLine($"Pontuação Total da Equipe: {calcularPontuacaoTotal(equipe)}");
        }
    }
}