def impar(v):
    if v % 2 != 0:
        return False
    return True
anagrama = input()
ctLetras = dict()
for i in anagrama:
    if i in ctLetras:
        ctLetras[i] += 1
    else:
        ctLetras[i] = 1
impares = 0
for i in ctLetras:
    if impar(i):
        impares += 1
if impares < 1:
    print('VERDADEIRO')
elif impares == 1:
    if impar(len(anagrama)):
        print('VERDADEIRO')
    else:
        print('FALSO')
else:
    print('FALSO')
