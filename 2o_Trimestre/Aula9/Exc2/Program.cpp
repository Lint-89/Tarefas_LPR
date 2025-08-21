#include <iostream>
#include <vector>
#include <algorithm>
#include <set>
#include <cstdlib>
#include <ctime>

using namespace std;

int main() {
    const int tamanho = 100;
    vector<int> numeros(tamanho);

    srand(time(0));

    // Preenche o vetor com números aleatórios de 1 a 200
    for (int i = 0; i < tamanho; i++) {
        numeros[i] = rand() % 200 + 1;
    }

    // Ordena o vetor
    sort(numeros.begin(), numeros.end());

    // Exibe a lista ordenada
    cout << "Lista ordenada:\n";
    for (int num : numeros) {
        cout << num << " ";
    }
    cout << "\n\n";

    // Exibe apenas os números ímpares
    cout << "Lista com números ímpares:\n";
    for (int num : numeros) {
        if (num % 2 != 0) {
            cout << num << " ";
        }
    }
    cout << "\n\n";

    // Identifica e exibe números repetidos
    cout << "Números repetidos:\n";
    set<int> repetidos; // Armazena os números que aparecem mais de uma vez
    for (size_t i = 1; i < numeros.size(); i++) {
        if (numeros[i] == numeros[i - 1]) {
            repetidos.insert(numeros[i]);
        }
    }

    if (repetidos.empty()) {
        cout << "Nenhum número se repete.";
    } else {
        for (int num : repetidos) {
            cout << num << " ";
        }
    }
    cout << endl;

    return 0;
}