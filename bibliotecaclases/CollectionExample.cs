using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaclases
{
    public class CollectionExample
    {
        public static void SortedListCollection()
        {
            //definir el tamaño de la lista
            Console.Write("Cuantos elementos agregara a la lista");
            var elements = Convert.ToInt32(Console.ReadLine());

            //declarar array vacios 
            object[] key = new object[elements];
            object[] value = new object[elements];


            //declarar la lista 
            SortedList<object, object> srtList = new SortedList<object, object>();
            int i = 0;

            while (i < elements)
            {
                Console.WriteLine("Escriba el numero a agregar {0}", i);

                //llenar los arrays 
                Console.Write("Key: ");
                key[i] = Console.ReadLine();
                Console.Write("Value: ");
                value[i] = Console.ReadLine();

                //llenar la lista 
                srtList.Add(key[i], value[i]);

                i++;
            }

            //mostrar elementos en la lista
            Console.WriteLine("****Elementos en la lista****");
            foreach (KeyValuePair<object, object> element in srtList) 
            {
                Console.WriteLine("{0}: {1}", element.Key, element.Value);
              
            }



        }
    }
}
