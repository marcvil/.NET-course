using System;
namespace Troncal_EntityClass
{
    public class Subject
    {
        private string subjectName;
        public string SubjectName { get => subjectName; set => subjectName = value; }



        private int idSubject;
        public int IdSubject { get => idSubject; set => idSubject = value; }



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
