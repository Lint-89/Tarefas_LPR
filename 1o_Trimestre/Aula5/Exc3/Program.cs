int soma = 0;

// Percorre todos os números de 50 a 500
for(int i = 50; i <= 500; i++){
    
    // Verifica se o número é ímpar e múltiplo de 3
    if(i % 2 != 0 && i % 3 == 0){
        soma += i; // Soma o número que atende às duas condições
    }
}

// Exibe a soma total
Console.WriteLine(soma);