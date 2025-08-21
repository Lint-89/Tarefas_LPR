using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário a quantidade de nomes
        Console.Write("Quantos nomes deseja digitar? ");
        int n = int.Parse(Console.ReadLine());

        string[] nomes = new string[n]; // Array para armazenar os nomes

        // Lê os nomes do usuário
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o nome #{i + 1}: ");
            nomes[i] = Console.ReadLine();
        }

        // Determina o tamanho máximo entre os nomes
        int maxLength = 0;
        for (int i = 0; i < n; i++)
        {
            if (nomes[i].Length > maxLength)
                maxLength = nomes[i].Length;
        }

        int[] exibidos = new int[maxLength + 1]; // Controla quantos nomes de cada tamanho já foram exibidos
        bool aindaHaNomes = true;

        Console.WriteLine("\n--- Nomes Ordenados por Tamanho ---");

        // Enquanto houver nomes não exibidos
        while (aindaHaNomes)
        {
            aindaHaNomes = false;

            // Verifica nomes de cada tamanho
            for (int tamanho = 1; tamanho <= maxLength; tamanho++)
            {
                int cont = 0;
                for (int i = 0; i < n; i++)
                    if (nomes[i].Length == tamanho)
                        cont++;

                // Se ainda há nomes desse tamanho não exibidos
                if (exibidos[tamanho] < cont)
                {
                    int mostrados = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (nomes[i].Length == tamanho)
                        {
                            // Exibe o próximo nome que ainda não foi mostrado
                            if (mostrados == exibidos[tamanho])
                            {
                                Console.Write(nomes[i] + " ");
                                exibidos[tamanho]++;
                                aindaHaNomes = true;
                                break;
                            }
                            mostrados++;
                        }
                    }
                }
            }

            Console.WriteLine(); // Quebra de linha após exibir todos os nomes possíveis na rodada
        }
    }
}