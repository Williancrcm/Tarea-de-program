using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaerror
{
    class Class1
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Familiares = new Dictionary<string, int>();

            Familiares.Add("Willian Carcamo Jr", 19);
            Familiares.Add("Willlian Carcamo", 39);
            Familiares.Add("Elsy Bonilla", 32);
            Familiares.Add("Daniel Carcamo", 6);

            foreach (KeyValuePair<string, int> familia in Familiares)
            {
                Console.WriteLine("Clave: {0}, valor: {1}", Familiares.Keys, Familiares.Values);
            }
            {
                var dic = Familiares.Keys.ToList();
                dic.Sort();

                Console.WriteLine("Diccionario ordenado");
                foreach (var item in dic)
                {
                    Console.WriteLine("{0}: {1}", item, Familiares[item]);
                }
                Console.WriteLine("Elementos en el diccionario: {0}", Familiares.Count);
                Console.ReadKey();
            }
        }

    }
}
