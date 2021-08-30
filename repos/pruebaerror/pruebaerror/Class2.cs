using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueebaerror
{
    class Class2
    {
        static void Main(string[] args)
        {
            loops();

            Console.ReadLine();
        }
        
        public static void loops()
        {
           
            int[] numbers = new int[10];
            int sumatoria = 0; 

            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write("Escriba el valor para el elemento {0}: ", x);
                numbers[x] = Convert.ToInt32(Console.ReadLine());
            }

           
            int i = 0;
            Console.WriteLine("IMPRIME ELEMENTOS CON WHILE");
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i = i + 1; 
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (inc < numbers.Length);


            Console.WriteLine("IMPRIME ELEMENTOS CON FOR - ARREGLO ORDENADO");
            
            Array.Sort(numbers); 
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);

                
                sumatoria += numbers[j];
                
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH -  ARREGLO INVERTIDO");
            Array.Reverse(numbers); 
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine("El valor promedio es de: {0}", sumatoria / (numbers.Length));
        }

    }
}
