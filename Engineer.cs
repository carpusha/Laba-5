using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Engineer : IEmployee // Інженер
    {
        public int YearsOfExperience { get; set; }

        public int CountHolidayDays { get; set; }
        public Engineer(int yearsOfExperience, int countHolidayDays)
        {
            this.YearsOfExperience = yearsOfExperience;
            this.CountHolidayDays = countHolidayDays;
        }

        public virtual int CalculateSalary() => 45000 + (YearsOfExperience * 1800); 

        public int GetCountHolidayDays() => CountHolidayDays;
    }
}
