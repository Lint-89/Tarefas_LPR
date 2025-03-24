Console.WriteLine("Insira um número inteiro");
 int numero = int.Parse(Console.ReadLine());

 int quadrado = numero * numero;
        int soma = 0;

    while(quadrado>0){

        soma += quadrado % 10; 
          quadrado /=10;
        }
        
        Console.WriteLine("A soma dos dígitos do quadrado é: " + soma);
    
        
    