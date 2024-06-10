using System;

namespace GradesMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first grade: ");
            double firstGrade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second grade: ");
            double secondGrade = Convert.ToDouble(Console.ReadLine());

            double average = CalculateAverage(firstGrade, secondGrade);
            string gradeEquivalent = DetermineGradeEquivalent(average);

            Console.WriteLine("Average Grade: " + average);
            Console.WriteLine("Grade Equivalent: " + gradeEquivalent);
        }

        public static double CalculateAverage(double grade1, double grade2)
        {
            return (grade1 + grade2) / 2;
        }

        public static string DetermineGradeEquivalent(double average)
        {
            if (average < 0 || average > 100)
            {
                return "INVALID INPUT";
            }
            else if (average <= 50)
            {
                return "FAILED";
            }
            else if (average > 50 && average <= 70)
            {
                return "FAIR";
            }
            else if (average > 70 && average <= 80)
            {
                return "GOOD";
            }
            else if (average > 80 && average <= 90)
            {
                return "VERY GOOD";
            }
            else
            {
                return "EXCELLENT";
            }
        }
    }
}