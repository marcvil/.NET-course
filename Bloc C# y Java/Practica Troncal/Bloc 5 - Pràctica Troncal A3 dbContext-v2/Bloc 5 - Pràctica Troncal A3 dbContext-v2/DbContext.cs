using System;
using System.Collections.Generic;

namespace Bloc_5___Pràctica_Troncal_A3_dbContext_v2
{
    public class DbContext
    {
        public Dictionary<Guid, Student> studentList = new Dictionary<Guid, Student>();
        public Dictionary<Guid, Exam> examList = new Dictionary<Guid, Exam>();
        public Dictionary<Guid, Subject> subjectList = new Dictionary<Guid, Subject>();


        public Dictionary<string, Student> studentByDni = new Dictionary<string, Student>();

        #region CRUD Operations

        #region Student CRUD
        public void CreateStudent() 
        {
        
        }
        public void ReadStudent()
        {

        }
        public void UpdateStudent()
        {

        }
        public void DeleteStudent()
        {

        }
        #endregion

        #region Subject CRUD
        public void CreateSubject()
        {

        }
        public void ReadSubject()
        {

        }
        public void UpdateSubject()
        {

        }
        public void DeleteSubject()
        {

        }
        #endregion

        #region Exam CRUD
        public void CreateExam()
        {

        }
        public void ReadExam()
        {

        }
        public void UpdateExam()
        {

        }
        public void DeleteExam()
        {

        }
        #endregion

        #endregion
    }
}

