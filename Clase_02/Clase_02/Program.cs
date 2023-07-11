using System;

namespace Clase_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario<int> arbol_A = new ArbolBinario<int>(1);       // ➡ Raíz principal R

            ArbolBinario<int> hijoIzquierdo = new ArbolBinario<int>(2); // ➡ Hijo izquierdo de la raíz R
            hijoIzquierdo.setHijoIzquierdo(new ArbolBinario<int>(4));
            hijoIzquierdo.setHijoDerecho(new ArbolBinario<int>(5));

            ArbolBinario<int> hijoDerecho = new ArbolBinario<int>(3);   // ➡ Hijo derecho de R
            hijoDerecho.setHijoDerecho(new ArbolBinario<int>(6)); 

            arbol_A.setHijoIzquierdo(hijoIzquierdo);
            arbol_A.setHijoDerecho(hijoDerecho);

            arbol_A.agregar(-1);

            // Recorridos 🥨
            Console.WriteLine("Recorrido PreOrden:");
            arbol_A.recorridoPreOrden();

            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(arbol_A.contarHojas());

            //Console.WriteLine("\nRecorrido InOrden:");
            //arbol_A.recorridoInOrden();

            //Console.WriteLine("\nRecorrido PostOrden:");
            //arbol_A.recorridoPostOrden();

            //Console.WriteLine("\nRecorrido por niveles:");
            //arbol_A.recorridoPorNiveles();

        }
    }
}
