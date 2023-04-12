using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiEKG
{
    public static class FileCreator
    {
        public static string CreateDataFile(List<double> ekgMeasurements)
        {
            List<string> stringEkgList = ekgMeasurements.Select(x => x.ToString()).ToList();

            string time = DateTime.Now.Hour.ToString() + "." + DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            string filename = $"File{time.ToString().Replace("-", "")}.csv";
            var myFile = File.Create(filename);
            myFile.Close();

            File.WriteAllLines(filename, stringEkgList);

            return filename;
        }
    }
}
