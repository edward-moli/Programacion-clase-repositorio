#include <stdio.h>
/* Paso de una función como parámetro por referencia. */

int Suma( int x, int y)
/* La función Suma regresa la suma de los parámetros de tipo entero
 X y Y. */
 {
    return (x+y);
 }
int resta (int x, int y)
/* La función Suma regresa la suma de los parámetros de tipo entero
X y Y. */
{
    return (x-y);
}
int control(int (*apf) (int, int), int x, int y)
/* Esta función recibe como parámetro otra función —la dirección— y
 dependiendo de cuál sea ésta, llama a la función Suma o Resta. */
{
    int RES;
    RES= (*apf)(x,y); /* Se llama a la función Suma o Resta. */
    return(RES);
}
void main (void)
{
    int R1, R2;
    R1 = Control(Suma, 15, 5); /* Se pasa como parámetro la función Suma. */
R2 = Control(resta, 10, 4); /* Se pasa como parámetro la función Resta.*/
printf("\nResultado 1: %d", R1);
printf("\nResultado 2: %d", R2);
}