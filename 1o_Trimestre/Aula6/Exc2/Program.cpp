#include <iostream>
#include <locale>
using namespace std;


void mediaPares() {
    setlocale(LC_ALL, "pt_BR.UTF-8");
    int quantidade, numero, contador = 0;
    double media, soma = 0;
    cout << "Digite a quantidade de números que serão digitados" << endl;
    cin >> quantidade;

    int i = 0;
        while(i<quantidade){
            cout <<"Digite um número" << endl;
            cin >> numero;
            i++;
            if(numero%2==0){
                soma += numero;
                contador++;
            }
        }
        if(contador>0){
            media = soma/contador;
        cout << "A média dos números pares é: " << media << endl;
    } else {
        cout << "Nenhum número par foi digitado." << endl;
        }

}

void somaImpares() {
    int soma = 0;

    for(int i = 50; i <= 500; i++){
    
    if(i%2!= 0 && i%3==0)
    {
        soma += i;
    }
    }
    cout << soma << endl;
}

void somaDigitosQuadrado() {
    int numero;
    setlocale(LC_ALL, "pt_BR.UTF-8");
  cout << "Insira um número inteiro" << endl;
 cin >> numero;

 int quadrado = numero * numero;
        int soma = 0;
    while(quadrado>0){

        soma += quadrado % 10; 
          quadrado /=10;
        }
    cout << "A soma dos dígitos do quadrado do número é: " << soma << endl;
}

int main() {
    setlocale(LC_ALL, "pt_BR.UTF-8");
    int opcao;

    do {
        cout << "\n===== MENU =====" << endl;
        cout << "1 - Média dos pares" << endl;
        cout << "2 - Soma dos ímpares múltiplos de 3" << endl;
        cout << "3 - Soma dos dígitos do quadrado" << endl;
        cout << "0 - Sair" << endl;
        cout << "Escolha: ";
        cin >> opcao;

        if (opcao == 1) {
            mediaPares();
        } else if (opcao == 2) {
            somaImpares();
        } else if (opcao == 3) {
            somaDigitosQuadrado();
        }
        else if (opcao == 0) {
            cout << "Programa encerrado" << endl;
        }
        else {
            cout << "Opção inválida." << endl;
        }

    } while (opcao != 0);

    return 0;
}
