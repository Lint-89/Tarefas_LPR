#include <iostream>
#include <locale>
#include <vector>
using namespace std;

int main() {
    setlocale(LC_ALL, "pt_BR.UTF-8");

    vector<int> numeros(10); // Vetor para armazenar 10 números
    int busca;               // Número que será buscado
    int x = 0;               // Contador de ocorrências

    cout << "Digite 10 números inteiros:\n" << endl;

    // Lê os 10 números do usuário
    for (int i = 0; i < numeros.size(); i++) {
        cin >> numeros[i];
    }

    // Solicita o número que deseja buscar
    cout << "\nDigite o número que deseja buscar no vetor: ";
    cin >> busca;

    // Percorre o vetor para encontrar o número
    for (int i = 0; i < numeros.size(); i++) {
        if (numeros[i] == busca) {
            cout << "O número aparece na posição " << i << endl; // Mostra a posição
            x++; // Conta a ocorrência
        }
    }

    // Exibe resultado final
    if(x == 0){
        cout << "O número não foi encontrado no vetor." << endl;
    } else {
        cout << "O número aparece " << x << " vezes no vetor." << endl;
    }
}