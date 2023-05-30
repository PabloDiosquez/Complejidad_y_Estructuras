using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_01
{
    /// <summary>
    /// 
    /// </summary>
    public class ArbolGeneral<T>
    {
        private NodoGeneral<T> raiz;

        // Constructores 

        public ArbolGeneral(T datoRaiz)
        {
            raiz = new NodoGeneral<T>(datoRaiz);
        }

        private ArbolGeneral(NodoGeneral<T> nodoRaiz)
        {
            raiz = nodoRaiz;
        }

        public T getDatoRaiz() 
        {
            return raiz.getDato();
        }

        private NodoGeneral<T> getRaiz()
        {
            return raiz;
        }

        public List<ArbolGeneral<T>> getHijos()
        {
            List<ArbolGeneral<T>> arbolesHijos = new List<ArbolGeneral<T>>();

            foreach (NodoGeneral<T> hijo in raiz.getHijos()) // ➡ Recorriendo la lista de nodos hijos
            {
                arbolesHijos.Add(new ArbolGeneral<T>(hijo)); // ➡ Por cada nodo creamos un árbol y lo agregamos a la lista de árboles hijos.
            }

            return arbolesHijos;                             // ➡ Retornamos lista de árboles hijos.
        }

        public void agregarHijo(ArbolGeneral<T> hijo)
        {
            raiz.getHijos().Add(hijo.getRaiz());
        }

        public void eliminarHijo(ArbolGeneral<T> hijo)
        {
            raiz.getHijos().Remove(hijo.getRaiz());
        }

        public bool estaVacio()
        {
            return raiz is null;
        }

        public bool esHoja()
        {
            return raiz is not null && raiz.getHijos().Count() == 0;
        }

        // Ejercicio 4a.

        // Pista: El mensaje altura debe chequear si el árbol es una sola hoja o no. Si el árbol es una sola hoja, se devuelve 0.
        // Si no, se utiliza el mensaje getHijos() para obtener la lista de hijos(recuerde que devuelve una lista de árboles hijos).
        // Luego, debe iterar por cada uno de los hijos, guardando la máxima altura.A este valor se le debe sumar 1 y retornarlo.


        /// <summary>
        /// Describe la altura del árbol, es decir, la longitud del camino más largo desde el nodo raíz hasta una hoja.
        /// Precondición: 
        /// *El árbol no debe ser vacío.
        /// </summary>
        /// <returns>int</returns>
        public int altura()
        {
            if (esHoja())
                return 0;

            List<ArbolGeneral<T>> hijos = getHijos();

            int alturaMaxima = hijos[0].altura();

            hijos.RemoveAt(0);

            foreach (ArbolGeneral<T> hijo in hijos)
            {
                if (hijo.altura() > alturaMaxima)
                {
                    alturaMaxima = hijo.altura();
                }
            }

            return alturaMaxima + 1;
        }

        //Ejercicio 4b
        //Pista: Si el nodo raíz posee el mismo dato que pasado como parámetro, se retorna 0. En caso contrario, se debe buscar en
        //cuales de los subárboles hijos se encuentra el dato(implemente el mensaje include (Object dato) en la clase Arbol General)
        //y se debe retornar 1 más el nivel que arroje enviar el mensaje nivel() al subárbol que incluye el dato.

        /// <summary>
        /// Describe la profundidad o nivel del dato en el árbol. El nivel de un nodo es la longitud del único camino de la raíz al nodo.
        /// </summary>
        /// <param name="dato">El dato según el cual se describe el nivel - Tipo: T</param>
        /// <returns>int</returns>
        public int nivel(T dato)
        {
            return 0;
        }

        public void recorridoPreOrden() 
        {
            // Primero proceso la ráiz
            if (!estaVacio())
            {
                Console.Write($"{getDatoRaiz()} ");
            }

            // Después proceso los hijos
            if (!esHoja()) // ¿Tiene hijos?
            {
                foreach (ArbolGeneral<T> hijo in getHijos())
                {
                    hijo.recorridoPreOrden();
                }
            }
        }
    }
}
