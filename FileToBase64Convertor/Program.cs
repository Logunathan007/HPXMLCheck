using Microsoft.VisualBasic.Logging;
using System;
using System.Windows.Forms;

namespace ClipboardExample
{
    class Program
    {
        [STAThread] // This ensures the main thread runs in Single Threaded Apartment (STA) mode
        static void Main(string[] args)
        {

            string filePath = "D:\\Logu\\XML\\HPXML\\xml\\custom.xml";

            byte[] fileBytes = File.ReadAllBytes(filePath);

            string base64String = Convert.ToBase64String(fileBytes);

            Clipboard.SetText(base64String);

            Console.WriteLine("Text copied to clipboard!");
        }
    }
}
