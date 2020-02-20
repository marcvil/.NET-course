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
                   

                }
                else if (option == 2)
                {
                    
                }
                else if (option == 3)
                {

                   
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

            Console.WriteLine("1. Añadir alumno.");
            Console.WriteLine("2. Mostrar alumnos.");
            Console.WriteLine("3. Añadir subjects a alumno.");
            Console.WriteLine("4. Muestra alumnos.");
            Console.WriteLine("5. Modifica datos de los alumnos.");
            Console.WriteLine("6. Elimina a un alumno.");
            Console.WriteLine("7. Muestra Asignaturas de un alumno.");
            Console.WriteLine("8. Muestra Notas de una asignatura de un alumno.");
            Console.WriteLine("9. Modificar Asignatura");
            Console.WriteLine("10. Eliminar Asignatura y sus examenes.");
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
