#include <stdio.h>
/* Prueba de parámetros por valor. */
int f1 (int); /* Prototipo de función. El parámetro es por valor y de tipo entero. */
void main(void)
{
    int i,k=4;
    for ( i = 1; i <=3; i++)
    {printf("\n\nValor de K antes de llamar a la funciOn: %d",++k);
printf("\nValor de K despues de llamar a la funcion: %d", f1(k));
/* Llamada a la función f1. Se pasa una copia de la variable K.*/
    
    }
    
}
int f1 (int R)
{
    R +=R;
    return(R);

}