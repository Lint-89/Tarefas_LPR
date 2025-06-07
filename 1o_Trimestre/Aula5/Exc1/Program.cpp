#include <iostream>
#include <locale>

using namespace std;

int main() {
    setlocale(LC_ALL, "pt_BR.UTF-8");
    
    int quantidade, numero, contador = 0;
    double media, soma = 0;
    cout << "Digite a quantidade de números que serão digitados" << endl;
    cin >> quantidade;

    int i = 0;
        while(i<quantidade){
            cout <<"Digite um número" << endl;
            cin >> numero;
            i++;
            if(numero%2==0){
                soma += numero;
                contador++;
            }
        }
        
        
        if(contador>0){
            media = soma/contador;
        cout << "A média dos números pares é: " << media << endl;
    } else {
        cout << "Nenhum número par foi digitado." << endl;
        }

    }
