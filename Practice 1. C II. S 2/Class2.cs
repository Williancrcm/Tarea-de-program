using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.C_II.S_2

{

    static void Main(string[] args)

    {

        int na = 0;//Nunmero de articulos
        int a = 0;//Articulos
        int t = 0;//Total
        int s = 0;
        Console.WriteLine("\tTienda Chavez")
        Console.WriteLine("\n\tPrograma para calcular el precio total a pagar de un comprador");
        Console.WriteLine("\nNumero de articulos a comprar");
        na = int.Parse(Console.ReadLine());
        REPETIR: 
        if (t++ < na)
        {
            Console.WriteLine("\nintroducir precio de cada articulo");
            a = int.Parse(Console.ReadLine());
            s = s + a;
            goto REPETIR;
        }
        Console.WriteLine("la suma total es {0}", s);
        Console.Read();

    }

}


