using System;

class Program
{
    static void Main()
    {
        // Vetor com nomes das cidades
        string[] cidades = { "Vitória", "Belo Horizonte", "Rio de Janeiro", "São Paulo" };

        // Matriz com distâncias entre as cidades (em km)
        int[,] dist = {
            { 0,   524, 521, 882 },
            { 524,   0, 434, 586 },
            { 521, 434,   0, 429 },
            { 882, 586, 429,   0 }
        };

        int origem, destino;

        do {
            // Mostra as opções de cidades
            Console.WriteLine("\nEscolha as cidades digitando o número correspondente:");
            Console.WriteLine("0 - Vitória");
            Console.WriteLine("1 - Belo Horizonte");
            Console.WriteLine("2 - Rio de Janeiro");
            Console.WriteLine("3 - São Paulo");

            // Lê cidade de origem e destino
            Console.Write("\nOrigem: ");
            origem = int.Parse(Console.ReadLine());
            Console.Write("Destino: ");
            destino = int.Parse(Console.ReadLine());

            // Exibe a distância se origem e destino forem diferentes
            if (origem != destino) {
                Console.WriteLine("A distância entre " + cidades[origem] +
                    " e " + cidades[destino] +
                    " é " + dist[origem, destino] + " km\n");
            }

        } while (origem != destino); // Repete até que origem e destino sejam iguais

        Console.WriteLine("\nPrograma encerrado, origem e destino são iguais.");
    }
}