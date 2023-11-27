using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\DOT NET\Projects\28-11-2023\Rainbow School.txt";
                string[] files = File.ReadAllLines(path);
                Console.WriteLine("The Students Data are \n");
                int index = 1;
                foreach (string line in files)
                {
                    Console.WriteLine($" student {index++} : " + line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.Write("All the Students data in the files are displayed: ");
            }
            Console.ReadKey();
        }


    }

}