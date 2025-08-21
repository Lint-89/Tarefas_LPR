// Solicita ao usuário que digite um número inteiro
Console.WriteLine("Insira um número inteiro");
int numero = int.Parse(Console.ReadLine());

// Calcula o quadrado do número
int quadrado = numero * numero;

int soma = 0;

// Soma os dígitos do quadrado
while(quadrado > 0){
    soma += quadrado % 10; // Pega o último dígito e soma
    quadrado /= 10;         // Remove o último dígito
}

// Exibe o resultado
Console.WriteLine("A soma dos dígitos do quadrado do número é: " + soma);