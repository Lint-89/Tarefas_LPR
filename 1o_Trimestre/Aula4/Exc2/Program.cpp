#include <iostream>
#include <locale>
using namespace std;

int main() {
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int A, B;
    cout << "Digite dois números inteiros: ";
    cin >> A >> B;

    // Verifica se um número é múltiplo do outro
    if (A % B == 0 || B % A == 0) {
        cout << "Eles são multiplos" << endl;
    } else {
        cout << "Eles não são múltiplos" << endl;
    }

    return 0;
}