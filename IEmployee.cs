﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal interface IEmployee // Співробітник
    {
        int YearsOfExperience { get; set; }
        int CalculateSalary();
    }
}
