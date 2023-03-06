using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    class Student
    {
        public string name;
        public int group;
        private int age;

        public Student(string name, int group, int age)
        {
            this.name = name;
            this.group = group;
            this.age = age;
        }
        public void PrintDisplay() => Console.WriteLine($"{name}, группа: {group} возраст: {age}");
    }
}
