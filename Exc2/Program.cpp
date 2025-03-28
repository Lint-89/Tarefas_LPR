#include <iostream>

using namespace std;

int main() {
    int A, B;
    cout << "Digite dois números inteiros: ";
    cin >> A >> B;
    
    if (A % B == 0 || B % A == 0) {
        cout << "Eles são multiplos" << endl;
    } else {
        cout << "Eles não são múltiplos" << endl;
    }
    
    return 0;
}
