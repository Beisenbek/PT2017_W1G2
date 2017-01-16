using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    public class Student
    {
        public string name;
        public string surname;
        public int age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "111";
        }
    }
}
