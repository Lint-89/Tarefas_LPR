#include <iostream>
#include <locale>
#include <random>
using namespace std;

int main() {
    setlocale(LC_ALL, "pt_BR.UTF-8");
    int contador = 0, numero;
    random_device numAleatorio ;
uniform_int_distribution<> distribuicao(1,100);
int valorInteiro = distribuicao(numAleatorio);

do{ 
    cout << "Digite um valor que você ache q é o número";
    cin >> numero;
    contador ++;

    if(numero<valorInteiro){
    cout << "Chutou baixo" << endl;
}else if(numero>valorInteiro){
    cout << "Chutou alto" << endl;
}else{
    cout << "Acertou" << endl;
}

} while (numero != valorInteiro);



if(numero=valorInteiro){
    cout <<" Você acertou em " << contador << " tentativas e o número era " << valorInteiro << endl;
}


}