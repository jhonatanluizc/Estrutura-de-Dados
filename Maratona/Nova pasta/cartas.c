
#include <stdio.h>

int a,b,c;

int main (void) {
  scanf("%d%d%d", &a, &b, &c); // lê as três cartas

  if (a==b)
    printf("%d\n", c);   // se carta A é igual a carta B, resposta é C
  else if (a==c)
    printf("%d\n", b);   // se carta A é igual a carta C, resposta é B
  else
    printf("%d\n", a);   // senão a resposta é A (cartas C e B são iguais)
  return 0;
}
