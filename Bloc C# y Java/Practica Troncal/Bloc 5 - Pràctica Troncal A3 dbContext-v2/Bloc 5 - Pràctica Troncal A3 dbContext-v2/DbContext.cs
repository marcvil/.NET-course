using System;
using System.Collections.Generic;
using System.Linq;

namespace Bloc_5___Pràctica_Troncal_A3_dbContext_v2
{
    public class DbContext
    {
        public static Dictionary<Guid, Student> studentList = new Dictionary<Guid, Student>();
        public static Dictionary<Guid, Exam> examList = new Dictionary<Guid, Exam>();
        public static Dictionary<Guid, Subject> subjectList = new Dictionary<Guid, Subject>();


        public static Dictionary<string, Student> studentByDni = new Dictionary<string, Student>();

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
        public static bool CreateSubject(Subject subject)
        {
            if(subject.Id != Guid.Empty)
            {
                return false;
            }

            subject.Id = Guid.NewGuid();
            subjectList.Add(subject.Id, subject);
            return true;
        }
        public static Subject ReadSubject(string subjectName)
        {
            return subjectList.Values.FirstOrDefault(x => x.SubjectName == subjectName);
        }
        public static bool UpdateSubject(Subject subject)
        {
            if (subject.Id != Guid.Empty && DbContext.subjectList.ContainsKey(subject.Id))
            {
                Subject tempSubject = subjectList[subject.Id];
                if (subject != tempSubject)
                {
                    subjectList[subject.Id] = subject;

                }
            }
            else
            {
                CreateSubject(subject);
            }
            return true;
        }
        public static bool DeleteSubject(Subject subject)
        {
            if (DbContext.subjectList.ContainsKey(subject.Id))
            {
                subjectList.Remove(subject.Id);
                return true;
            }
            else return false;
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

