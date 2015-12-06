using System;

namespace P3_6
{
    class Program
    {
        static void Main()
        {
            Graduate g1 = new Graduate();
            g1.name = "陈亮";
            Student s1 = g1; // 隐式转换
            Student s2 = new Student();
            s2.name = "宋燕燕";
            Graduate g2 = (Graduate)s1; // 显式转换
            Console.WriteLine(g2.name);
            //Graduate g3 = (Graduate)s2; // 错误：转换失败！

            Graduate[] gs1 = new Graduate[] { g1, g2 };
            Student[] ss1 = gs1;
            Graduate[] gs2 = (Graduate[])ss1;
            Console.ReadLine();
        }
    }

    class Student
    {
        public string name;
        public int age;
        public int grade;
        public void Register() { }
    }

    class Graduate : Student
    {
        public string supervisor = null;
    }
}
