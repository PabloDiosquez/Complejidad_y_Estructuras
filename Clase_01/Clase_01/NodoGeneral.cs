using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_01
{
    /// <summary>
    /// Modela un nodo general.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class NodoGeneral<T>
    {
        // Atributos

        private T dato;

        private List<NodoGeneral<T>> hijos;

        // Constructor 

        public NodoGeneral(T dato) 
        {
            this.dato = dato;

            hijos = new List<NodoGeneral<T>>();
        }

        /// <summary>
        /// Describe el dato del nodo.
        /// </summary>
        /// <returns>T</returns>
        public T getDato()
        {
            return dato;
        }

        /// <summary>
        /// Describe la lista de los hijos del nodo.
        /// </summary>
        /// <returns>Una lista de nodos generales ➡ List<NodoGeneral<T>></returns>
        public List<NodoGeneral<T>> getHijos()
        {
            return hijos;
        }

        /// <summary>
        /// Asigna el dato de tipo genérico al nodo.
        /// </summary>
        /// <param name="dato">Valor del dato ➡ Tipo: T</param>
        public void setDato(T dato) 
        {
            this.dato = dato;
        }

        /// <summary>
        /// Asigna la lista de hijos del nodo.
        /// </summary>
        /// <param name="hijos">Lista de los hijos del nodo ➡ List<NodoGeneral<T>></param>
        public void setHijos(List<NodoGeneral<T>> hijos) 
        {
            this.hijos = hijos;
        }

    }
}
