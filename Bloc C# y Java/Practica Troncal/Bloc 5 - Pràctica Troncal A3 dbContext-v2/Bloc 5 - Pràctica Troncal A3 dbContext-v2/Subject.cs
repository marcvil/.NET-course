using System;

namespace Bloc_5___Pràctica_Troncal_A3_dbContext_v2
{

    public class Subject : Entity    
    {
        public string SubjectName { get; set; }
        public int IdSubject { get; set; }

        public Subject()
        {

        }
        public Subject(int idSubject, string subjectName)
        {
            this.IdSubject = idSubject;
            this.SubjectName = subjectName;

        }
    }
}

