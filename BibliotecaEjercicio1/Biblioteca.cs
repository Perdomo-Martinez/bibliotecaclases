using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEjercicio1
{
    public class Biblioteca
    {
		public static void SortedListCollection()
		{
			//cree una biblioteca que determine cuantas letras tiene una frase 

			//declaracion variables 
			string chr;
			int contador;
			int i;
			string txt;
			//inicio contador
			contador = 0;
			//
			Console.Write("    CONTADOR DE CARACTERES    ");

			//pido y almaceno los datos 
			Console.WriteLine("Ingrese una frase: ");
			txt = Console.ReadLine();

			//proceso
			for (i = 1; i <= txt.Length; i++)
			{
				chr = txt.Substring(i - 1, i - i + 1);
				if (!chr.Equals(" "))
				{
					contador = contador + 1;
				}
			}
			//muestro los datos 
			Console.WriteLine("Cantidad de letras: " + contador);
			Console.ReadKey();
		}
	}
}
