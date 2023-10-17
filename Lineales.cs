using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeBusqueda_SLE
{
    internal class Lineales
    {
        public void Ejercicio1()
        {
            int[] numeros = { 1, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };


            Console.WriteLine("Escribe el numero que quieres buscar ");
            int buscar= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] != buscar)
                {
                    Console.WriteLine("No existe el numero");
                    break;
                }

                else if (numeros[i] == buscar)
                {
                    Console.WriteLine($"La posicion donde se encuentra el numero es {buscar}");
                    break;
                    //buscar = numeros[i];
                }
            }

            
        }




    }
}
