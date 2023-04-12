using RaspberryPiNetCore.ADC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RpiEKG
{
    public class ADCController: IADController
    {
        private static ADC1015 ADC = new ADC1015();

        public List<double> Measure()
        {
            List<double> EKGMeasurements = new List<double>();
            Stopwatch sw = new Stopwatch();
            long secondsElapsed = 0;

            sw.Start();
            while (secondsElapsed<60000) //60.000 ms = 1 min 
            {
                //ADC.SamplingsRate = 2;
                double sample = (ADC.SINGLE_Measurement[0].Take() / 2048.0) * 6.144; //To get right value in mV
                EKGMeasurements.Add(sample);
                Thread.Sleep(10);
                secondsElapsed = sw.ElapsedMilliseconds;
            }
            sw.Reset();
            return EKGMeasurements;
        }

        public double MeasureBatteryVoltage()
        {
            double voltage = (ADC.SINGLE_Measurement[0].Take() / 2048.0) * 6.144;
            return voltage;
        }
    }
}
