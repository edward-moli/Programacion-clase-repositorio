#include <stdio.h>

/*El programa debe mediante un menu permitirnos salir con 
0-Salir
1-Archivo nuevo
2-Borrar
3-Buscar
4-Guardar
5-Leer
archivos con informacion de alumno.
*/

typedef struct 
{
    char nombre[50],Apellido[50];
    int Fecha;
};alumno;


void main (void)
{
    int op;
    FILE *ar;
    do
    {
        printf("0-salir");
        printf("1-Archivo nuevo");
        printf("2-Borrar");
        printf("3-Buscar");
        printf("4-Guardar");
        printf("5-Leer");
        printf("Ingrese la opcion deseada");
        scanf("%d", &op);

        switch (op)
        {

        case 1: 
            ar = fopen("arc.txt","w");

            printf("Nombre del alumno");
    
            gets(alumno.nombre);

            printf("Ingrese apellido");
            fflush(stdin);
            gets(alumno.Apellido);

            printf("Ingrese Fecha de nacimiento");
            scanf("%d",alumno.Fecha);
            break;

        case 2: 
        remove("*ar.txt");
             printf("archivo eliminado");
        break;

        case 3: 
        break;

        case 4:
        break;

        case 5:
        printf("Aun no esta incorporada");
        break;

    
        default:
        printf ("\error en el ingreso de la opcion ");
            break;
        }
    } while (op!=6);
    

}