#include <iostream>
#include <map>
#include <string>
using namespace std;

int main() {
    int n;
    cout << "Quantas cidades deseja cadastrar? ";
    cin >> n;
    cin.ignore(); // Limpa o buffer para usar getline em seguida

    map<string, int> cidades; // Dicionário de cidades e suas populações

    // Cadastro das cidades
    for (int i = 0; i < n; i++) {
        string nome;
        int populacao;
        cout << "Digite o nome da cidade #" << i + 1 << ": ";
        getline(cin, nome);
        cout << "Digite a população de " << nome << ": ";
        cin >> populacao;
        cin.ignore();

        cidades[nome] = populacao; // Adiciona ou atualiza a cidade
    }

    // Calcula a população média
    double soma = 0;
    for (auto &par : cidades) {
        soma += par.second;
    }
    double media = soma / n;
    cout << "\nPopulação média: " << media << endl;

    // Exibe cidades com população acima da média
    cout << "\nCidades com população acima da média:\n";
    for (auto &par : cidades) {
        if (par.second > media) {
            cout << par.first << " (" << par.second << " habitantes)\n";
        }
    }

    // Identifica a cidade mais e menos populosa
    string maisPopulosa, menosPopulosa;
    int popMax = INT_MIN, popMin = INT_MAX;

    for (auto &par : cidades) {
        if (par.second > popMax) {
            popMax = par.second;
            maisPopulosa = par.first;
        }
        if (par.second < popMin) {
            popMin = par.second;
            menosPopulosa = par.first;
        }
    }

    cout << "\nCidade mais populosa: " << maisPopulosa << " (" << popMax << " habitantes)" << endl;
    cout << "Cidade menos populosa: " << menosPopulosa << " (" << popMin << " habitantes)" << endl;

    // Remove cidades com população igual a Y
    int Y;
    cout << "\nDigite uma população Y para remover cidades: ";
    cin >> Y;

    string nomesParaRemover[100]; // Array temporário para armazenar nomes a remover
    int cont = 0;
    for (auto &par : cidades) {
        if (par.second == Y) {
            nomesParaRemover[cont++] = par.first;
        }
    }

    for (int i = 0; i < cont; i++) {
        cidades.erase(nomesParaRemover[i]); // Remove do dicionário
    }

    // Exibe o dicionário atualizado
    cout << "\nDicionário atualizado:\n";
    for (auto &par : cidades) {
        cout << par.first << ": " << par.second << " habitantes\n";
    }

    return 0;
}