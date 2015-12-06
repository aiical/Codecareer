using System;

namespace P4_5
{
    class Program
    {
        static void Main()
        {
            Student s1 = new Student("王小红");
            Student s2 = new Student("周军");
            s1 = new Student("Jerry");
            Console.ReadLine();
        }
    }

    public class Student
    {
        public static int objects = 0, classes = 0;
        public string name;

        public Student(string n) //实例构造函数
        {
            name = n;
            Console.WriteLine("对象计数: {0}", ++objects);
        }

        static Student() //静态构造函数
        {
            Console.WriteLine("类计数: {0}", ++classes);
        }
    }
}
