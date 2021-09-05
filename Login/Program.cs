using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
         //Willian Alexander Carcamo Bonilla SMIS043620
	     static void Main(string[] args)
			{
				string password;
				string useradmin;
				int x;
				x = 1;
				while (x <= 3)
				{
					Console.WriteLine("Introduzca el nombre del usuario");
					useradmin = Console.ReadLine();
					if (useradmin.Equals("admin"))
					{
						x = 1;
						while (x <= 3)
						{
							Console.WriteLine("Introduzca la contraseña");
							password = Console.ReadLine();
							
							if (password.Equals("123"))
							{
								Console.WriteLine("Bienvenido admin");
								Console.WriteLine("1- Agregar usuario");
								Console.WriteLine("2- Crear archivo");
								Console.WriteLine("3- Borrar archivo");
								Console.WriteLine("4- Salir");


								Console.ReadLine();
								x = 4;
							}
							else
							{
								Console.WriteLine("Contraseña incorrecta");
								if (x == 3)
								{
									Console.WriteLine("Has fallado muchos intentos");
									Console.ReadLine();
								}
								x = x + 1;
							}
						}
						x = 4;
					}
					else
					{

						Console.WriteLine("El usuario es incorrecto");
						if (x == 3)
						{
							Console.WriteLine("Has fallado muchos intentos");
							Console.ReadLine();
						}
						x = x + 1;


					}
				}
		 }
    }
}
