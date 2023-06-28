using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_01
{
    public static class Busqueda
    {
        //Sequential search(Linear search) is the simplest search algorithm. It is a special case of brute-force search.
        //It is a method for finding a particular value in a list. To achieve this, it checks every one of its elements one

        /// <summary>
        /// Describe el índice del número dado en el arreglo de números dado. En caso de que el número dado 
        /// no pertenezca al arreglo, describe -1.
        /// </summary>
        /// <param name="numeros">[int]</param>
        /// <param name="llave">int</param>
        /// <returns>int (índice)</returns>
        public static int busquedaSecuencialV1(int[] numeros, int llave)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == llave) 
                {
                    return i;
                }
            }

            return -1;
        }

        public static int busquedaSecuencialV2(int[] arr, int searchNumber)
        {
            arr[arr.Length - 1] = searchNumber;

            int i;

            for (i = 0; arr[i] != searchNumber; i++) ;

            return (i < arr.Length - 1) ? i : -1;
        }

        // Binary search works on a sorted array. The value is compared with the middle element of the array.
        // If equality is not found, then the half part is eliminated in which the value is not there.
        // In the same way, the other half part is searched

        /// <summary>
        ///  Describe el índice del número dado en el arreglo de números dado. En caso de que el número dado 
        /// no pertenezca al arreglo, describe -1.
        /// </summary>
        /// <param name="numeros">[int]</param>
        /// <param name="llave">int</param>
        /// <returns>int (índice)</returns>
        public static int busquedaBinaria(int[] numeros, int llave)
        {
            int izquierda = 0, derecha = numeros.Length - 1;

            int medio;

            while (izquierda <= derecha)
            {
                medio = (numeros[izquierda] + numeros[derecha]) / 2;

                if (numeros[medio] < llave)
                {
                    izquierda = medio + 1;
                }
                else if (numeros[medio] > llave) 
                {
                    derecha = medio - 1;
                }

                return medio;
            }

            return -1;
        }
    }
}
