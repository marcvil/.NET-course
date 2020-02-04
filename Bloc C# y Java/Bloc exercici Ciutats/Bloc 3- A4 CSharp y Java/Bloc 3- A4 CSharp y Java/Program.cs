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

            ///Array string de city
            string[] cityArray = new string[6];


            

            //Read USerInput
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Escriu el nom de la Ciutat " + (i + 1) + "\n");
                cityArray[i] = Console.ReadLine();
                

                
            }
            Console.Write("Enter per escriure el nom de les ciutats. \n");
            Console.ReadKey();

            //Arrays para conseguir el reverso
            string[] city1lettersArray = new string[city1.Length];


            string[] city2lettersArray = new string[city2.Length];


            string[] city3lettersArray = new string[city3.Length];


            string[] city4lettersArray = new string[city4.Length];


            string[] city5lettersArray = new string[city5.Length];


            string[] city6lettersArray = new string[city6.Length];


            for (int i = cityArray[0].Length - 1; i >= 0; i--)
            {
                city1lettersArray[i] = cityArray[0].Substring(i, 1);
            }


        }
    }
}
