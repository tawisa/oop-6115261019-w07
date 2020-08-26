using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261019_w07
{
    class Lecturer : Person
    {
        private double paparMark;
        private double academicServiceMark;
        private double researchMark;





        public Lecturer(string name, string lastname, int salary, int workedYear,
            int intentYearlyActivity, double assessFromAdmin, double paparMark, double academicServiceMark, double researchMark
           )
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Salary = salary;
            this.WorkedYear = workedYear;
            this.IntentYearlyActivity = intentYearlyActivity;
            this.AssessedFromAdmin = assessFromAdmin;
            this.PaparMark = paparMark;
            this.AcademicServiceMark = academicServiceMark;
            this.researchMark = researchMark;


        }

        public double PaparMark { get => paparMark; set => paparMark = value; }
        public double AcademicServiceMark { get => academicServiceMark; set => academicServiceMark = value; }
        public double ResearchMark { get => researchMark; set => researchMark = value; }


        public double calculateSalaryRaise()
        {
            double scoreTotal = this.IntentYearlyActivity + this.AssessedFromAdmin + this.PaparMark + this.AcademicServiceMark + this.ResearchMark;
            Console.Write(scoreTotal);
            double totalSalary = 0;

            if (scoreTotal >= 90)
            {
                totalSalary = Salary * 0.03;
            }
            else if (scoreTotal >= 85)
            {
                totalSalary = Salary * 0.025;
            }
            else if (scoreTotal >= 80)
            {
                totalSalary = Salary * 0.02;
            }
            else if (scoreTotal >= 70)
            {
                totalSalary = Salary * 0.01;
            }
            else if (scoreTotal <= 70)
            {
                totalSalary = 0;
            }

            return totalSalary;

        }

        public override string ToString()
        {
            return base.ToString() + " IntentYearlyActivity : " + this.IntentYearlyActivity
                + " AssessedFromAdmin : " + this.AssessedFromAdmin + " PaparMark : " + this.PaparMark + " AcademicServiceMark : "
                + this.AcademicServiceMark + " Research Mark : " + this.researchMark + " : " + this.calculateSalaryRaise();
        }
    }
}