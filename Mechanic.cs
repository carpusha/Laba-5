using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Mechanic : IEmployee // Механік
    {
        public int YearsOfExperience { get; set; }

        public Mechanic(int yearsOfExperience)
        {
            this.YearsOfExperience = yearsOfExperience;
        }

        public int CalculateSalary() => 65000 + (YearsOfExperience * 1600);
    }
}
