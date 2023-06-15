using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_for_exam_1
{
    public class Function
    {

        public double a,b;
        public string functionIntegral;

        public Function(double a, double b)
        {
            this.a = a; this.b = b;
        }

        public double func(double x)
        {
            return ( 1 / Math.Sqrt( Math.Pow( (1 + x * x), 3) ) );
        }

    }
}
