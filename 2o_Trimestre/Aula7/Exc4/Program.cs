using System;

class Program
{
    static void Main()
    {
        int[,] A = new int[3, 3]; // Matriz A 3x3
        int[,] B = new int[3, 3]; // Matriz B 3x3
        int[,] C = new int[3, 3]; // Matriz C para armazenar o resultado ( que também é 3x3)

        // Lê os valores da matriz A
        Console.WriteLine("Digite os valores da matriz A (3x3):");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write("A[" + i + "," + j + "]: ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Lê os valores da matriz B
        Console.WriteLine("\nDigite os valores da matriz B (3x3):");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write("B[" + i + "," + j + "]: ");
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Multiplicação de matrizes A * B = C
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                int soma = 0;
                soma += A[i,0] * B[0,j];
                soma += A[i,1] * B[1,j];
                soma += A[i,2] * B[2,j];
                C[i,j] = soma;
            }
        }

        // Exibe a matriz resultante C
        Console.WriteLine("\nMatriz C = A * B:");
        Console.WriteLine(C[0,0] + "\t" + C[0,1] + "\t" + C[0,2]);
        Console.WriteLine(C[1,0] + "\t" + C[1,1] + "\t" + C[1,2]);
        Console.WriteLine(C[2,0] + "\t" + C[2,1] + "\t" + C[2,2]);
    }
}