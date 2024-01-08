using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------Metodos que reciben un array----------------------------
            int[] numeros = new int[4];

            numeros[0] = 4;
            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;

            //Llamar al metodo con array
            ProcesaDatos(numeros);

            // ------------------------------------Metodos que devuelven un array----------------------------
            //foreach (int i in LeerDatos())
            //{
            //    Console.WriteLine(i);
            //}

        }

        //Array como parametro
        static void ProcesaDatos(int[] datos)
        {
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] += 10;
                Console.WriteLine(datos[i]);
            }
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("¿Cualtos elementos quieres que posea el array?");

            string res = Console.ReadLine();

            int numElementos = int.Parse(res);

            int[] datos = new int[numElementos];
                
            for(int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Ingrese el valor de la posicion {i}");
                datos[i] = int.Parse(Console.ReadLine());
            }
            return datos;
        } 
    }
}
