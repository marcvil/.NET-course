using System;
using System.Collections.Generic;

namespace Bloc_5___Pràctica_Troncal_A3_dbContext_v2
{
    public class Input
    {
        
        public static User SearchById(Dictionary<int, User> listaStudent)
        {
            
            Console.WriteLine("Buscar alumno por DNI");
            int dniId = InputDNI();

            if (listaStudent.ContainsKey(dniId))
            {
                return listaStudent[dniId];
            }

            else
            {
                return null;
            }
            
            
        }
        
        
        public static int InputDNI()
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
                InputDNI();
                return input;
            }

        }
        public static int InputInt()
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
                InputInt();
                return 0;
            }

        }
        public static float InputFloat()
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