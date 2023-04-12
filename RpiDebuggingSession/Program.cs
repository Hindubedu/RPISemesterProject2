using global::RaspberryPiNetCore.ADC;
using global::RaspberryPiNetCore.JoySticks;
using global::RaspberryPiNetCore.LCD;
using global::RaspberryPiNetCore.TWIST;
using RaspberryPiNetCore.WiringPi;
using RpiDebuggingSession;
using RpiEKG;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Raspberry_Pi_Dot_Net_Core_Console_Application3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IADController ADC = new ADCController();
            //while loop wrapper

            var EKGList = ADC.Measure(); //starts 1 min measurement

            bool STElevation = Calculator.FindSTElevation(EKGList); // returns st elevation indicator

            int batteryPercentage = Calculator.BatteryStatus(ADC.MeasureBatteryVoltage()); //calculate and return batterystatus might need to be passed ADC 

            //DisplayController.ShowOnDisplay(EKGList,STElevation, batteryPercentage); //Resets and updates display with relevant info

            string filename = FileCreator.CreateDataFile(EKGList); //Creates a CSV file with EKGList

            UploadController.Upload(filename); //Uploads to cloud some issues might occur here

            //condider indicator for program running.
        }
        public static List<double> TestList()
        {
            List<double> testDoubles = new List<double>();
            for (int i = 1; i < 101; i++)
            {
                testDoubles.Add((double)i);
            }
            return testDoubles;
        }
    }
    

}
