using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Solicita o número de pessoas a cadastrar
        Console.Write("Quantas pessoas deseja cadastrar? ");
        int n = int.Parse(Console.ReadLine());

        // Cria um dicionário para armazenar nome e idade
        Dictionary<string, int> pessoas = new Dictionary<string, int>();

        // Loop para cadastrar cada pessoa
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o nome da pessoa #{i + 1}: ");
            string nome = Console.ReadLine();

            Console.Write($"Digite a idade de {nome}: ");
            int idade = int.Parse(Console.ReadLine());

            pessoas[nome] = idade; // Adiciona ou atualiza a idade da pessoa
        }

        // Calcula a média de idade
        double soma = 0;
        foreach (int idade in pessoas.Values)
        {
            soma += idade;
        }
        double media = soma / n;
        Console.WriteLine($"\nIdade média: {media:F2}");

        // Lista pessoas com idade acima da média
        Console.WriteLine("\nPessoas com idade acima da média:");
        foreach (var par in pessoas)
        {
            if (par.Value > media)
            {
                Console.WriteLine($"{par.Key} ({par.Value} anos)");
            }
        }

        // Encontra a pessoa mais velha e mais nova
        string maisVelha = "";
        string maisNova = "";
        int idadeMax = int.MinValue;
        int idadeMin = int.MaxValue;

        foreach (var par in pessoas)
        {
            if (par.Value > idadeMax)
            {
                idadeMax = par.Value;
                maisVelha = par.Key;
            }
            if (par.Value < idadeMin)
            {
                idadeMin = par.Value;
                maisNova = par.Key;
            }
        }

        Console.WriteLine($"\nPessoa mais velha: {maisVelha} ({idadeMax} anos)");
        Console.WriteLine($"Pessoa mais nova: {maisNova} ({idadeMin} anos)");

        // Remove pessoas com idade igual a Y
        Console.Write("\nDigite uma idade Y para remover pessoas: ");
        int Y = int.Parse(Console.ReadLine());

        List<string> remover = new List<string>();
        foreach (var par in pessoas)
        {
            if (par.Value == Y)
            {
                remover.Add(par.Key); // Armazena nomes a remover
            }
        }

        foreach (string nome in remover)
        {
            pessoas.Remove(nome); // Remove do dicionário
        }

        // Exibe o dicionário atualizado
        Console.WriteLine("\nDicionário atualizado:");
        foreach (var par in pessoas)
        {
            Console.WriteLine($"{par.Key}: {par.Value} anos");
        }
    }
}