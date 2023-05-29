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

        public void encolar(T dato)
        {
            datos.Add(dato);
        }

        public T desencolar()
        {
            T desencolado = datos[0];

            datos.Remove(desencolado);

            return desencolado;
            
        }
    }

}
