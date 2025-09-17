using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10FinanceOperations;

internal interface FinanceOperations
{
    public double CalculateLoanPercent(int month, double AmountPerMonth);
    public bool CheckUserHistory();
}
