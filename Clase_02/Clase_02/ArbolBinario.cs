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
            if (!esVacio())
            {
                Console.Write($"{getDatoRaiz()} ");

                if(!getHijoIzquierdo().esVacio()) getHijoIzquierdo().recorridoPreOrden();

                if (!getHijoDerecho().esVacio())  getHijoDerecho().recorridoPreOrden();
            } 
        }

        // El recorrido se realiza de la siguiente manera: subárbol izquierdo, raíz, subárbol derecho. 
        public void recorridoInOrden()
        {
            if (!esVacio())
            {
                if (!getHijoIzquierdo().esVacio()) getHijoIzquierdo().recorridoInOrden();

                Console.Write($"{getDatoRaiz()} ");

                if (!getHijoDerecho().esVacio())   getHijoDerecho().recorridoInOrden();
            }
        }

        // El recorrido realiza de la siguiente manera: subárbol izquierdo, subárbol derecho, raíz.
        public void recorridoPostOrden()
        {
            if (!esVacio())
            {
                if (!getHijoIzquierdo().esVacio()) getHijoIzquierdo().recorridoPostOrden();

                if (!getHijoDerecho().esVacio()) getHijoDerecho().recorridoPostOrden();

                Console.Write($"{getDatoRaiz()} ");
            }
        }

        // El recorrido visita los nodos del árbol por nivel, es decir, primero todos los nodos del nivel 0,
        // luego los nodos del nivel 1 y así sucesivamente.
        public void recorridoPorNiveles()
        {
            if (!esVacio())
            {
                Cola<ArbolBinario<T>> cola = new Cola<ArbolBinario<T>>();

                ArbolBinario<T> desencolado;

                cola.encolar(this);

                while (!cola.esVacia())
                {
                    desencolado = cola.desencolar();

                    Console.Write($"{desencolado.getDatoRaiz()} ");

                    if (!desencolado.getHijoIzquierdo().esVacio()) cola.encolar(desencolado.getHijoIzquierdo());

                    if (!desencolado.getHijoDerecho().esVacio()) cola.encolar(desencolado.getHijoDerecho());
                }
            }
        }

        // Agrega un elemento al árbol binario.
        public void agregar(T dato) 
        {
            if (!esVacio())
            {
                Cola<ArbolBinario<T>> cola = new Cola<ArbolBinario<T>>();

                ArbolBinario<T> desencolado;

                cola.encolar(this);

                while (true)
                {
                    desencolado = cola.desencolar();

                    if (agregarHijo(desencolado, dato)) break;

                    else
                    {
                        if (!desencolado.getHijoIzquierdo().esVacio()) cola.encolar(desencolado.getHijoIzquierdo());

                        if (!desencolado.getHijoDerecho().esVacio()) cola.encolar(desencolado.getHijoDerecho());
                    }

                }
            }
        }

        // Indica si se puede agregar un hijo en el árbol receptor. En ese caso, agrega un hijo con el dato dado.
        private bool agregarHijo(ArbolBinario<T> arbol , T dato)
        {
            if (arbol.getHijoIzquierdo().esVacio()) arbol.setHijoIzquierdo(new ArbolBinario<T>(dato));

            else if (arbol.getHijoDerecho().esVacio())  arbol.setHijoDerecho(new ArbolBinario<T>(dato));
            
            return arbol.getHijoIzquierdo().esVacio() || arbol.getHijoDerecho().esVacio();
        }

        // Indica si el elemento dado está en el árbol.
        public bool incluye(T dato) 
        {
            

            return false;
        }

        // Describe la cantidad de hojas que tiene el árbol que recibe el mensaje.
        public int contarHojas()
        {
            int hojasAlMomento = 0;

            Cola<ArbolBinario<T>> cola = new Cola<ArbolBinario<T>>();

            ArbolBinario<T> desencolado;

            cola.encolar(this);

            while (!cola.esVacia())
            {
                desencolado = cola.desencolar();

                if(desencolado.esHoja()) hojasAlMomento++;

                if(!desencolado.getHijoIzquierdo().esVacio()) cola.encolar(desencolado.getHijoIzquierdo());

                if (!desencolado.getHijoDerecho().esVacio()) cola.encolar(desencolado.getHijoDerecho());
            }
            return hojasAlMomento;
        }

        // Recorrido con separador de niveles 🐣

        // Imprime el recorrido por niveles de los elementos del árbol receptor entre los niveles n y m ambos inclusive.
        // Precondición: Debe ser 0 <= n <= m.
        public void entreNiveles(int n, int m)
        {
            if (!esVacio())
            {
                Cola<ArbolBinario<T>> cola = new Cola<ArbolBinario<T>>();

                ArbolBinario<T> desencolado;

                int nivel = 0;

                cola.encolar(this);

                cola.encolar(null); // ➡ Separador de niveles 

                while (!cola.esVacia())
                {
                    desencolado = cola.desencolar();

                    if (desencolado is not null)
                    {
                        if (nivel >= n && nivel <= m) Console.Write($"{desencolado.getDatoRaiz()} ");

                        if (!desencolado.getHijoIzquierdo().esVacio()) cola.encolar(desencolado.getHijoIzquierdo());

                        if (!desencolado.getHijoDerecho().esVacio()) cola.encolar(desencolado.getHijoDerecho());
                    }
                    else 
                    {
                        nivel++;

                        if(!cola.esVacia()) cola.encolar(null);
                    }
                }
            }
        }
    }
}
