using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace GPACalculator
{
    public class GpaCalc
    {
        


        public static void GradePointAverageCalculator(IEnumerable<Course> newCourseTable)
        {
            Grades GradeLetter;
            int GradePoint;
            double GPA = 0d, QualityPoint=0;
            int totalUnit = 0;
             
            foreach (var i in newCourseTable)
            {
                if (i.CourseScore >= 70)
                {
                    GradeLetter = Grades.A;
                    GradePoint = (int)Grades.A;
                }
                else if (i.CourseScore >= 60 && i.CourseScore <= 69)
                {
                    GradeLetter = Grades.B;
                    GradePoint = (int)Grades.B;
                }
                else if (i.CourseScore >= 50 && i.CourseScore <= 69)
                {
                    GradeLetter = Grades.C;
                    GradePoint = (int)Grades.C;
                }
                else if (i.CourseScore >= 45 && i.CourseScore <= 49)
                {
                    GradeLetter = Grades.D;
                    GradePoint = (int)Grades.D;
                }
                else if (i.CourseScore >= 40 && i.CourseScore <= 44)
                {
                    GradeLetter = Grades.E;
                    GradePoint = (int)Grades.E;
                }
                else
                {
                    GradeLetter = Grades.F;
                    GradePoint = (int)Grades.F;
                }


                totalUnit += i.NumberOfUnits;
                QualityPoint += GradePoint * totalUnit;
                Menu.PromptUser ($"{"Course Code", -15} | {"Units", 5} | {"Score", 5} | {"Grade", 5}");
                Menu.PromptUser($"{i.CourseCode.ToUpper(), -15} {i.NumberOfUnits, 5} {i.CourseScore, 7} {GradeLetter, 7}");
             
            }
                GPA = QualityPoint / totalUnit;
                Menu.PromptUser($"Your GPA is: {GPA}");
                 


        }

       
         
               






    }
}
