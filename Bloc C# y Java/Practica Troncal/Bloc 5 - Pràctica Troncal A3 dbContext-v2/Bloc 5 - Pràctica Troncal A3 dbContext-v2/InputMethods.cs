using System;
using System.Collections.Generic;

namespace Bloc_5___Pràctica_Troncal_A3_dbContext_v2
{
    public class Input
    {
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
                
            }
            return 0;
        }
        public static double InputDouble()
        {
            double input;
            bool inputvalidated = double.TryParse(Console.ReadLine(), out input);
            if (inputvalidated == true)
            {
                return input;
            }
            else
            {
                return
            }

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