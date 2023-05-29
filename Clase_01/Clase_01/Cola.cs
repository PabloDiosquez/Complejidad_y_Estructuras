using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_01
{
    /// <summary>
    /// Representa una colección de objetos de tipo primero en entrar, primero en salir.
    /// </summary>
    public class Cola<T>
    {
        private List<T> datos = new List<T>();

        /// <summary>
        /// Agrega el dato en la cola de datos.
        /// </summary>
        /// <param name="dato">El dato a encolar - Tipo: T</param>
        public void encolar(T dato)
        {
            datos.Add(dato);
        }

        /// <summary>
        /// Desencola el primer dato en la cola de datos.
        /// </summary>
        /// <returns>Un dato de tipo T</returns>
        public T desencolar()
        {
            T desencolado = datos[0];

            datos.Remove(desencolado);

            return desencolado;
            
        }

        /// <summary>
        /// Describe el primer dato en la cola de datos.
        /// </summary>
        /// <returns>Un dato de tipo T</returns>
        public T verTope() 
        {
            return datos[0];
        }

        /// <summary>
        /// Indica si la cola de datos está vacía.
        /// </summary>
        /// <returns>Un valor de tipo bool</returns>
        public bool esVacia()
        {
            return datos.Count == 0;
        }
    }

}
