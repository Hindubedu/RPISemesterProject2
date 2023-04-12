using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiEKG
{
    public interface IADController
    {
        List<double> Measure();
        double MeasureBatteryVoltage();

    }
}
