using System;

namespace Bloc_5___Pràctica_Troncal_A3_dbContext_v2
{
    public class Exam : Entity
    {
        public float FinalMark { get; set; }
        public DateTime ExamDate { get; set; }

        public Exam()
        {

        }
        public Exam(float finalMark)
        {
          
            this.FinalMark = finalMark;
        }

    }
}

