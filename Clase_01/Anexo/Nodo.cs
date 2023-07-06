using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anexo
{
    public class Nodo
    {
        private string dato;

        private Nodo hijo;

        private Nodo hermano;

        // Constructor
        public Nodo()
        {
            dato = String.Empty;

            hijo = null;

            hermano = null;
        }

        // Propiedades

        public string Dato
        {
            get { return dato; }

            set { dato = value; }
        }

        public Nodo Hijo
        {
            get { return hijo; }

            set { hijo = value; }
        }

        public Nodo Hermano
        {
            get { return hermano; }

            set { hermano = value; }
        }
    }
}
