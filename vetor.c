#include <stdio.h>
#include <stdlib.h>
int main(void)
{
    int *v;
    int i, tam;

    printf("tamanho do vetor\n");
    scanf("%d", &tam);

    v = (int *) malloc(tam * sizeof(int));

    for (i = 0; i < tam; i++)
    {
        printf("\nvetor[%d] = ", i);
        scanf("%d",&v[i]);
    }

    for (i = 0; i < tam; i++)
    {
        printf("%d\n",v[i]);
    }

    free(v);
    return 0;
}
