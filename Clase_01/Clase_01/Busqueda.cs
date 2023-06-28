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
        /// <returns>in</returns>
        public static int busquedaSecuencial(int[] numeros, int llave)
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
    }
}
