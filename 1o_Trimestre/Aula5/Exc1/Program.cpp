#include <iostream>
#include <locale>
using namespace std;

int main() {
    setlocale(LC_ALL, "pt_BR.UTF-8"); // Configura a linguagem para português

    int quantidade, numero, contador = 0; // contador para números pares
    double soma = 0, media;

    // Lê a quantidade de números que o usuário vai digitar
    cout << "Digite a quantidade de números que serão digitados" << endl;
    cin >> quantidade;

    int i = 0;
    while(i < quantidade){ // Laço para ler todos os números
        cout << "Digite um número" << endl;
        cin >> numero;
        i++;

        if(numero % 2 == 0){ // Verifica se é par
            soma += numero;  // Soma os pares
            contador++;      // Conta os pares
        }
    }

    // Calcula e exibe a média se houver pelo menos um número par
    if(contador > 0){
        media = soma / contador;
        cout << "A média dos números pares é: " << media << endl;
    } else {
        cout << "Nenhum número par foi digitado." << endl;
    }
}