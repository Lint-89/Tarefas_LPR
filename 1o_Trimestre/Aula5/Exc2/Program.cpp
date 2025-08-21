#include <iostream>
#include <locale>
#include <random>

using namespace std;

int main() {
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int contador = 0, numero;

    // Cria um número aleatório entre 1 e 100
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1, 100);
    int valorInteiro = distribuicao(numAleatorio);

    // Laço para o jogador chutar o número
    do {
        cout << "Digite um valor que você ache que é o número: ";
        cin >> numero;
        contador++;

        if (numero < valorInteiro) {
            cout << "Chutou baixo" << endl;
        } else if (numero > valorInteiro) {
            cout << "Chutou alto" << endl;
        } else {
            cout << "Acertou" << endl;
        }

    } while (numero != valorInteiro); // Continua até o jogador acertar

    // Exibe o número de tentativas e o número sorteado
    cout << "Você acertou em " << contador << " tentativas e o número era " << valorInteiro << endl;

    return 0;
}