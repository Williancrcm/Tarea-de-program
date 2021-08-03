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
		{
			Console.WriteLine("Introduzca el valor de la temperatura en grados ºC:");
			double grados_c = double.Parse(Console.ReadLine());
			double grados_f = (grados_c * 9 / 5) + 32;
			Console.WriteLine("La temperatura en grados Fahrenheit es: " + grados_f);
			Console.WriteLine("--------------------------------------------------------------");
		}
	}
}