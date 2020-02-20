using System;

namespace Bloc_5___Pràctica_Troncal_A3_dbContext_v2
{

    public class Student : User
    {
        public int LockerKeyNumber { get => lockerKeyNumber; set => lockerKeyNumber = value; }
        private int lockerKeyNumber;

        public string Dni { get => dni; set => dni = value; }
        private string dni;

        public Student(int lockerKeyNumber, string dni)
        {
            this.lockerKeyNumber = lockerKeyNumber;
            this.dni = dni;
        }
    }
}

