using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiEKG
{
    public static class Calculator
    {

        public static bool FindSTElevation(List<double> list)
        {
            return true;
        }

        public static int BatteryStatus(double mV)
        {
            return 0;
        }



        public static int ConvertToPercentage(short value)
        {
                var result = Convert.ToDouble(value) / 4096.0 * 100.0;

                return (int)result;
        }
    }
}
