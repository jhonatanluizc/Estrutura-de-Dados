#include <stdio.h>
#define MAX 1000

int n;
int a[MAX];  // vamos usar um vetor para facilitar, mas apenas porque
             // o enunciado diz que a sequência tem poucos elementos (no máximo 1000)
             // se o vetor fosse muito grande, a melhor solução seria usar apenas três variáveis
             // para percorrer a sequência de valores
int main(void) {
  int i;

  scanf("%d",&n);              // lê valor de N
  for (i=0; i<n; i++) {
    scanf("%d", &a[i]);        // lê os valores da sequência e armazena no vetor
  }
  for (i=2; i<n; i++) {        // agora percorre o vetor, verificando a condição de dois picos
    if (a[i-2]>a[i-1] && a[i]>a[i-1]) {
      printf("S\n");           // montanha tem dois picos, nem precisa verificar o restante da sequência
      return 0;
    }
  }
  printf("N\n");               // se chegou aqui, montanha tem um pico
  return 0;
}
