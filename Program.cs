using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter a number.");
            using (StreamWriter file = new StreamWriter(@"C:\Users\Elite\Desktop\log.txt", true))
            {
                file.WriteLine(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine(File.ReadAllText(@"C:\Users\Elite\Desktop\log.txt"));
            Console.ReadLine();
        }
    }
}
