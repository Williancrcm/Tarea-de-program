using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaerror
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            numbers[0] = 4;
            numbers[1] = 10;
            numbers[2] = 5;
            numbers[3] = 7;
            numbers[4] = 9;
            numbers[5] = 4;
            numbers[6] = 3;
            numbers[7] = 8;
            numbers[8] = 5;
            numbers[9] = 8;

            double[] calificaciones = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            double sumatoria = 0;

            foreach (double calificacion in calificaciones)
            {
                sumatoria += calificacion;
            }
            double promedio = sumatoria / calificaciones.Length;

                Console.WriteLine("Promedio: " + promedio);
            Console.ReadLine();
        }
    }
}
