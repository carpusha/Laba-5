using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Executive : IEmployee // Управлінці
    {
        public int YearsOfExperience { get; set; }
        public Executive(int yearsOfExperience)
        {
            this.YearsOfExperience = yearsOfExperience;
        }

        public int CalculateSalary() => 50000 + (YearsOfExperience * 2000);

    }
}
