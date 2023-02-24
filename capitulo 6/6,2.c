#include <stdio.h>
/* Suma matrices.
El programa, al recibir como datos dos arreglos bidimensionales del mismo
tamaño, calcula la suma de ambos y la almacena en un tercer arreglo
bidimensional. */
const int MAX=50;
/* Prototipo de funciones. */
void Lectura(int[][MAX], int, int );
void Suma (int[][MAX], int[][MAX],int[][MAX], int, int);
void Imprime (int[][MAX], int, int);

void main (void)
{
    int MA[MAX][MAX], MB[MAX][MAX],MC[MAX][MAX];
    /* Declaración de los tres arreglos */
    int FIL, COL;
    do
    {
        printf("Ingrese el numero de filas de los arreglos:");
        scanf("%d",&FIL);
    } 
    while (FIL>MAX || FIL < 1 );
    /* Se verifica que el número de filas sea correcto. */
    do
    {
        printf("Ingrese el numero de columnas de los arreglos:");
        scanf("%d", COL);
    } while (COL>MAX||COL<1);
    /* Se verifica que el número de columnas sea correcto. */
    printf("\nLectura del arreglo MA\n");
    Lectura(MA,FIL,COL);
    printf("\nLectura del arreglo MB\n");
    Lectura(MB, FIL, COL);
    Suma(MA,MB,MC,FIL,COL);
    printf("\nImpresion del arreglo MC\n");
    Imprime(MC,FIL,COL);
}
void Lectura (int A[][MAX],  int F, int C)
/* La función Lectura se utiliza para leer un arreglo bidimensional entero de F
filas y C columnas. */
{
    for (int i = 0; i < F; i++)
    for (int j = 0; j < C; j++)
    {
        printf("Ingrese e; elemento %d %d:", i+1,j+1);
        scanf("%d",&A[i][j]);
    }
    
}
void Suma (int M1[][MAX], int M2[][MAX],int M3[][MAX], int F, int C)
/* La función Suma se utiliza para sumar los arreglos y almacenar el resultado
en un tercer arreglo bidimensional. */
{
    for (int i = 0; i < F; i++)
    for(int J=0; J<C;J++)
    M3[i][J]=M1[i][J]+M2[i][J];
}
void Imprime(int A[][MAX], int F, int C)
/* La función Imprime se utiliza para escribir un arreglo bidimensional de tipo
entero de F filas y C columnas. */
{
int I, J;
for (I=0; I<F; I++)
for (J=0; J<C; J++)
{
printf("\nElemento %d %d: %d", I, J,A[I][J]);
}
}