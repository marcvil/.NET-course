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
        public static bool CreateStudent(Student student) 
        {
            return true;
        }
        public void ReadStudent()
        {

        }
        public static bool UpdateStudent(Student student)
        {
            return true;
        }
        public static bool DeleteStudent(Student student)
        {
            return true;
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
        public static bool CreateExam(Exam exam)
        {
            if (exam.Id != Guid.Empty)
            {
                return false;
            }

            exam.Id = Guid.NewGuid();
            examList.Add(exam.Id, exam);
            return true;
        }
        public void ReadExam()
        {
            // Solo tengo atributos finalMark y ExamDate, ninguno de ellos seria llave primaria en la base de datos para identificarlo inequívocamente
            // Puedo añadir variables de subject y student a Exam, aunque creo que una vez hechos los repositories podremos relacionarlo sin
            //hacer cluster de variables a lo loco
            // return examList.Values.FirstOrDefault(x => x.Name == subjectName);
        }
        public static bool UpdateExam(Exam exam)
        {
            if (exam.Id != Guid.Empty && DbContext.examList.ContainsKey(exam.Id))
            {
                Exam tempexam = examList[exam.Id];
                if (exam != tempexam)
                {
                    examList[exam.Id] = exam;

                }
            }
            else
            {
                CreateExam(exam);
            }
            return true;
        }
        public static bool DeleteExam(Exam exam)
        {
            if (DbContext.examList.ContainsKey(exam.Id))
            {
                subjectList.Remove(exam.Id);
                return true;
            }
            else return false;
        }
        #endregion

        #endregion
    }
}

