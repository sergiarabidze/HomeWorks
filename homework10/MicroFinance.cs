using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10FinanceOperations;

internal class MicroFinance : FinanceOperations
{
    public bool CheckUserHistory()
    {
        return true;
    }

    public double CalculateLoanPercent(int month, double amountPerMonth)
    {
        double total = month * amountPerMonth;
        double percent = total * 0.10;
        double serviceFee = month * 4;
        return total + percent + serviceFee;
    }
}
