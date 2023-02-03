#include<stdio.h>
#include<stdlib.h>
#include<time.h>

int main ()

{
    int menu =0;
    time_t seed=0;
    
    srand (time(&seed));
    unsigned int numero = 0;
    unsigned int primera=0 ;
    unsigned int segunda = 0;
    unsigned int tercera = 0;

printf("Loteria clase programacion\n");
do
{
    printf("\n0 - salir");
    printf("\n1 -  jugar");
    printf("\nElige una opcion");
    scanf("%d", &menu);

    if(menu==1)
    {
        do{
            printf("\nIngresa tu numero:");
        scanf("%d,&numero");
            if (numero)
            {
                primera("\nEl numero de ser entre 0 y 100\n")
            }
        }while (numero>=0&&numero<=100);
        
        primera = rand()%100;
        segunda= rand()%100;
        tercera= rand ()%100;
        
        if(numero==primera)
        {
            printf("\nTe sacaste en primera");

        } else if (numero ==segunda)
    {
        printf("\nTe sacaste en segunda ");

    }else if(numero==tercera)
    {
        printf("\nTe sacaste en tercera");

    }else {
        printf("\nTe guallate\n ");
    
    }
     printf("\nprimera:%d", primera);
      printf("\nSegunda:%d",segunda);
      printf("\nTercera:%d",tercera);
      printf("\n"); 

    }

} while (menu!=0);
return 0;
}