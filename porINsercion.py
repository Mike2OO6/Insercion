
def insercion_a(lista_a):
    for i in range(1, len(lista_a)):
        valor_a_ordenar = lista_a[i]
        while i > 0 and lista_a[i-1] > valor_a_ordenar:
            lista_a[i], lista_a[i-1] = lista_a[i-1], lista_a[i]
            i -= 1
    return lista_a


print(insercion_a([9, 89, 8, 3, 4, 1, 57, 86, 54, 23]))

      


    