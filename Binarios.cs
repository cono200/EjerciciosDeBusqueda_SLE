using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeBusqueda_SLE
{
    internal class Binarios
    {
        public  void Ejercicios1Binaros()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 

            Console.WriteLine("Introducce el numero");
            int buscarNumero = Convert.ToInt32(Console.ReadLine());

            int inicio = 0;
            int fin = numeros.Length - 1;
            int posicion = -1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (numeros[medio] == buscarNumero)
                {
                    posicion = medio;
                    break;
                }
                else if (numeros[medio] < buscarNumero)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"El numero {buscarNumero} se encuentra en  {posicion}");
            }
            else
            {
                Console.WriteLine($"El numero {buscarNumero} no existe");
            }
        }


        public void Ejercicio2Binario()
        {
            string[] cadenas = { "A", "B", "C", "E", "F", "G", "H", "OOO" };

           

            Console.WriteLine("Ingresa la cadena que deseas buscar ");
            string buscarCadena = Console.ReadLine();

            int inicio = 0;
            int fin = cadenas.Length - 1;
            int posicion = -1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                int comparacion = string.Compare(cadenas[medio], buscarCadena);

                if (comparacion == 0)
                {
                    posicion = medio;
                    break;
                }
                else if (comparacion < 0)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($" Se encuentra en la posición {posicion} ");
            }
            else
            {
                Console.WriteLine($"La cadena {buscarCadena} no existe ");
            }
        }


        public void Ejercicio4Binario()
        {
            int[] numeros = { 1, 2, 3, 4, 6, 8, 9, 10, 12, 14, 16, 18 }; 
            

            int inicio = 0;
            int fin = numeros.Length - 1;
            int posicion = -1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (numeros[medio] % 2 == 0)
                {
                    posicion = medio;
                    fin = medio - 1; 
                }
                else
                {
                    inicio = medio + 1; 
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"El primero esta en  {posicion}");
            }
            else
            {
                Console.WriteLine("No ai ");
            }



        }




    }
}
