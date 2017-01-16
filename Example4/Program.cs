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

        static void Sort() 
        {
            for (int i = 0; i < list.Count - 1; ++i)
            {
                for (int j = i + 1; j < list.Count; ++j)
                {
                    if (list[i].age > list[j].age)
                    {
                        Student t = list[i];
                        list[i] = list[j];
                        list[j] = t;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            Student s2 = new Student("A", "B", 21);
            Student s3 = new Student();
            Student s4 = new Student("John3", "Doe", 32);

            list.Add(s);
            list.Add(s2);
            list.Add(s3);
            list.Add(s4);
            
            Sort();
             
            foreach (Student x in list) 
            {
                Console.WriteLine(x.ToString());
            }

        }
    }
}
