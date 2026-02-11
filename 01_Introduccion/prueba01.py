#Realizar una multiplicacion en base a sumas den 2 linear
a, b = map(int, input("introduzca la multiplicacion a b: ").split())
print(sum(a for _ in range(b)))