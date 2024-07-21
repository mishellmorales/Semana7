using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7
{
    public static class Pila
    {
        public static void Run()
        {
            // Definición de una pila para enteros
            Stack<int> pilaEnteros = new Stack<int>();

            // Agregar elementos de la pila
            pilaEnteros.Push(1);
            pilaEnteros.Push(2);
            pilaEnteros.Push(20);
            pilaEnteros.Push(4);

            ImprimirPila(pilaEnteros);

            // Mostrar el elemento en la parte superior sin sacarlo de la pila con Peek()
            int ElementoSuperior = pilaEnteros.Peek();
            System.Console.WriteLine("Elemento en la cima (Peek): {0}", ElementoSuperior);

            // Sacar el elemento que se encuentra arriba de la pila mediante Pop()
            int ElementoSacado = pilaEnteros.Pop();
            System.Console.WriteLine("Se ha sacado el elemento {0} con el método Pop()", ElementoSacado);
            ImprimirPila(pilaEnteros);

            // Vaciar la pila si tiene elementos Count
            while (pilaEnteros.Count > 0)
            {
                // Imprime en pantalla a la vez que se elimina de la pila el valor que se encuentra en la parte superior
                System.Console.WriteLine("Se saca el elemento {0}", pilaEnteros.Pop());
            }
            // Llamado a la función ImprimirPila y le damos una pila como parámetro, en este ejemplo: pilaEnteros
            ImprimirPila(pilaEnteros);
        }

        /**
        * Imprimir pila: Función para mostrar el contenido de una pila en pantalla
        */
        static void ImprimirPila(Stack<int> pila)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("El número actual de elementos es: {0}", pila.Count);//Cont devuelve el número de elementos en la pila
            System.Console.WriteLine("---------------------------------------------");
            foreach (var item in pila) // Recorrer elementos de la pila
            {
                System.Console.WriteLine(item); //muestra el item en pantalla
            }
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine();
        }
    }


}

