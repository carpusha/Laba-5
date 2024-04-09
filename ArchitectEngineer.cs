using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class ArchitectEngineer : Engineer // Архітектор-інженер
    {
        public ArchitectEngineer(int yearsOfExperience, int countHolidayDays) : base(yearsOfExperience, countHolidayDays)
        {
        }

        public override int CalculateSalary()
        {
            return base.CalculateSalary() + 3000;
        }
    }
}
