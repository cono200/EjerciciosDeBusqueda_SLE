using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            Console.WriteLine("Ingresa el numero que quieres buscar ");
            int buscar= Convert.ToInt32(Console.ReadLine());
            bool noAi = false;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscar)
                {
                    buscar = i;

                    Console.WriteLine($"El numero esta en la posicion {buscar}");
                    noAi = true;
                    

                }
                
                

            }

            if (!noAi)
            {
                Console.WriteLine("No existe ese numero");
            }
            
            





        }


        public void Ejercicio2()
        {
            string[] cadena = { "A", "B", "C", "D", "ola" };


            Console.WriteLine("Ingresa la cadena que quieres buscar");
            string buscarCadena = Console.ReadLine();
            bool noEncontrada= false;

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == buscarCadena)
                {
                    Console.WriteLine("Si existe esa cadena y está en " + i);
                    noEncontrada = true; 
                    break;
                }
            }

            if (!noEncontrada) 
            {
                Console.WriteLine("No ai");
            }
        }


        public void Ejercicio3()
        {
            int[] numeros= { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Ingrese el numero ");
            int numeroUsuario = Convert.ToInt32(Console.ReadLine());
            bool siAi=false;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeroUsuario % 2 == 0 && numeroUsuario== numeros[i])
                {
                    Console.WriteLine( "El numero si es par  y esta en " + i);
                    siAi = true;
                }
            }

            if (!siAi)
            {
                Console.WriteLine("No existe y/o no es par");
            }
        }


        public void Ejercicio4()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine($"Los numeros pares son  {numeros[i]} y estan en  {i}");
                }
            }


        }

    }
}
