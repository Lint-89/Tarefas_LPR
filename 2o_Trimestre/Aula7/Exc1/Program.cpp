#include <iostream>
#include <locale>
#include <vector>

using namespace std;

int main() {
    setlocale(LC_ALL, "pt_BR.UTF-8");
    vector<int> numeros(10);
    vector<int> pares;
    vector<int> impares;
    cout << "Insira 10 números inteiros: " << endl;


    for (int i = 0; i < numeros.size(); i++) {
 
        cin >> numeros[i];
        if (numeros[i] % 2 == 0) {
            pares.push_back(numeros[i]);
        }
        else {
            impares.push_back(numeros[i]);
        }
       

    }
     cout << "\nNúmeros pares: ";
    for (int p : pares) {
        cout << p << " ";
    }
     cout << "\nNúmeros ímpares: ";
    for (int i : impares) {
        cout << i << " ";
    }
 }
