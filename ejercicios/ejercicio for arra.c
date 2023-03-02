#include <stdio.h>
/*programa para sumar las columnas de una matriz*/

void main()
{
  
  int A[4][4];/*Arreglo binimensional declaracin*/
  int S[4]; /*Arreglo unimencional que llevara la suma  de la columna*/
  for (int F = 0; F <= 3; F++) 
  {/*ciclos, para organizar y dar valor al arreglo binimencional*/
    for (int C = 0; C <= 3; C++)
    {
      A[F][C] = F + 1; /*crea los valores de la matriz (arreglo binimencional)*/
      printf(" |%d| \t", A[F][C]);/*va imprimiendo la matriz con su valores */
    }
    printf("\n");/*organizar la matriz */
  }

  for (int i = 0; i <= 3; i++) /* */
  {
    S[i]= 0;
    for (int f= 0, c = 0; f<=3, c <= 3; f++,c++)
    {
      S[i] += A[f][c];  /*suma las columnas y se inserta el recultado en el arreglo unimencional S */
    }
    printf(" %d \t",S[i]); /*imprime el resultado de la S, que contiene el resultado */
  }
  
 
}
