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

        private NodoBinario<T> raiz;

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

        private NodoBinario<T> getRaiz()
        {
            return raiz;
        }

        public T getDatoRaiz()
        {
            return raiz.getDato();
        }

        public ArbolBinario<T> getHijoIzquierdo()
        {
            return new ArbolBinario<T>(raiz.getHijoIzquierdo());
        }

        public ArbolBinario<T> getHijoDerecho()
        {
            return new ArbolBinario<T>(raiz.getHijoDerecho());
        }

        public void setHijoIzquierdo(ArbolBinario<T> hijoIzquierdo)
        {
            raiz.setHijoIzquierdo(hijoIzquierdo.getRaiz());
        }

        public void setHijoDerecho(ArbolBinario<T> hijoDerecho)
        {
            raiz.setHijoDerecho(hijoDerecho.getRaiz());
        }

    }
}
