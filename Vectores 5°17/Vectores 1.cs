using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vectores
{
    public class vectores{
    static void Mainl()
    {
        //hacer un programa que permita cargar 6 notas de un alumno luego cargar todas las notas debera recorrer el vector de dichas notas para mostrar la nota más alta, la nota mas baja y el promedio general

        int[] notas=new int [6];
        int i;
        for( i=0; 1<=5; i++)
        {
            System.Console.WriteLine("Ingresar las notas");
            notas[i]=int.Parse(Console.ReadLine());
        }
        if(notas[i]>notas[i])
        {
            System.Console.WriteLine("La nota mayor es:" +notas[i]);
        }
        else
        {
            System.Console.WriteLine("La nota menor es:" +notas[i]);
        }
    }
    }
}