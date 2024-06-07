using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_8___Ejercicio_1
{
    internal class Program
    {
        static int contNumeros = 0;
        static int[] enteros = new int[100];
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("1 - Ingresar numeros enteros\n2 - Ordenar listado\n3 - Busque un numero\n4 - Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese cantidad de numeros a cargar");
                        int numerosCargar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese numeros a cargar");
                        for (int i = 0; i < numerosCargar; i++)
                        {
                            enteros[contNumeros++] = Convert.ToInt32(Console.ReadLine());
                        }                        
                    break;

                    case 2:
                        Console.WriteLine("Ordenando listado...");
                        burbuja(enteros, contNumeros);
                        if (contNumeros != 0)
                        {
                            for (int i = 0; i < contNumeros; i++)
                            {
                                Console.WriteLine(enteros[i]);
                            }
                        }    
                        else
                        {
                            Console.WriteLine("No se han encontrado numeros para ordenar");
                        }
                    break;

                    case 3:
                        Console.WriteLine("Ingrese numero a buscar");
                        int buscar = Convert.ToInt32(Console.ReadLine());
                        int posicion = busquedaSecuencial(enteros, contNumeros, buscar);
                        if (posicion != -1)
                        {
                            Console.WriteLine("Se a encontrado el numero {0} en la posicion {1}",buscar,posicion);
                        }
                        else
                        {
                            Console.WriteLine("El numero {0} no se a encontrado en el listado", buscar);
                        }
                    break;


                }
            } while (opcion != 4);
        }

        static void burbuja(int[]vector, int contador)
        {
            int aux;
            for (int i = 0; i<contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
        }

        static int busquedaSecuencial(int[]vector, int contador, int valor)
        {
            int i = 0;
            int pos = -1;
            while ((pos == -1 ) && (i < contador)) 
            {
                if (vector[i] == valor)
                {
                    pos = i;
                }
                i++;
            }
            return pos;
        }
    }
}
