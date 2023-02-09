#include <stdio.h>
/* Prueba de variables globales, locales y estáticas.
El programa utiliza funciones en las que se usan diferentes tipos de
 variables. */
 int f1 (void);                   /* Prototipos de funciones. */
 int f2(void);
 int f3(void);
 int f4(void);
 void main (void)
{
    int I;
    for (I=1; I<=3;I++)
    {
        printf("\nEl resultado de la función f1 es: %d", f1());
printf("\nEl resultado de la función f2 es: %d", f2());
printf("\nEl resultado de la función f3 es: %d", f3());
printf("\nEl resultado de la función f4 es: %d", f4());

    }
}
int f1 (void)
/* La función f1 utiliza la variable global. */
{
    
    k +=k;
    return(k);
}

int f2(void)/* La función f2 utiliza la variable local. */

{
    int k=1;
    k++;
    return(k);
}
int f3 (void)
/* La función f3 utiliza la variable estática. */
{
    static int k=8;
    k+=2;
    return(k);
}
int f4(void)
/* La función f4 utiliza dos variables con el mismo nombre: local
 y global. */
{
    int k=5;
    k=k+ :: k;     /* Uso de la variable local (K) y global (::K) */
    return(k);
}