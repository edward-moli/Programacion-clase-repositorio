#include<stdio.h>

/*El programa dice el numero de bity que consume el programa*/

struct 
{
   float promedio;
   char nombre[21];
}alunmo;

void main (void)
{

  printf("Imprime, cuanto byte tiene los datos de alumno: %d",sizeof(alunmo));
  
}


