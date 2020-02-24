using System;

namespace Bloc_5___Pràctica_Troncal_A3_dbContext_v2
{

    public class Student : User
    {
        public string LockerKeyNumber { get; set; }

        public string Dni { get; set; }

        public Student(string lockerKeyNumber, string dni)
        {
            this.LockerKeyNumber = lockerKeyNumber;
            this.Dni = dni;
        }


        public static ValidationResult<string> ValidateLockerkeyNumber(string lockerKeyNumber)
        {
            ValidationResult<string> tempLockerkeyNumber = new ValidationResult<string>();

            tempLockerkeyNumber.ValidationSuccesful = true;

            #region Check null or empty
            if (string.IsNullOrEmpty(lockerKeyNumber))
            {
                tempLockerkeyNumber.ValidationSuccesful = false;
            }
            #endregion

            if (tempLockerkeyNumber.ValidationSuccesful == true)
            {
                tempLockerkeyNumber.ValidatedResult = lockerKeyNumber;
            }

            return tempLockerkeyNumber;
        }

        public static ValidationResult<string> ValidateDni(string dniNumber)
        {
            ValidationResult<string> tempIdSubject = new ValidationResult<string>();

            tempIdSubject.ValidationSuccesful = true;

            #region Check null or empty
            if (string.IsNullOrEmpty(dniNumber))
            {
                tempIdSubject.ValidationSuccesful = false;
            }
            #endregion

            if (tempIdSubject.ValidationSuccesful == true)
            {
                tempIdSubject.ValidatedResult = dniNumber;
            }

            return tempIdSubject;
        }


        public bool Save()
        {
            //Creo el objeto para guardar los valores de las validaciones
            var stringvalidation = ValidateLockerkeyNumber(this.LockerKeyNumber);
            if (stringvalidation.ValidationSuccesful == false)
            {
                return false;
            }

            var intvalidation = ValidateDni(this.Dni);
            if (intvalidation.ValidationSuccesful == false)
            {
                return false;
            }

            // check if guid is available. 
            //If not, it means that the Id we are checking is used by this subject, so we need to update the info
            if (this.Id == Guid.Empty)
            {
                DbContext.CreateStudent(this);
            }
            else
            {
                DbContext.UpdateStudent(this);
            }
            return true;
        }
    }
}

