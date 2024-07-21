using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7
{
    public static class Balanceo
    {
        /* El siguiente código es demostrativo para la clase de Estructura de datos sobre el manejo de pilas, 
        *  únicamente cuenta la cantidad de parentesis abiertos y cerrados de ecuaciones simples, ((4+3*(2+5))),
        *  no revisa la estructura de la fórmula como por ejemplo (4+3*)2+5()())))
        *  TODO: ampliar el algoritmo para resolver ecuaciones que tengan mas elementos como por ejemplo {[()]}
        */

        public static void Run()
        {
            // (4+3*)2+5)))

            // Definimos una pila para almacenar letras
            Stack<char> ecuacion = new Stack<char>();

            //string formula = "(4+3*((2+5)))"; 
            System.Console.WriteLine("ingrese una ecuación");
            string formula = Console.ReadLine();

            foreach (char letra in formula)
            {
                ecuacion.Push(letra); // Pasamos cada letra de la formula a la pila de caracteres
            }
            imprimirPila(ecuacion);

            int ParentesisAbiertos = 0;
            int ParentesisCerrados = 0;

            while (ecuacion.Count > 0)
            {
                char signo = ecuacion.Pop();
                if (signo == '(')
                {
                    ParentesisAbiertos++;
                    // System.Console.WriteLine("abierto {0}", signo);
                }
                if (signo == ')') ParentesisCerrados++;
            }

            // if(ParentesisAbiertos == ParentesisCerrados){
            //     System.Console.WriteLine("Ecuación Balanceada");
            // }else{
            //     System.Console.WriteLine("Ecuación NO balanceada");
            // }

            // if de una sola linea (operador ternario)
            string resultado = ParentesisAbiertos == ParentesisCerrados ? "Balanceada" : "NO balanceada";
            System.Console.WriteLine("Ecuación " + resultado);
        }


        //Función para recorrer la pila e imprimir sus elementos
        static void imprimirPila(Stack<char> pila)
        {
            System.Console.WriteLine("Los elementos de la lista son: ");
            foreach (var item in pila)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}

