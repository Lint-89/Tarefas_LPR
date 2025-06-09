#include <iostream>
#include <locale>
#include <vector>

using namespace std;

int main() {
    setlocale(LC_ALL, "pt_BR.UTF-8");
    vector<int> numeros(10);
    int busca;
    int x = 0;

     cout << "Digite 10 números inteiros:\n" << endl;

    for (int i = 0; i < numeros.size(); i++) {
        cin >> numeros[i];
    }
     cout << "\nDigite o número que deseja buscar no vetor: ";
    cin >> busca;

    for (int i = 0; i < numeros.size(); i++) {
        if (numeros[i] == busca) {
            cout << " O número aparece na posição " << i << endl;
            x++;
        }
    
}
        if(x==0){
        cout << "O número não foi encontrado no vetor." << endl;
    }
    else {
        cout << "O número aparece " << x << " vezes no vetor." << endl;
    }
}