using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestFile
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please input a message");
            string input = Console.ReadLine();
            WriteToFile(input);

        }

        public static void WriteToFile(string input)
        {

            StreamWriter sw = new StreamWriter("../../TextFile1.txt", true);
            sw.WriteLine(input);

            sw.Close();
        }
    }
}

