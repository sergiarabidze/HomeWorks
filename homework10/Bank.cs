using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10FinanceOperations;

internal class Bank : FinanceOperations
{

    Random random = new Random();
    public double   CalculateLoanPercent(int month, double AmountPerMonth)
    {
        double total = month * AmountPerMonth;
        double percent = total * 0.05;
        return  total + percent;
    }

    public bool CheckUserHistory()
    {
        return random.Next(2) == 0;
    }
}
