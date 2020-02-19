using System;
using System.Collections.Generic;
namespace Troncal_EntityClass
{
    public class Persona
    {

        public string Name { get => name; set => name = value; }
       public  int Age { get => age; set => age = value; }
        public int Dni { get => dni; set => dni = value; }
        public Dictionary<Subject, List<Exam>> ListaExam { get => listaExam; set => listaExam = value; }

        Dictionary<Subject, List<Exam>> listaExam;
        private string name;
        private int age;
        private int dni;

        public Persona(int age)
        {
            this.age = age;
        }
        public Persona(string name, int age, int dni)
        {

            this.name = name;
            this.age = age;
            this.dni = dni;
        }




        public string ShowPersonInfo()
        {
            string phrase = ("Nombre: " + name + "\n"
                    + "Edad:" + age + " años" + "\n"
                    + "DNI: " + dni);

            return phrase;
        }


    }



}
