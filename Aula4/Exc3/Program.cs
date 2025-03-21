Console.WriteLine("Escolha uma classe de personagem:");
        Console.WriteLine("1 - Guerreira");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arqueira");
        
        Console.Write("Digite o número da sua classe: ");
        int escolha = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nHabilidades Especiais:");
        if(escolha == 1)
        {
            Console.WriteLine("- Ataque Pesado");
            Console.WriteLine("- Defesa Total");
        }
        else if(escolha == 2)
        {
            Console.WriteLine("- Bola de Fogo");
            Console.WriteLine("- Escudo de Gelo");
        }
        else if(escolha == 3)
        {
            Console.WriteLine("- Flecha Precisa");
            Console.WriteLine("- Disparo Triplo");
        }
        else
        {
            Console.WriteLine("Escolha um número válido de 1 a 3");
        }