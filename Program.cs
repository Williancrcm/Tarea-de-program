using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_la_tercera_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;

namespace ConsoleApplication1
    {
        class Program
        {
            static void Main(string[] args)
            {
                int sum = 0;
                int numero1 = 0; int numero2 = 0; int numero3 = 0; int numero4 = 0;

                {
                    Console.WriteLine("Primer Parcial");
                    numero1 = Int32.Parse(Console.ReadLine());
                }
                if (numero1 > 15 == true)
                {
                    Console.WriteLine("Calificacion Invalida");
                    Console.WriteLine("Introduzca Nuevamente");
                    numero1 = Int32.Parse(Console.ReadLine());
                }


                {
                    Console.WriteLine("Segundo Parcial");
                    numero2 = Int32.Parse(Console.ReadLine());
                }
                if (numero2 > 15 == true)
                {
                    Console.WriteLine("Calificacion Invalida");
                    Console.WriteLine("Introduzca Nuevamente");
                    numero2 = Int32.Parse(Console.ReadLine());
                }

                {
                    Console.WriteLine("Practica");
                    numero3 = Int32.Parse(Console.ReadLine());
                }
                if (numero3 > 30 == true)
                {
                    Console.WriteLine("Calificacion Invalida");
                    Console.WriteLine("Introduzca Nuevamente");
                    numero3 = Int32.Parse(Console.ReadLine());
                }

                {
                    Console.WriteLine("Examen Final");
                    numero4 = Int32.Parse(Console.ReadLine());
                }
                if (numero4 > 40 == true)
                {
                    Console.WriteLine("Calificacion Invalida");
                    Console.WriteLine("Introduzca Nuevamente");
                    numero4 = Int32.Parse(Console.ReadLine());
                }

                {
                    sum = numero1 + numero2 + numero3 + numero4;
                    Console.WriteLine("Su Calificacion es : {0}", sum);
                }


                if (sum <= 60 == true)
                {
                    Console.WriteLine("Reprobado ");
                }
                else
                    if (sum <= 69 == true)
                {
                    Console.WriteLine("Extraordinario");
                }
                else

                         if (sum <= 95 == true)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                                    if (sum <= 100 == true)
                {
                    Console.WriteLine("Excelente");
                }

                Console.ReadKey();

            }
        }
    }
}
    }
}
