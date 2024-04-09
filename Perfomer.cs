using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Perfomer : IEmployee // Виконавці
    {
        public int YearsOfExperience { get; set; }

        public Perfomer(int yearsOfExperience)
        {
            this.YearsOfExperience = yearsOfExperience;
        }

        public int CalculateSalary() => 30000 + (YearsOfExperience * 1500);
    }
}
