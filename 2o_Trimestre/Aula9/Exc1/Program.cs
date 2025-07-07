Console.WriteLine("Digite a quantidade de nomes que vai estar na lista:");
int quantidade = int.Parse(Console.ReadLine());
List<string> nomes = new List<string>();
for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine($"Digite o nome {i + 1}:");
    string nome = Console.ReadLine();
    nomes.Add(nome);
}
foreach (string nome in nomes)
{
    
}