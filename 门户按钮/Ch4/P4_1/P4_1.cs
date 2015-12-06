using System;

namespace P4_1
{
    class Program
    {
        static void Main()
        {
            Student.WriteSchoolInfo();
            Student s1 = new Student();
            s1.name = "王小红";
            Student s2 = new Student();
            s2.name = "周军";
            s2.Department = "数学系";
            Student.School = "华中科技大学";
            Student.WriteSchoolInfo();
            s1.WritePersonalInfo();
            s2.WritePersonalInfo();
            Console.ReadLine();
        }
    }

    public class Student
    {
        public static string School = "华中理工大学";
        public string name, Department = "计算机系";
        public int age;

        public void WritePersonalInfo()
        {
            Console.WriteLine("{0} {1} {2} ", School, Department, name);
        }

        public static void WriteSchoolInfo()
        {
            Console.WriteLine(School);
        }
    }
}
