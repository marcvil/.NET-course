using System;

namespace Bloc_5___Pràctica_Troncal_A3_dbContext_v2
{

    public class Student : User
    {
        public int LockerKeyNumber { get; set; }

        public string Dni { get; set; }

        public Student(int lockerKeyNumber, string dni)
        {
            this.LockerKeyNumber = lockerKeyNumber;
            this.Dni = dni;
        }
    }
}

