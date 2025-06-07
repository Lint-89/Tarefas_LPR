#include <iostream>
#include <locale>
using namespace std;

int reverterNumero(int n) {
    int r= 0;

    while (n > 0) {
        int x = n % 10;
        r = r * 10 + x;
        n = n / 10;
    }

    return r;
}

int main() {
    setlocale(LC_ALL, "pt_BR.UTF-8");
    int numero;

    cout << "Digite um número: ";
    cin >> numero;
if(numero < 0) {
        cout << "Número inválido, digite um número positivo." << endl;
        return 0;
    }
    int resultado = reverterNumero(numero);

    cout << "Número invertido: " << resultado << endl;

    return 0;
}