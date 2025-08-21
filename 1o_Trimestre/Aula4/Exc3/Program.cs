// Exibe opções de classes de personagem
Console.WriteLine("Escolha uma classe de personagem:");
Console.WriteLine("1 - Guerreira");
Console.WriteLine("2 - Mago");
Console.WriteLine("3 - Arqueira");

// Lê a escolha do usuário
Console.Write("Digite o número da sua classe: ");
int escolha = int.Parse(Console.ReadLine());

// Mostra habilidades especiais de acordo com a classe escolhida
Console.WriteLine("\nHabilidades Especiais:");
if (escolha == 1) // Classe Guerreira
{
    Console.WriteLine("- Ataque Pesado");
    Console.WriteLine("- Defesa Total");
}
else if (escolha == 2) // Classe Mago
{
    Console.WriteLine("- Bola de Fogo");
    Console.WriteLine("- Escudo de Gelo");
}
else if (escolha == 3) // Classe Arqueira
{
    Console.WriteLine("- Flecha Precisa");
    Console.WriteLine("- Disparo Triplo");
}
else // Caso o usuário digite um número inválido
{
    Console.WriteLine("Escolha um número válido de 1 a 3");
}