using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class IncomeOfficeEventArgs:EventArgs
    {
        public Time IncomeTime { get; set; }

        public IncomeOfficeEventArgs(Time incomeTime)
        {
            IncomeTime = incomeTime;
        }
    }
}
