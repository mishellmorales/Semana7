using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7
{
    public static class Hanoi
    {

        static Stack<int> torreA = new Stack<int>();
        static Stack<int> torreB = new Stack<int>();
        static Stack<int> torreC = new Stack<int>();


        public static void Run()
        {
            InicializarPila(); // Elimina datos o residuos en las torres
            System.Console.Write("Cuántos discos contiene la torre");
            int NumDiscos = int.Parse(Console.ReadLine());

            //For en reversa que almacena los números desde el mayor al menor
            for (int i = NumDiscos; i >= 1; i--)
            {
                torreA.Push(i);
            }
            DibujarTorres();

            Resolver(NumDiscos, torreA, torreC, torreB);
        }

        static void Resolver(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
        {
            if (n == 1)
            {
                MoverDisco(origen, destino);
                DibujarTorres();
            }
            else
            {
                // Utilizamos recursividad.
                Resolver(n - 1, origen, auxiliar, destino);
                MoverDisco(origen, destino);

                DibujarTorres();
                Resolver(n - 1, auxiliar, destino, origen);
            }
        }

        // Mueve un disco desde el origen hacia el destino (de una torre a otra)
        static void MoverDisco(Stack<int> origen, Stack<int> destino)
        {
            // En destino se coloca un nuevo elemento que es el que se elimina en el origen
            destino.Push(origen.Pop());
        }

        static void DibujarTorres()
        {
            System.Console.WriteLine("Estado de las Torres:");
            System.Console.WriteLine("Torre A: {0}", string.Join(", ", torreA.Reverse()));
            System.Console.WriteLine("Torre B: {0}", string.Join(", ", torreB.Reverse()));
            System.Console.WriteLine("Torre C: {0}", string.Join(", ", torreC.Reverse()));
            System.Console.WriteLine(new string('*', 30));
        }

        static void InicializarPila()
        {
            // Utilizamos el método Clear para borrar el contenido de las pilas 
            torreA.Clear();
            torreB.Clear();
            torreC.Clear();
        }
    }
}