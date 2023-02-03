#include<stdio.h>

/*Superficie del triangulo.
El programa, al resivir como datos la base y la altura de un triangulo,
calcula su superfice.

BAS, ALT Y SUP: variables de tipo real.*/

void main (void)
{
    float BAS, ALT, SUP;
    printf("%f %f", &BAS, &ALT);
    SUP = BAS * ALT / 2;
    printf("\nLa superfice del triangulo es:%5.2f", SUP);

}