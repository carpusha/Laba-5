using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Manager : IEmployee // Менеджер
    {
        public int YearsOfExperience { get; set; }

        public int NumberOfSubordinates { get; set; }

        public Manager(int yearsOfExperience, int numberOfSubordinates)
        {
            this.YearsOfExperience = yearsOfExperience;
            this.NumberOfSubordinates = numberOfSubordinates;
        }

        public int CalculateSalary() => 40000 + (YearsOfExperience * 2500); 

        public int GetNumberOfSubordinates() => NumberOfSubordinates;
    }
}
