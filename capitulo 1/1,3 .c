#include<stdio.h>
/*El programa al recibir como dato seis sueldos de un empleado, calcula tanto el 
el ingreso toal como el prmedio mensual.

CLA:variable de tipo entero.
SU1, SU2, SU3, SU4 , SU5 , SU6 ING, PRO : variables de tipo real.  */
void main (void)
{
    int CLA;
    float SU1 , SU2 , SU3 , SU4 , SU5 , SU6 , ING , PRO;
    printf("ingrese la clave del empreado y los 6 sueldos: \n");
    scanf("%d %f %f %f %f %f %f", &CLA, &SU1, &SU2, &SU3, &SU4, &SU5, &SU6);
    ING = (SU1 + SU2 + SU3 + SU4 + SU5 + SU6);
    PRO = ING / 6;
    printf ("\n %d %5.2f %5.2f", CLA, ING, PRO);
}