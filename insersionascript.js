function insercionA(listaA) {
    for (let i = 1; i < listaA.length; i++) {
        let valorAOrdenar = listaA[i];
        let j = i;
        while (j > 0 && listaA[j - 1] > valorAOrdenar) {
            listaA[j] = listaA[j - 1];
            j--;
        }
        listaA[j] = valorAOrdenar;
    }
    return listaA;
}

let datos = [99999999999,777777,33,2,4,56,67,78,9,56,343,34,5,435,3];
let ordenados = insercionA(datos);
console.log(ordenados);