Console.Write("Digite um número inteiro:");

// Lê o valor digitado pelo usuário, converte de string para inteiro e armazena na variável 'x'
int x = int.Parse(Console.ReadLine());

// Verifica se o número é divisível por 2 (ou seja, se é par)
if (x % 2 == 0)
{
    // Se a condição for verdadeira, imprime que o número é par
    Console.WriteLine("O número é par.");
}
else
{
    // Se a condição for falsa, imprime que o número é ímpar
    Console.WriteLine("O número é ímpar.");
}