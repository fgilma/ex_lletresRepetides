using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_LletresRepetides_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fase 1
            // Crear array char con nombre y hacer loop que muestre las letras
            char[] nombre = { 'F', 'r', 'a', 'n', 'c', 'i', 's', 'c', 'o' };
            foreach (char i in nombre)
            {
                Console.Write(i); //muestra cada letra del nombre
            }

            Console.WriteLine();
            Console.WriteLine();

            // Fase 2
            // Cambiar array char por lista y decir si cada letra es vocal, consonante
            // o existe algún número en el nombre

            List<char> nombreLista = new List<char>(nombre);
            string vocales = "aeiou";
            for (int i = 0; i < nombreLista.Capacity; i++)
            {
                if (Char.IsNumber(nombreLista[i]))
                {
                    Console.WriteLine("Los nombres de personas no contienen numeros.");
                    break; //si encuentra un numero sale del loop
                }
                else if (vocales.Contains(nombreLista[i]))
                    Console.WriteLine(nombreLista[i] + " es vocal."); //muestra si es vocal
                else
                    Console.WriteLine(nombreLista[i] + " es Consonante.");//muestra si es consonante
            }
            Console.WriteLine();

            // Fase 3
            // Crear diccionario con las letras como keys y values las veces que se repiten
            // en el nombre.

            Dictionary<char, int> diccionario = new Dictionary<char, int>();
            //crea diccionario
            for (int i = 0; i < nombreLista.Capacity; i++)
            {
                if (diccionario.ContainsKey(nombreLista[i]))
                    diccionario[nombreLista[i]]++;
                else
                    diccionario[nombreLista[i]] = 1;
            }
            //recorre diccionario para ver valores
            Console.WriteLine("El diccionario contiene:");
            foreach (KeyValuePair<char, int> i in diccionario)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.WriteLine();

            // Fase 4
            // Crear otra lista con el apellido y unirla a la lista del nombre
            // con un espacio entre nombre y apellido

            List<char> pepe = new List<char> { 'h', 'o', 'l', 'a' };


            List<char> apellido = new List<char>() { 'G', 'i', 'l' };
            Console.WriteLine("Unimos las dos listas de nombre y apellido:");
            nombreLista.Add(' ');
            nombreLista.AddRange(apellido);

            foreach (char i in nombreLista)
            {
                Console.Write(i);
            }

            
        }
    }
}
