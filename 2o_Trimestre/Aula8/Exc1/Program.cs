using System.Globalization;

// Struct para armazenar dados de um produto
struct Produto {
    public string Nome;
    public int Codigo;
    public double Preco;
    public int Quantidade;
}

class Program {
    static void Main() {
        Produto[] produtos = new Produto[3]; // Array para armazenar 3 produtos
        double totalEstoque = 0;             // Variável para calcular o valor total do estoque

        // Loop para ler os dados dos produtos
        for (int i = 0; i < 3; i++) {
            Console.WriteLine("\nDigite os dados do produto " + (i + 1) + ":");

            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Código: ");
            produtos[i].Codigo = int.Parse(Console.ReadLine());

            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());
        }

        // Calcula o valor total do estoque
        for (int i = 0; i < 3; i++) {
            totalEstoque += produtos[i].Preco * produtos[i].Quantidade;
        }

        // Exibe o valor total do estoque
        Console.WriteLine("\nValor total em estoque: R$ " + totalEstoque);
    }
}