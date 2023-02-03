#include<stdio.h>
/*El programa, al resivir como dato un conjunto de datos de entrada, invierte el orden el 
de los mismos cuando los imprime.
A, B, C, y D: variables de tipo entero. */

void main (void)
{
    int A, B, C , D;
    printf("INTRODUCE CUATRO DATOS DE TIPO ENTERO: ");
    scanf("%d %d %d %d", &A, &B, &C, &D );
    printf("\n %d %d %d %d",D, C, B, A);
}



