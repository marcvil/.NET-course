using System;

namespace Bloc_3__A4_CSharp_y_Java
{
    class Program
    {
        static void Main(string[] args)
        {
            /*VARIABLES*/
            string city1;
            string city2;
            string city3;
            string city4;
            string city5;
            string city6;

            string[] cityArray = new string[6];

            //Read USerInput
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Escriu el nom de la Ciutat " + (i + 1) + "\n");
                cityArray[i] = Console.ReadLine();
            }
            Console.Write("Enter per escriure el nom de les ciutats. \n");
            Console.ReadKey();
            

            for (int j = 0; j < 6; j++)
            {
                string[] currentCityArray = new string[cityArray[j].Length];
                
                for (int k = 0; k < currentCityArray.Length; k++)
                {
                    char[] temp = new char[currentCityArray.Length];
                    temp = cityArray[j].ToCharArray();
                    
                    
                    for (int m = 0; m <=temp.Length; m++ )
                    {
                        currentCityArray[m] = temp[k].ToString();
                        Console.Write(currentCityArray[m] + "\n");
                    }
                    
                    
                    
                }
                

                /*
                cityArray[j] = cityArray[j].Replace("a", "4");

                Console.Write("El nom de la ciutat " + (j + 1) + " és: " + cityArray[j] + "\n");
                */
            }
        }
    }
}
