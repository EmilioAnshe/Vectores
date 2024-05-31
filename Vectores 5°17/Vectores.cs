using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vectores
{
    public class Vectores
    {
        static void Main()
        {
            // Declaración del vector de notas
            int[] notas = new int[6];

            

            // Carga de las notas
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Ingrese la nota {i + 1}: ");
                notas[i] = int.Parse(Console.ReadLine());
            }

            // Cálculo de la nota más alta
            int notaMasAlta = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > notaMasAlta)
                {
                    notaMasAlta = notas[i];
                }
            }

            // Cálculo de la nota más baja
            int notaMasBaja = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] < notaMasBaja)
                {
                    notaMasBaja = notas[i];
                }
            }

            // Cálculo del promedio general
            float promedio = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                promedio += notas[i];
            }
            promedio /= notas.Length;

            // Mostrar resultados
            Console.WriteLine("\nNota mas alta: {0}", notaMasAlta);
            Console.WriteLine("Nota mas baja: {0}", notaMasBaja);
            Console.WriteLine("Promedio general: {0}", promedio);
        }
    }
}
