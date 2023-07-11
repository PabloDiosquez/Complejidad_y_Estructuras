using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02BIS
{
    public class MinHeap
    {
        private int[] heap;

        private int size; // Cantidad de elementos del heap

        // Constructor para crear un heap vacío.
        public MinHeap(int maxSize)
        {
            heap = new int[maxSize];

            size = 0;
        }

        // Constructor para crear un heap a partir de un arreglo de números.

        public MinHeap(int[] heap)
        {
            this.heap = heap;

            size = heap.Length;

            buildHeap(); // Se construye el heap
        }

        // Métodos de instancia 🥐 

        // Describe la cantidad de elementos que tiene el minHeap.
        public int Size 
        {
            get { return size; }
            set { size = value; }
        }

        public void buildHeap() 
        {

        }

        // Inserta el valor dado en el heap.
        public void insert(int number) 
        {
            if (size == heap.Length)
            {
                throw new Exception("MinHeap lleno");
            }
            else
            {
                int currentPosition = Size;

                heap[currentPosition] = number;

                Size++;

                while (heap[currentPosition] < heap[parent(currentPosition)])
                {
                    exchange(currentPosition, parent(currentPosition));

                    currentPosition = parent(currentPosition);
                }
            }
        }

        // Cambia el valor del vector en la posición **position1** por el valor del vector en la posición **position2**.
        public void exchange(int position1, int position2)
        {
            int aux = heap[position1];

            heap[position1] = heap[position2];

            heap[position2] = aux;
        }

        // Describe la posición del nodo padre del nodo dado.
        public int parent(int position) 
        {
            return (position - 1) / 2;
        }

        // Describe la posición del hijo izquierdo del nodo cuya posición fue dada.
        public int leftChild(int parentPosition)
        {
            return 2*parent(parentPosition) + 1;
        }

        // Describe la posición del hijo derecho del nodo cuya posición fue dada.
        public int rightChild(int parentPosition)
        {
            return 2*parent(parentPosition) + 2;
        }
    }
}
