using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        static void Main(string[] x)
        {
            if(x.Length > 0)
            {
                if (x[0] == "--help")
                {
                    Console.WriteLine("Enter two numbers:");
                }
                else
                {
                    int a = int.Parse(x[0]);
                    int b = int.Parse(x[1]);
                    Console.WriteLine(a + b);
                }
            }
            else
            {
                string line = Console.ReadLine();
                string[] param = line.Split(' ');
                if (param.Length > 1)
                {
                    int a = int.Parse(param[0]);
                    int b = int.Parse(param[1]);
                    Console.WriteLine(a + b);
                }
                else
                {
                    int a = int.Parse(line);
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(a + b);
                }
            }
        }
    }
}
