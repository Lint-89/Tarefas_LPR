#include <iostream>
#include <locale>
using namespace std;

// Função que calcula a média dos números pares digitados pelo usuário
void mediaPares() {
    setlocale(LC_ALL, "pt_BR.UTF-8");
    int quantidade, numero, contador = 0;
    double soma = 0, media;

    cout << "Digite a quantidade de números que serão digitados" << endl;
    cin >> quantidade;

    int i = 0;
    while(i < quantidade){
        cout << "Digite um número" << endl;
        cin >> numero;
        i++;
        if(numero % 2 == 0){ // Soma apenas os pares
            soma += numero;
            contador++;
        }
    }

    if(contador > 0){
        media = soma / contador;
        cout << "A média dos números pares é: " << media << endl;
    } else {
        cout << "Nenhum número par foi digitado." << endl;
    }
}

// Função que soma os números ímpares múltiplos de 3 entre 50 e 500
void somaImpares() {
    int soma = 0;

    for(int i = 50; i <= 500; i++){
        if(i % 2 != 0 && i % 3 == 0){
            soma += i;
        }
    }

    cout << "A soma dos ímpares múltiplos de 3 é: " << soma << endl;
}

// Função que soma os dígitos do quadrado de um número
void somaDigitosQuadrado() {
    int numero;
    setlocale(LC_ALL, "pt_BR.UTF-8");

    cout << "Insira um número inteiro" << endl;
    cin >> numero;

    int quadrado = numero * numero;
    int soma = 0;

    while(quadrado > 0){
        soma += quadrado % 10; // Soma o último dígito
        quadrado /= 10;        // Remove o último dígito
    }

    cout << "A soma dos dígitos do quadrado do número é: " << soma << endl;
}

// Função principal com menu de opções
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
        } else if (opcao == 0) {
            cout << "Programa encerrado" << endl;
        } else {
            cout << "Opção inválida." << endl;
        }

    } while (opcao != 0);

    return 0;
}