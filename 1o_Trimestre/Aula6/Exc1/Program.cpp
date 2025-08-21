#include <iostream>
#include <locale>
using namespace std;

// Função para reverter um número positivo
int reverterNumero(int n) {
    int r = 0;

    while (n > 0) {
        int x = n % 10;    // Pega o último dígito
        r = r * 10 + x;    // Adiciona o dígito na posição correta do número invertido
        n = n / 10;        // Remove o último dígito
    }

    return r;
}

int main() {
    setlocale(LC_ALL, "pt_BR.UTF-8");
    int numero;

    cout << "Digite um número: ";
    cin >> numero;

    // Verifica se o número é positivo
    if(numero < 0) {
        cout << "Número inválido, digite um número positivo." << endl;
        return 0;
    }

    // Chama a função para inverter o número
    int resultado = reverterNumero(numero);

    // Exibe o resultado
    cout << "Número invertido: " << resultado << endl;

    return 0;
}