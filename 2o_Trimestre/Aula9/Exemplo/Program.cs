List<int> numeros = new List<int>{1,2,3,4,5};
numeros.Add(4);
numeros.Insert(2, 7);
bool contem = numeros.Contains(8);
if (contem == true)
{
    Console.WriteLine("O número 8 está na lista.");
}
else
{
    Console.WriteLine("O número 8 não está na lista.");
}
int maior = 0;
foreach (int numero in numeros)
{
    if (numero > 4)
    {
        maior++;
    }
}
numeros.Remove(2);
Console.WriteLine("Quantidade de números maiores que 4: " + maior);
int repeat = 0;
foreach (int numero in numeros)
{
    if (numero == 3)
    {
        repeat++;
    }
}
while (numeros.Contains(4))
{
    numeros.Remove(4);
}
Console.WriteLine("Lista atualizada:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
