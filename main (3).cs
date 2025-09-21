using System;
using System.Collections.Generic;

class Program
{
    static List<int> InsercionA(List<int> listaA)
    {
        for (int i = 1; i < listaA.Count; i++)
        {
            int valorAOrdenar = listaA[i];
            int j = i;
            while (j > 0 && listaA[j - 1] > valorAOrdenar)
            {
                listaA[j] = listaA[j - 1];
                j--;
            }
            listaA[j] = valorAOrdenar;
        }
        return listaA;
    }

    static void Main()
    {
        List<int> datos = new List<int> { 9, 89, 8, 3, 4, 1, 57, 86, 54, 23 };
        List<int> ordenados = InsercionA(datos);

        foreach (int num in ordenados)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
    
