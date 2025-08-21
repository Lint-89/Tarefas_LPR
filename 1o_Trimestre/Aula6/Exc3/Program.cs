using System;

class Programa
{
    // Variáveis para armazenar informações de até 5 heróis
    static string nome1 = "", nome2 = "", nome3 = "", nome4 = "", nome5 = "";
    static string poder1 = "", poder2 = "", poder3 = "", poder4 = "", poder5 = "";
    static int pont1 = 0, pont2 = 0, pont3 = 0, pont4 = 0, pont5 = 0;

    // Variáveis para armazenar a escolha da equipe
    static int escolha1 = 0, escolha2 = 0, escolha3 = 0;

    // Função para cadastrar heróis
    static void cadastrarHeroi()
    {
        Console.WriteLine("Cadastro de até 5 heróis:");

        // Cada herói recebe nome, poder e pontuação
        Console.Write("Nome do herói 1: ");
        nome1 = Console.ReadLine();
        Console.Write("Poder do herói 1: ");
        poder1 = Console.ReadLine();
        Console.Write("Pontuação do herói 1: ");
        pont1 = int.Parse(Console.ReadLine());

        Console.Write("Nome do herói 2: ");
        nome2 = Console.ReadLine();
        Console.Write("Poder do herói 2: ");
        poder2 = Console.ReadLine();
        Console.Write("Pontuação do herói 2: ");
        pont2 = int.Parse(Console.ReadLine());

        Console.Write("Nome do herói 3: ");
        nome3 = Console.ReadLine();
        Console.Write("Poder do herói 3: ");
        poder3 = Console.ReadLine();
        Console.Write("Pontuação do herói 3: ");
        pont3 = int.Parse(Console.ReadLine());

        Console.Write("Nome do herói 4: ");
        nome4 = Console.ReadLine();
        Console.Write("Poder do herói 4: ");
        poder4 = Console.ReadLine();
        Console.Write("Pontuação do herói 4: ");
        pont4 = int.Parse(Console.ReadLine());

        Console.Write("Nome do herói 5: ");
        nome5 = Console.ReadLine();
        Console.Write("Poder do herói 5: ");
        poder5 = Console.ReadLine();
        Console.Write("Pontuação do herói 5: ");
        pont5 = int.Parse(Console.ReadLine());
    }

    // Função para selecionar 3 heróis para a equipe
    static void selecionarEquipe()
    {
        Console.WriteLine("Selecione 3 heróis para sua equipe:");

        Console.WriteLine("1 - " + nome1);
        Console.WriteLine("2 - " + nome2);
        Console.WriteLine("3 - " + nome3);
        Console.WriteLine("4 - " + nome4);
        Console.WriteLine("5 - " + nome5);

        Console.Write("Escolha 1: ");
        escolha1 = int.Parse(Console.ReadLine());
        Console.Write("Escolha 2: ");
        escolha2 = int.Parse(Console.ReadLine());
        Console.Write("Escolha 3: ");
        escolha3 = int.Parse(Console.ReadLine());
    }

    // Função que calcula a pontuação total da equipe
    static int pTotal()
    {
        int total = 0;

        if (escolha1 == 1) total += pont1;
        else if (escolha1 == 2) total += pont2;
        else if (escolha1 == 3) total += pont3;
        else if (escolha1 == 4) total += pont4;
        else if (escolha1 == 5) total += pont5;

        if (escolha2 == 1) total += pont1;
        else if (escolha2 == 2) total += pont2;
        else if (escolha2 == 3) total += pont3;
        else if (escolha2 == 4) total += pont4;
        else if (escolha2 == 5) total += pont5;

        if (escolha3 == 1) total += pont1;
        else if (escolha3 == 2) total += pont2;
        else if (escolha3 == 3) total += pont3;
        else if (escolha3 == 4) total += pont4;
        else if (escolha3 == 5) total += pont5;

        return total;
    }

    // Função que exibe os heróis da equipe selecionada
    static void exibirEquipe()
    {
        Console.WriteLine("\nEquipe selecionada:");

        if (escolha1 == 1) Console.WriteLine(nome1 + " - " + poder1);
        else if (escolha1 == 2) Console.WriteLine(nome2 + " - " + poder2);
        else if (escolha1 == 3) Console.WriteLine(nome3 + " - " + poder3);
        else if (escolha1 == 4) Console.WriteLine(nome4 + " - " + poder4);
        else if (escolha1 == 5) Console.WriteLine(nome5 + " - " + poder5);

        if (escolha2 == 1) Console.WriteLine(nome1 + " - " + poder1);
        else if (escolha2 == 2) Console.WriteLine(nome2 + " - " + poder2);
        else if (escolha2 == 3) Console.WriteLine(nome3 + " - " + poder3);
        else if (escolha2 == 4) Console.WriteLine(nome4 + " - " + poder4);
        else if (escolha2 == 5) Console.WriteLine(nome5 + " - " + poder5);

        if (escolha3 == 1) Console.WriteLine(nome1 + " - " + poder1);
        else if (escolha3 == 2) Console.WriteLine(nome2 + " - " + poder2);
        else if (escolha3 == 3) Console.WriteLine(nome3 + " - " + poder3);
        else if (escolha3 == 4) Console.WriteLine(nome4 + " - " + poder4);
        else if (escolha3 == 5) Console.WriteLine(nome5 + " - " + poder5);

        int total = pTotal();
        Console.WriteLine("Pontuação total da equipe: " + total);
    }

    // Função principal com menu
    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Cadastrar heróis");
            Console.WriteLine("2 - Selecionar equipe");
            Console.WriteLine("3 - Exibir equipe");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1) cadastrarHeroi();
            else if (opcao == 2) selecionarEquipe();
            else if (opcao == 3) exibirEquipe();
            else if (opcao == 0) Console.WriteLine("Programa encerrado.");
            else Console.WriteLine("Opção inválida.");

        } while (opcao != 0);
    }
}