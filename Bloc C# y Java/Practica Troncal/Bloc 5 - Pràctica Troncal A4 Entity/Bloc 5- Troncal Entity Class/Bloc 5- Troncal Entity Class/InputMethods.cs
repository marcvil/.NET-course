using System;
using System.Collections.Generic;
namespace Troncal_EntityClass
{
    public class Input
    {
        public static Persona BuscarAlumnoPorDni(Dictionary<int, Persona> listaStudent)
        {
            Console.WriteLine("Buscar alumno por DNI");
            int dniId = EntradaIntDNIPorConsola();

            if (listaStudent.ContainsKey(dniId))
            {
                return listaStudent[dniId];
            }

            else
            {
                DbContext.MuestraAlumnos();
                Console.WriteLine("El dni no existe. Vuelve a entrarlo.");
                BuscarAlumnoPorDni(listaStudent);
                return null;

            }
        }

        public static int EntradaIntDNIPorConsola()
        {
            int input;
            bool parseCheck = Int32.TryParse(Console.ReadLine(), out input);


            //Clause to see if it's really an int and 8 digits, else repeat the function
            if (parseCheck is true && input.ToString().Length == 8)
            {
                return input;
            }
            else
            {
                Console.WriteLine("No es un número o no tiene 8 dígitos. Vuelve a introducir");
                EntradaIntPorConsola();
                return input;
            }

        }
        public static int EntradaIntPorConsola()
        {
            int input;
            bool parseCheck = Int32.TryParse(Console.ReadLine(), out input);


            //Clause to see if it's really an int, else repeat the function
            if (parseCheck is true)
            {
                return input;
            }
            else
            {
                Console.WriteLine("No es un número. Vuelve a introducir el dato.");
                EntradaIntPorConsola();
                return 0;
            }

        }
        public static float EntradaFloatPorConsola()
        {
            float input = float.Parse(Console.ReadLine());


            return input;
        }

        public static string ReadIsString()
        {
            string str = Console.ReadLine();
            if (str != null && str is string)
            {
                return str;
            }
            else
            {
                return "undefined";
            }
        }

    }
}





