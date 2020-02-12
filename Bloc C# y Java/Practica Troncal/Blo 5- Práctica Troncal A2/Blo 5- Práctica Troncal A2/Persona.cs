using System;

namespace Blo_5__Práctica_Troncal_A2
{


    public class Persona
    {

        string name { get; set; }
        int age { get; set; }
        int dni { get; set; }



        public Persona()
        {

        }
        public Persona(string name, int age, int dni)
        {

            this.name = name;
            this.age = age;
            this.dni = dni;
        }

        public void ShowInfo()
        {
            Console.WriteLine("método: la persona con nombre " + name
                    + " que tiene " + age + " años"
                    + " y que tiene el siguiente dni: " + dni);
        }


    }

    

}
