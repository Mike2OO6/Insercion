import java.util.Arrays;

public class InsercionA {
    public static int[] insercionA(int[] listaA) {
        for (int i = 1; i < listaA.length; i++) {
            int valorAOrdenar = listaA[i];
            int j = i;
            while (j > 0 && listaA[j - 1] > valorAOrdenar) {
                listaA[j] = listaA[j - 1];
                j--;
            }
            listaA[j] = valorAOrdenar;
        }
        return listaA;
    }

    public static void main(String[] args) {
        int[] datos = {55555,6,666,6,7,78,8,8,5,4,3,34,43,43,5,56,5,6};
        int[] ordenados = insercionA(datos);

        System.out.println(Arrays.toString(ordenados));
    }
}