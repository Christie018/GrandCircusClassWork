using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusC_Unit4
{
    internal class Validator
    {
        public static bool isValidInteger(string value, int min,int max, out int number)
        {
            number = -1;

            try
            {
                number = int.Parse(value);
            }
            catch (FormatException)
            {
                return false;
            }

            if (number < min || number > int.MaxValue)
            {
                return false;
            }

            return true;
        }
    }
}
