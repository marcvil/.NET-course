using System;
using System.Collections.Generic;

namespace Troncal_DbContext
{
    public class DbContext
    {
       public static Dictionary<int, Persona> listaStudent = new Dictionary<int, Persona>();

         public static void AñadirStudent()
        {
            Console.Clear();
            
            int option2 = 1;
            while (option2 == 1)
            {

                Console.WriteLine("Entra el nombre del alumno. ");
                string nombreAlumno = Input.ReadIsString();
                Console.WriteLine("Entra la edad de " + nombreAlumno);
                int age = Input.EntradaIntPorConsola();
                Console.WriteLine("Entra su DNI. NO Hace falta letra.");
                int dni = Input.EntradaIntDNIPorConsola();
                Persona student = new Persona(nombreAlumno, age, dni);
                listaStudent.Add(dni, student);
               

                Console.WriteLine("¿Quieres seguir añadiendo notas? Pulsa 1 para seguir y 0 para salir.");
                option2 = Input.EntradaIntPorConsola();
                Console.Clear();
            }
            
        }

        public static void ModifyStudent()
        {

            //Voy a suponer que el codigo del dni es invariable, por lo que las keys del diccionario no pueden cambiar.
            Persona alumno = Input.BuscarAlumnoPorDni(listaStudent);
           
            Console.WriteLine("Vas a cambiar los datos del alumno: " + alumno.Name +"\n" +
                                "con DNI: " + alumno.Dni + "\n" +
                                "y que tiene " + alumno.Age + "\n" +
                                "Está seguro que quiere cambiarla? Pulse 1 para continuar o 0 para cancelar."
                                );
            int option = Input.EntradaIntPorConsola();
            if( option == 1)
            {
                Console.WriteLine("Entra el nuevo nombre del alumno. " );
                alumno.Name = Input.ReadIsString();
                Console.WriteLine("Entra la nueva edad del alumno.");
                alumno.Age = Input.EntradaIntPorConsola();

                Console.WriteLine("La operación se ha realizado correctamente.");
               
              
            }
            else if(option == 0)
            {
                Console.WriteLine("La operación se ha cancelado.");
            }
            else
            {
                Console.WriteLine("No has entrado correctamente el número. Se cancelará la operación.");
                
            }
        }

        public static void EliminateStudent()
        {
            Persona alumno = Input.BuscarAlumnoPorDni(listaStudent);
            Console.WriteLine("has elegido al alumno que se llama: " + alumno.Name + "\n" +
                                "con DNI: " + alumno.Dni + "\n" +
                                "y que tiene " + alumno.Age + "\n" +
                                "Está seguro de querer eliminarlo? Pulse 1 para continuar o 0 para cancelar."
                                );
            int option = Input.EntradaIntPorConsola();
            if(option == 1)
            {
                listaStudent.Remove(alumno.Dni);
            }
            else 
            {
                Console.WriteLine("No has entrado correctamente el número. Se cancelará la operación.");
            }

        }


        public static void MuestraAlumnos()
        {
            Console.WriteLine("Esta es la lista alumnos en el sistema");
            foreach (KeyValuePair<int, Persona> student in listaStudent)
            {
                Console.WriteLine(student.Key);
                Console.WriteLine(student.Value.ShowPersonInfo());
            }
            Console.WriteLine("Pulsa cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

       public static void AñadirSubjectyNotas()
        {
            Persona alumno = Input.BuscarAlumnoPorDni(listaStudent);
            Dictionary<Subject, List<Exam>> listaSubjectExam = new Dictionary<Subject, List<Exam>>();
            if (alumno != null)
            {
                int option = 1;
                while (option == 1)
                {
                    listaSubjectExam.Add(CrearAsignatura(), CrearListaExamenes());

                    Console.WriteLine("Quieres añadir más ASIGNATURAS? Pulsa 1 para añadir o 0 para salir.");
                    option = Input.EntradaIntPorConsola();
                }
                alumno.ListaExam = listaSubjectExam;
            }
            else
            {
                Console.WriteLine("No existe ningún alumno con este Id.");
            }


        }

        public static Subject CrearAsignatura()
        {
            Subject subj = new Subject();
            Console.WriteLine("Entra el nombre de una asignatura que esta cursando el alumno");
            subj.SubjectName = Input.ReadIsString();
            Console.WriteLine("Entra el id de esta asignatura");
            subj.IdSubject = Input.EntradaIntPorConsola();

            return subj;
        }

        public static List<Exam> CrearListaExamenes()
        {
            int option = 1;
            int numExam = 1;
            List<Exam> listaNotasExamen = new List<Exam>();
            while (option == 1)
            {
                Exam exam = new Exam();
                Console.WriteLine("Añade la nota del examen número: " + numExam);
                exam.FinalMark = Input.EntradaFloatPorConsola();
                Console.WriteLine("Añade el Id del examen");
                exam.ExamId = Input.EntradaIntPorConsola();
                listaNotasExamen.Add(exam);

                Console.WriteLine("Quieres añadir más EXAMENES? Pulsa 1 para añadir o 0 para salir.");
                option = Input.EntradaIntPorConsola();

            }

            return listaNotasExamen;

        }

        public static void MuestraNotas()
        {
            Persona alumno = Input.BuscarAlumnoPorDni(listaStudent);

            Console.WriteLine("El alumno esta cursando las siguientes asignaturas.");

            foreach (Subject s in alumno.ListaExam.Keys)
            {
                Console.WriteLine("Nombre Asignatura = {0}, Id Asignatura = {1}", s.SubjectName, s.IdSubject);
            }

            Console.WriteLine("Entra el nombre de la asignatura que quieres mirar las notas.");
            string str = Console.ReadLine();

            foreach (KeyValuePair<Subject, List<Exam>> c in alumno.ListaExam)
            {
                if (c.Key.SubjectName == str)
                {
                    foreach (Exam ex in c.Value)
                    {
                        Console.WriteLine("Nota examen = {0}, Id Examen = {1}", ex.FinalMark, ex.ExamId);
                    }
                }
            }

        }

        static void ShowMenuChangeStudentInfo()
        {
            Console.WriteLine("Elige una opción de las siguientes: ");

            Console.WriteLine("1. Cambair todos los datos del alumno.");
            Console.WriteLine("2. Cambiar el nombre.");
            Console.WriteLine("3. Cambiar el DNI.");
            Console.WriteLine("4. Cambiar edad.");

        }


    }
}
