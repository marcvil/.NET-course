using System;
using System.Collections.Generic;

namespace Troncal_DbContext
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool looping = true;

            //Dictionary<int, Persona> listaStudent = new Dictionary<int, Persona>();


            Console.WriteLine("Hola Profesor! Esta es una aplicación para ayudarte a analizar las notas de tus alumnos.");

            ShowMainMenu();

            while (looping)
            {
                option = Input.EntradaIntPorConsola();

                if (option == 1)
                {
                    DbContext.AñadirStudent();
                    Console.Clear();
                    ShowMainMenu();

                }
                else if (option == 2)
                {
                    DbContext.MuestraAlumnos();

                    ShowMainMenu();
                }
                else if (option == 3)
                {

                    DbContext.AñadirSubjectyNotas();

                    ShowMainMenu();
                }
                else if (option == 4)
                {
                    DbContext.MuestraAlumnos();
                    Console.ReadKey();
                    Console.Clear();
                    ShowMainMenu();

                }
                else if( option == 5)
                {
                    DbContext.ModifyStudent();
                    Console.WriteLine("Pulsa cualquier botón para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    ShowMainMenu();
                }
                else if (option == 6)
                {
                    DbContext.EliminateStudent();
                    Console.WriteLine("Pulsa cualquier botón para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    ShowMainMenu();

                }
                else if (option == 7)
                {
                    DbContext.MuestraNotas();
                    Console.WriteLine("Pulsa cualquier botón para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    ShowMainMenu();
                }
                else
                {
                    Console.WriteLine("El número no es valido. Vuelve a introducir los datos.");
                    ShowMainMenu();
                }
            }

            Console.ReadKey();
        }

        #region TextMenus
        static void ShowMainMenu()
        {
            Console.WriteLine("Elige una opción de las siguientes: ");

            Console.WriteLine("1. Añadir alumno.");
            Console.WriteLine("2. Mostrar alumnos.");
            Console.WriteLine("3. Añadir subjects a alumno.");
            Console.WriteLine("4. Muestra Notas de un alumno.");
            Console.WriteLine("5. Modifica datos de los alumnos.");
            Console.WriteLine("6. Elimina a un alumno.");

        }
        static void ShowAnalisisMenu()
        {
            Console.WriteLine("Elige una opción de las siguientes: ");

            Console.WriteLine("1. Ver la nota media de todos los alumnos.");
            Console.WriteLine("2. Ver el alumno con la nota mínima.");
            Console.WriteLine("3. Ver el alumno con la nota máxima.");
            Console.WriteLine("4. Volver al menú principal");

        }
        #endregion
    }
}

       

      
