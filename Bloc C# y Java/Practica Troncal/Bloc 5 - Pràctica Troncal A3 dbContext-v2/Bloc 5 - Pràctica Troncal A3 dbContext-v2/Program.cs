using System;

namespace Bloc_5___Pràctica_Troncal_A3_dbContext_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool looping = true;

            Console.WriteLine("Hola Profesor! Esta es una aplicación para ayudarte a analizar las notas de tus alumnos.");
            ShowMainMenu();
            while (looping)
            {
                option = Input.InputInt();

                if (option == 1)
                {
                    Console.Clear();
                    ShowStudentsManagementMenu();
                    Console.Clear();
                    ShowMainMenu();

                }
                else if (option == 2)
                {
                    //Show Menu Subject Management
                }
                else if (option == 3)
                {
                    //Show Menu Exams
                   
                }
                
                else
                {
                    Console.WriteLine("El número no es valido. Vuelve a introducir los datos.");
                    ShowMainMenu();
                }
            }

            Console.ReadKey();
        }
        static void ShowMainMenu()
        {
            Console.WriteLine("Elige una opción de las siguientes: ");

            Console.WriteLine("1. Gestión de alumnos.");
            Console.WriteLine("2. Gestión asignaturas.");
            Console.WriteLine("3. Gestión Notas.");
            Console.WriteLine("4. Salir de la aplicación.");
            
        }

        static void ShowStudentsManagementMenu()
        {
            int option = 0;
            bool looping = true;
            while (looping)
            {

                Console.WriteLine("Elige una opción de las siguientes: ");

                Console.WriteLine("1. Crear alumno.");
                Console.WriteLine("2. Mostrar alumno.");
                Console.WriteLine("3. Modificar alumno.");
                Console.WriteLine("4. Borrar alumno.");
                Console.WriteLine("5. Muestra todos los alumnos.");
                Console.WriteLine("6. Volver al menu.");

                option = Input.InputInt();
                if (option == 1) 
                {
                    Console.Clear();
                    //TODO CreateStudent()
                   
                }
                else if (option == 2)
                {
                    Console.Clear();
                    //TODO ReadStudent()
                }
                else  if (option == 3)
                {
                    Console.Clear();
                    //TODO UpdateStudent()
                }
                else if (option == 4)
                {
                    Console.Clear();
                    //TODO DeleteStudent()
                }
                else if (option == 5)
                {

                }
                else 
                {
                    looping = false;
                }

            }
        }
        static void ShowSubjectsManagementMenu()
        {
            int option = 0;
            bool looping = true;
            while (looping)
            {
                Console.WriteLine("Elige una opción de las siguientes: ");

                Console.WriteLine("1. Crear Asignatura.");
                Console.WriteLine("2. Mostrar Asignatura.");
                Console.WriteLine("3. Modificar Asignatura.");
                Console.WriteLine("4. Borrar Asignatura.");
                Console.WriteLine("5. Muestra todas las Asignatura de un alumno.");
                Console.WriteLine("6. Volver al Menú principal.");

                if (option == 1)
                {
                    Console.Clear();
                    //TODO CreateAsignatura()
                }
                else if (option == 2)
                {
                    Console.Clear();
                    //TODO ReadAsignatura()
                }
                else if (option == 3)
                {
                    //TODO UpdateAsignatura()
                }
                else if (option == 4)
                {
                    //TODO DeleteAsignatura()
                }
                else if (option == 5)
                {

                }
                else
                {
                    looping = false;
                }

            }
        }
        static void ShowExamManagementMenu()
        {
            int option = 0;
            bool looping = true;
            while (looping)
            {
                Console.WriteLine("Elige una opción de las siguientes: ");

                Console.WriteLine("1. Crear Examen.");
                Console.WriteLine("2. Mostrar Examen.");
                Console.WriteLine("3. Modificar Examen.");
                Console.WriteLine("4. Borrar Examen.");
                Console.WriteLine("5. Muestra todos los Examenes de un alumno.");
                Console.WriteLine("6. Volver al Menú principal.");

                if (option == 1)
                {
                    Console.Clear();
                    //TODO CreateExam()
                }
                else if (option == 2)
                {
                    //TODO ReadExam()
                }
                else if (option == 3)
                {
                    //TODO UpdateExam()
                }
                else if (option == 4)
                {
                    //TODO DeleteExam()
                }
                else if (option == 5)
                {

                }
                else
                {
                    looping = false;
                }

            }
        }
        static void ShowAnalisisMenu()
        {
            Console.WriteLine("Elige una opción de las siguientes: ");

            Console.WriteLine("1. Ver la nota media de todos los alumnos.");
            Console.WriteLine("2. Ver el alumno con la nota mínima.");
            Console.WriteLine("3. Ver el alumno con la nota máxima.");
            Console.WriteLine("4. Volver al menú principal");

        }
    }
    
}
