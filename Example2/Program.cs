using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
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
