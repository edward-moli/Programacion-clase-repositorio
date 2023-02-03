#include <stdio.h>
#include<stdlib.h>

int main()
{ 
    char nombre [20];
    int edad = 0;
    printf("\ncual es tu nombre:");
    scanf("%s",nombre);

    printf("\ncual es tu edad: ");
    scanf("@d",&edad);

    printf("\nHola %s biembenido al curso",nombre);
    return 0;
}