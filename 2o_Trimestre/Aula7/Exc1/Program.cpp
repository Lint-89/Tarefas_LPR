#include <iostream>
#include <locale>
#include <vector>
using namespace std;

int main() {
    setlocale(LC_ALL, "pt_BR.UTF-8");

    vector<int> numeros(10); // Vetor para armazenar 10 números
    vector<int> pares;       // Vetor para armazenar números pares
    vector<int> impares;     // Vetor para armazenar números ímpares

    cout << "Insira 10 números inteiros: " << endl;

    // Lê os números e separa em pares e ímpares
    for (int i = 0; i < numeros.size(); i++) {
        cin >> numeros[i];
        if (numeros[i] % 2 == 0) {
            pares.push_back(numeros[i]);
        } else {
            impares.push_back(numeros[i]);
        }
    }

    // Exibe os números pares
    cout << "\nNúmeros pares: ";
    for (int p : pares) {
        cout << p << " ";
    }

    // Exibe os números ímpares
    cout << "\nNúmeros ímpares: ";
    for (int i : impares) {
        cout << i << " ";
    }
}