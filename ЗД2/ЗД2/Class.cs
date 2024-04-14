using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗД2
{
    public class Class : IMyInterface
    {
        public double PI()
        {
            return Math.PI;
        }

        public int Int()
        {
            
            return 7;
        }

        public double Kvadrt(double x)
        {
            return x * x;
        }

        public double Coren(double x)
        {
            
            return Math.Sqrt(x);
        }
    }
}
