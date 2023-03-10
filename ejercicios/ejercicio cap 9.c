#include <stdio.h>
/*Programa que escriba y lea un listado de nombres*/

void main(void)
{
    char p1;
    int n,s;

    FILE *ar;
    if ((ar = fopen("arc.txt", "a+")) != NULL)
    {
        do
        {
             printf("\nDesea escribir un nombre?,s,n:");
             scanf("%d",&s,&n);
            s=(p1 = getchar());
            fputc(p1, ar);
            if (s=(p1 = getchar()))
            
            fputc(p1, ar);
        } while ( n = fclose(ar));
        
            printf("\nDesea escribir un nombre?,s,n:");
            scanf("%d",&s,&n);
            if (s=(p1 = getchar()))
            
            fputc(p1, ar);
    }
    else
        printf("no se puede abrir el archivo");
}