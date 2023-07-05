using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_01
{
    public static class FuncionesAuxiliares
    {
        /// <summary>
        /// Describe el número más grande entre los dos números enteros dados.
        /// </summary>
        /// <param name="numero1">Número entero</param>
        /// <param name="numero2">Número entero</param>
        /// <returns>Número entero</returns>
        public static int maximoEntre(int numero1, int numero2)
        {
            if (numero1 >= numero2) return numero1;

            return numero2;
        }
    }
}
