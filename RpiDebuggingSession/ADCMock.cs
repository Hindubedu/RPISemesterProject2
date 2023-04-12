using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiEKG
{
    public class ADCMock : IADController
    {
        public List<double> Measure()
        {
            List<double> mockList = new List<double>();
            var lines = File.ReadAllLines("TestData/NormaltEKG.csv");
            foreach (var line in lines)
            {
                var splitlines = line.Split(',');
                mockList.Add(int.Parse(splitlines[1]));
            }
            return mockList;
        }

        public double MeasureBatteryVoltage()
        {
            return 1;
        }
    }
}
