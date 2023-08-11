using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidMagicNumber.Models
{
    internal class ExamGrader
    {
        private const int ExcellentScore = 90;
        private const int GoodScore = 75;
        private const int AverageScore = 50;

        public  string GradeExam(int score)
        {
            if (score >= ExcellentScore)
            {
                return "Excellent";
            }
            else if (score >= GoodScore)
            {
                return "Good";
            }
            else if (score >= AverageScore)
            {
                return "Average";
            }
            else
            {
                return "Below Average";
            }
        }
    }
}
