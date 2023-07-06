using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anexo
{
    public class ArbolGenerico
    {
        private Nodo raiz;

        private Nodo nodoAuxiliar;

        private int i = 0;

        public ArbolGenerico()
        {
            raiz = new Nodo();  
        }

        // Insertar

        public void insertar(string datoAInsertar, Nodo nodoDondeInsertar)
        {
            if (nodoDondeInsertar is null) 
            {
                nodoDondeInsertar = new Nodo();

                nodoDondeInsertar.Dato = datoAInsertar;
            }

            if (nodoDondeInsertar.Hijo is null)
            {
                Nodo nodoTemporal = new Nodo();

                nodoTemporal.Dato = datoAInsertar;

                nodoDondeInsertar.Hijo = nodoTemporal;
            }
            else
            {
                // Avanzar hasta el último hermano.

                nodoAuxiliar = nodoDondeInsertar.Hijo;

                while (nodoAuxiliar.Hermano is not null)
                {
                    nodoAuxiliar = nodoAuxiliar.Hermano;
                }

                // Crear un nodo temporal

                Nodo nodoTemporal = new Nodo();

                nodoTemporal.Dato = datoAInsertar;

                nodoAuxiliar.Hermano = nodoTemporal;    

            }
        }
    }
}
