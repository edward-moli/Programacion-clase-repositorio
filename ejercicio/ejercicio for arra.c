#include <stdio.h>
/*programa para sumar las columnas de una matriz*/

void main()
{
  int SUMA;
  SUMA = 0;
  int A[4][4];
  int S[4];
  for (int F = 0; F <= 3; F++)
  {
    for (int C = 0; C <= 3; C++)
    {
      A[F][C] = F + 1;
      printf(" |%d| \t", A[F][C]);
    }
    printf("\n");
  }

  for (int i = 0; i <= 3; i++)
  {
    S[i]= 0;
    for (int f= 0, c = 0; f<=3, c <= 3; f++,c++)
    {
      S[i] += A[f][c];
    }
    printf(" %d \t",S[i]);
  }
  // CORRER Y SUMAR
  //
  printf("\nimprime resultado", SUMA);
}
