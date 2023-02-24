#include <stdio.h>
/* Cubo-1.
El programa calcula el cubo de los 10 primeros números naturales con la
ayuda de una función. En la solución del problema se utiliza una variable
global, aunque esto, como veremos más adelante, no es muy recomendable. */

int cubo(int); 
int sumain(int a, int b);   /*Prototipo de funcion.*/
int CUBb(int*);            
void main (void)
{
    int I;
    int B;
    int r;
    int num;
    int CUB;
 int CUBr;
 for ( I = 1; B=100;I <=10; I++, B--)
 {
I=sumain(I,B);
CUB= cubo(I);       /* Llamada a la funcion cubo. */
printf("\n El cubo de %i es: %i", I, CUB);
printf("\n El suma de %i mas %i es: %i", I, B,r);
 }
}
int cubo (int a)   /* Declaración de la función. */
/* La función calcula el cubo de la variable global I. */
{
    return(a*a*a);
}
int Sumain(int a,int b )
{
    return a+b;
}