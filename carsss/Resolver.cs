using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carsss
{
    public class Resolver
    {
        public int TaxesCount(int price)
        {
            int NDF = (int)(price * 0.13);
            int t = price - NDF;
            return t;
        }
    }
}
