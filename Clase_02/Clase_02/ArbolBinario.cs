using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class ArbolBinario<T>
    {
        // Atributos

        private NodoBinario<T> raiz; // ➡ El árbol sólo conoce su raíz.

        // Constructores 

        public ArbolBinario(T dato) 
        {
            raiz = new NodoBinario<T>(dato);
        }

        private ArbolBinario(NodoBinario<T> raiz) // ➡ Método auxiliar para utilizar en los gethijos...
        {
            this.raiz = raiz;   
        }

        // Getters y Setters

        // Describe el nodo raíz del árbol que recibe el mensaje.
        private NodoBinario<T> getRaiz()
        {
            return raiz;
        }

        // Describe el dato que contiene el nodo raíz del árbol que recibe el mensaje. 
        public T getDatoRaiz()
        {
            return raiz.getDato();
        }

        // Describe el hijo izquierdo del árbol que recibe el mensaje.
        public ArbolBinario<T> getHijoIzquierdo()
        {
            return new ArbolBinario<T>(raiz.getHijoIzquierdo());
        }

        // Describe el hijo derecho del árbol que recibe el mensaje.
        public ArbolBinario<T> getHijoDerecho()
        {
            return new ArbolBinario<T>(raiz.getHijoDerecho());
        }

        // Asigna el árbol dado como hijo izquierdo del árbol que recibe el mensaje.
        public void setHijoIzquierdo(ArbolBinario<T> hijoIzquierdo)
        {
            raiz.setHijoIzquierdo(hijoIzquierdo.getRaiz());
        }

        // Asigna el árbol dado como hijo derecho del árbol que recibe el mensaje.
        public void setHijoDerecho(ArbolBinario<T> hijoDerecho)
        {
            raiz.setHijoDerecho(hijoDerecho.getRaiz());
        }

        // Métodos de instancia

        // Elimina el hijo izquierdo del árbol que recibe el mensaje.
        public void eliminarHijoIzquierdo()
        {
            raiz.setHijoIzquierdo(null);
        }

        // Elimina el hijo derecho del árbol que recibe el mensaje.
        public void eliminarHijoDerecho()
        {
            raiz.setHijoDerecho(null);
        }

        // Indica si el árbol es vacío.
        public bool esVacio()
        {
            return raiz is null;
        }

        // Indica si el árbol es hoja.
        public bool esHoja() 
        {
            return raiz is not null && (getHijoIzquierdo().esVacio() && getHijoDerecho().esVacio());
        }

        // El recorrido inicia en la raíz, sigue el subárbol izquierdo y al terminar, sigue el subárbol derecho.
        public void recorridoPreOrden()
        {
            if (getRaiz() is not null) Console.WriteLine(getDatoRaiz());

            if(!getHijoIzquierdo().esVacio()) getHijoIzquierdo().recorridoPreOrden();

            if (!getHijoDerecho().esVacio())  getHijoDerecho().recorridoPreOrden();
        }

        // El recorrido realiza de la siguiente manera: subárbol izquierdo, subárbol derecho, raíz.
        public void recorridoPostOrden() 
        {
            if (!getHijoIzquierdo().esVacio()) getHijoIzquierdo().recorridoPostOrden();

            if (!getHijoDerecho().esVacio())   getHijoDerecho().recorridoPostOrden();

            if (getRaiz() is not null) Console.WriteLine(getDatoRaiz());
        }

        // El recorrido se realiza de la siguiente manera: subárbol izquierdo, raíz, subárbol derecho. 
        public void recorridoInOrden()
        {
            if (!getHijoIzquierdo().esVacio()) getHijoIzquierdo().recorridoInOrden();

            if (getRaiz() is not null) Console.WriteLine(getDatoRaiz());

            if (!getHijoDerecho().esVacio()) getHijoDerecho().recorridoInOrden();
        }

        // El recorrido visita los nodos árbol por nivel, es decir, primero todos los nodos del nivel 0,
        // luego los nodos del nivel 1 y así sucesivamente.
        public void recorridoPorNiveles()
        {

        }
    }
}
