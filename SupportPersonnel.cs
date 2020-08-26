using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261019_w07
{
    class SupportPersonnel : Person
    {
        private int performanceLevel;


        public SupportPersonnel(string name, string lastname, int salary, int workedYear,
            int intentYearlyActivity, double assessFromAdmin, int performanceLevel)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Salary = salary;
            this.WorkedYear = workedYear;
            this.IntentYearlyActivity = intentYearlyActivity;
            this.AssessedFromAdmin = assessFromAdmin;
            this.performanceLevel = performanceLevel;
        }

        public int PerformanceLevel { get => performanceLevel; set => performanceLevel = value; }

        public double calculateSalaryRaise()
        {
            double scoreTotal = this.IntentYearlyActivity + this.AssessedFromAdmin + this.PerformanceLevel;
            Console.Write(scoreTotal);
            double totalSalary = 0;

            if (scoreTotal >= 95)
            {
                totalSalary = Salary * 0.03;
            }
            else if (scoreTotal >= 90)
            {
                totalSalary = Salary * 0.025;
            }
            else if (scoreTotal >= 85)
            {
                totalSalary = Salary * 0.02;
            }
            else if (scoreTotal >= 80)
            {
                totalSalary = Salary * 0.015;
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
                + " AssessedFromAdmin : " + this.AssessedFromAdmin + " PerformanceLevel : "
                + this.PerformanceLevel + " totalSalary : " + this.calculateSalaryRaise();
        }
    }
}
