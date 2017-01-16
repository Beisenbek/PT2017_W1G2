using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    public class Student
    {
        public string name;
        public string surname;
        public int age;
        public Student()
        {
            name = "John";
            surname = "Smith";
            age = 20;
        }
        /// <summary>
        /// Конструктор с именем, фамилией и возрастом
        /// </summary>
        /// <param name="a">name</param>
        /// <param name="b">surname</param>
        /// <param name="c">age</param>
        public Student(string a, string b, int c)
        {
            this.name = a;
            this.surname = b;
            this.age = c;
        }

        public void Create()
        {
            name = "John2";
            surname = "Smith";
            age = 20;
        }

        public override string ToString()
        {
            return age + " " + surname + " " + name;
        }
    }

    class Program
    {
        static List<Student> list = new List<Student>();
        static void EnterData()
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Student s = new Student(name, surname, age);
            list.Add(s);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter option:[1] - enter new. [2] - show data. [other] - terminate");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    EnterData();
                }
                else if(option == "2")
                {
                    foreach (Student s in list)
                    {
                        Console.WriteLine(s.ToString());
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
