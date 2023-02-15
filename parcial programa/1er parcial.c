#include<stdio.h>
/*Dos arreglo se suman,el primer numero del primer arreglo con el segundo numero del ultimo arreglo*/


void main (void)
{
    int arre1[13]= {1,2,3,4,5,6,7,8,9,10,11,12,13};
    int arre2[13]={2,4,6,8,10,12,14,16,18,20,22,24,26} ;
    int Re[13];
    
    int j = 12;
    for (int i = 0; i < 13; i++)
    { 
        Re[i]= arre1 [i]+ arre2[j];
        j--;
    }
for (int i = 0; i <13 ; i++)
{
    
   printf("\n Resultado  de la suma %d", Re[i]);
}

}