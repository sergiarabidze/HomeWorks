using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    class Company
    {
        public bool IsLocal { get; set; }

        public Company(bool isLocal)
        {
            IsLocal = isLocal;
        }

        public double CalculateTax(double totalSalary)
        {
            return IsLocal ? totalSalary * 0.18 : totalSalary * 0.05;
        }
    }
}
