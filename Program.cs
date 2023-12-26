using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentData
{
    internal class Program
    {
        private static void FileFun()
        {
            string path = @"C:\Users\priscilla glory\Desktop\PP2\studentData\studentData\studentDetails.txt";

            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string tillEnd = sr.ReadToEnd();
                    Console.WriteLine("File exists, reading in:\n" + tillEnd);
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Student Data\nRoll Number\tName");
                    Console.WriteLine("File did not exist, created with default content.");
                }
            }
        }

        private static void Main(string[] args)
        {
            FileFun();
        }
    }
}
