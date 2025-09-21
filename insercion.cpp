#include <iostream>
#include <vector>
using namespace std;

vector<int> insercion_a(vector<int> lista_a) {
    for (int i = 1; i < lista_a.size(); i++) {
        int valor_a_ordenar = lista_a[i];
        int j = i;
        while (j > 0 && lista_a[j - 1] > valor_a_ordenar) {
            lista_a[j] = lista_a[j - 1];
            j--;
        }
        lista_a[j] = valor_a_ordenar;
    }
    return lista_a;
}

int main() {
    vector<int> datos = {9, 89, 8, 3, 4, 1, 57, 86, 54, 23};
    vector<int> ordenados = insercion_a(datos);

    for (int num : ordenados) {
        cout << num << " ";
    }
    cout << endl;
    return 0;
}