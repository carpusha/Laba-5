using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Leader : IEmployee // Керівництво
    {
        public int YearsOfExperience { get; set; }

        public Leader(int yearsOfExperience)
        {
            this.YearsOfExperience = yearsOfExperience;
        }

        public int CalculateSalary() => 100000 + (YearsOfExperience * 1500);

    }
}
