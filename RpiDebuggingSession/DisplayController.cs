using RaspberryPiNetCore.LCD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiEKG
{
    public static class DisplayController
    {
        private static SerLCD LCD = new SerLCD();

        public static void ShowOnDisplay(List<double> ekgMeasurements, bool STElevationIndicator, int batteryStatus)
        {
            //Remember to display DateTime
            //LCD.lcdDisplay();
            //LCD.lcdPrint(value.ToString());

            //var date = DateTime.Now;

            //LCD.lcdClear();
            //LCD.lcdHome();
            //LCD.lcdPrint(date.ToString());
            //LCD.lcdGotoXY(0, 1);
            //LCD.lcdPrint(value.ToString());
            //LCD.lcdGotoXY(0, 2);

            //var converted = prc.ConvertTo100(value);

            //LCD.lcdPrint(converted.ToString() + "%");

        }
    }
}
