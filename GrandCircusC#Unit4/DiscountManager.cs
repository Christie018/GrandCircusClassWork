using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusC_Unit4
{
    internal class DiscountManager
    {
        public double ReduceByHalff(double amount)
        {
            return amount / 2;
        }

        public double ApplyMonthlyDiscount (double amount, int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                case 2:
                case 3:
                    return amount * .9;
                case 4:
                case 5:
                case 6:
                    return amount * .8;
                case 7:
                case 8:
                case 9:
                    return amount * .9;
                default:
                    return amount * .6;
            }
        }
    }
}
