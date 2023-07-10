using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class NodoBinario<T>
    {
        // Atributos

        private T dato;

        private NodoBinario<T> hijoIzquierdo;

        private NodoBinario<T> hijoDerecho;

        // Constructor 

        public NodoBinario(T dato)
        {
            this.dato = dato;

            hijoIzquierdo = null;

            hijoDerecho = null;
        }

        // Getters y Setters

        public T getDato() 
        {
            return dato;
        }

        public NodoBinario<T> getHijoIzquierdo()
        {
            return hijoIzquierdo;
        }

        public NodoBinario<T> getHijoDerecho()
        {
            return hijoDerecho;
        }

        public void setDato(T dato)
        {
            this.dato = dato;
        }

        public void setHijoIzquierdo(NodoBinario<T> hijoIzquierdo)
        {
            this.hijoIzquierdo=hijoIzquierdo;
        }

        public void setHijoDerecho(NodoBinario<T> hijoDerecho) 
        {
            this.hijoDerecho=hijoDerecho;
        }
    }
}
