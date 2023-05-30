using System;

namespace Clase_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolGeneral<int> raiz = new ArbolGeneral<int>(10);

            // Hijos 

            ArbolGeneral<int> hijo1 = new ArbolGeneral<int>(12);
            ArbolGeneral<int> hijo2 = new ArbolGeneral<int>(21);
            ArbolGeneral<int> hijo3 = new ArbolGeneral<int>(-1);

            // Agrego hijos a la raíz

            raiz.agregarHijo(hijo1);
            raiz.agregarHijo(hijo2);
            raiz.agregarHijo(hijo3);

            // Hijos del árbol 1

            hijo1.agregarHijo(new ArbolGeneral<int>(123));
            hijo1.agregarHijo(new ArbolGeneral<int>(124));
            hijo1.agregarHijo(new ArbolGeneral<int>(143));

            // Hijos del árbol 2

            hijo2.agregarHijo(new ArbolGeneral<int>(9));
            hijo2.agregarHijo(new ArbolGeneral<int>(120));

            // HIjos del árbol 3

            hijo3.agregarHijo(new ArbolGeneral<int>(-100));
            
            // Recorriendo el árbol 🌳

            raiz.recorridoPreOrden();

        }
    }
}
