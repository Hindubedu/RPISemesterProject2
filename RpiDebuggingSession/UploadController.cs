using FileShare;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiEKG
{
    public static class UploadController
    {
        public static void Upload(string filepath)
        {
            Uploader uploader = new Uploader("F23_Gruppe_02"); // Create an Uploader instance with a group name   F23_Gruppe_02
            FileStream localFileStream = new FileStream(filepath, FileMode.Open); // Open a filestream to data
            string uploadName = uploader.Save(filepath, localFileStream); // Upload data to a file
            Console.WriteLine(uploadName); // Prints the filename the data is saved in - can change if you try to use same filename
        }
    }
}
