#include <stdio.h>
/* Funciones para el manejo de cadenas de caracteres de la biblioteca stdio.h. */

void main (void)
{
    char *cad0= "buenos dias"; /* En este caso se asigna 11 caracteres mas el caracter de terminacion '\0' a la posicion de memoria
    a la que aounta la variable cad0 -apuntador del tipo cadena de caracteres. */

    char cad1 [20]="Hola"; /*Se asigna cuatro caracteres mas el caracter para 20 caracteres.*/
    char cad2[]="Mexico"; /*En este caso se asigna seis caracteres (mas el caracter de terminacion)
    a la variable cad2. Observa que cad2 no tiene espacio reservado como cad1; por lo tanto, acepta cualquier numero de caracteres.*/
    char cad3[]={'B','i','e','n','e','n','i','d','o','\0'};
    /* Observa otra forma de asignación de valores a la variable cad3. */
    char cad4[20], cad5[20],cad6[20];
    printf ("\nLa cadena cad0 es: ");
    puts(cad0);
    /* La función puts es la más apropiada para escribir cadenas de caracteres.
Observa que esta función baja automáticamente una línea después de imprimir
la cadena. */
     printf("\nLa cadena cad1 es;");
     printf("%s", cad1);
     /* La función printf, con el formato de variable %s, también se puede utilizar
para escribir cadenas de caracteres. Baja automáticamente una línea después
de escribir la cadena.*/
    printf("\nLa cad2 es:");
    puts (cad2);
    printf("\nLa cadena cad3 es:");
    puts(cad3);
    
    printf("\nIngrese una linea de texto- se lee con gets-:\n");
    /* La función gets es la más apropiada para leer cadenas de caracteres. */
    gets(cad4);
    printf("\nLa cadena cad4 es:");
    

}