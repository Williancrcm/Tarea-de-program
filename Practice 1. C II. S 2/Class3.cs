using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.C_II.S_2
{
    class Program
    {
        static void Main(string[] args)
        int alum = 0;
        double not = 0;
        double promedio = 0;

        Console.WriteLine("La nota de cuantos alumnos evaluara");
        alum=int.Parse(Console.ReadLine());
   
        for(int i =0;i<=alum;i++){
        Console.WriteLine("Digite nota para el alumno: "+(i+1)); 
        not=double.Parse(Console.ReadLine());
        promedio=promedio+not;
    
    
    
    }
        Console.WriteLine("El promedio es : "+(promedio/alum));
       Console.ReadKey();
}
 



