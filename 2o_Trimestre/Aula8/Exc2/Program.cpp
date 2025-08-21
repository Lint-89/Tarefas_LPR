#include <iostream>
#include <string>
using namespace std;

// Struct para armazenar informações de um livro
struct Livro {
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    double Preco;
};

int main() {
    Livro livros[3];      // Array para armazenar 3 livros
    double precoTotal = 0; // Soma dos preços
    int somaPaginas = 0;   // Soma do número de páginas

    // Loop para ler os dados dos livros
    for (int i = 0; i < 3; i++) {
        cout << "\nDigite os dados do livro " << (i + 1) << ":\n";

        cout << "Título: ";
        getline(cin, livros[i].Titulo); // Lê o título com espaços

        cout << "Autor: ";
        getline(cin, livros[i].Autor);  // Lê o autor com espaços

        cout << "Ano de publicação: ";
        cin >> livros[i].AnoPublicacao;

        cout << "Número de páginas: ";
        cin >> livros[i].NumeroPaginas;

        cout << "Preço: ";
        cin >> livros[i].Preco;

        precoTotal += livros[i].Preco;       // Acumula preço
        somaPaginas += livros[i].NumeroPaginas; // Acumula páginas

        cin.ignore(); // Limpa o buffer para ler a próxima linha corretamente
    }

    double mediaPaginas = (double)somaPaginas / 3; // Calcula a média de páginas

    // Exibe resultados
    cout << "\nPreço total dos livros: R$ " << precoTotal << endl;
    cout << "Média de páginas: " << mediaPaginas << endl;

    return 0;
}