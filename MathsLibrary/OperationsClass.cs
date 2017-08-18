using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public class OperationsClass
    {
        public int AddInt(int num1, int num2)
        {
            int sum = 0;
            sum = num1 + num2;
            return sum;
        }

        public string DivInt(int num1, int num2)
        {
            if(num2 == 0)
            {
                return "NA";
            }

            int result = num1 / num2;
            return result.ToString();
        }
    }
}
