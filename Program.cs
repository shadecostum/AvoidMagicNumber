using AvoidMagicNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidMagicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Magic numbers are hard-coded numeric values used directly in code without explanation.

            int studentScore = 60;
            ExamGrader exam=new ExamGrader();
            //use named constants to replace magic numbers.
            string grade =exam.GradeExam(studentScore);
            // string grade =exam.GradeExam(90); example for magic number
            Console.WriteLine($"Student's score: {studentScore}");
            Console.WriteLine($"Grade: {grade}");


            DayOfWeek currentDay = DayOfWeek.Sunday;

            if (currentDay == DayOfWeek.Sunday || currentDay == DayOfWeek.Saturday)
            {
                Console.WriteLine("It's the weekend! Time to relax.");
            }
            else
            {
                Console.WriteLine("It's a weekday. Time to work.");
            }
            
        }
        //Avoid Hardcoded Thresholds:
        //Using magic numbers may lead to typos or misunderstandings
        


    }
    public class Working
    {
        public enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

        //Use Enums for Discrete Values:
        // Enums represent a set of related named constants.

    }
}
    