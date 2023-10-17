using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeBusqueda_SLE
{
    internal class Lineales
    {
        public int Ejercicio1()
        {
            int[] numeros = { 1, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            int buscar= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscar)
                {
                    buscar = i;

                    Console.WriteLine($"El numero esta en la posicion {buscar}");
                    return buscar;

                }
                else
                {
                    Console.WriteLine("No existe ese numero");
                    return "No existe";
                }

                return buscar;

            }
            
            





        }




    }
}
