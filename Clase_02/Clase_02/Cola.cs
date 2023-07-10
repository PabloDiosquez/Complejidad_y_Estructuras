using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class Cola<T>
    {
        // Atributos
        private List<T> encolados;

        // Constructor
        public Cola()
        {
            encolados = new List<T>();
        }

        // Métodos de instancia 

        public void encolar(T encolado) 
        {
            encolados.Add(encolado);
        }

        public T desencolar()
        {
            T desencolado = encolados[0];

            encolados.Remove(desencolado);

            return desencolado;
        }

        public bool esVacia()
        {
            return encolados.Count == 0;
        }

        public T verTope() 
        {
            return encolados.First();
        }
    }
}
