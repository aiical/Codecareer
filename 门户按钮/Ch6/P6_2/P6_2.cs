using System;

namespace P6_2
{
    class Program
    {
        static void Main()
        {
            Student[] students = new Student[5];
            students[0] = new Student("王小红", 20, 1);
            students[1] = new Student("周军", 23, 2);
            students[2] = new Student("方小白", 21, 2);
            students[3] = new Student("高强", 25, 3);
            students[4] = new Student("王浩", 22, 3);
            Student.CompareFunction compare;
            Console.WriteLine("请选择排序方式: A姓名 B年龄 C年级");
            char ch = Console.ReadKey().KeyChar;
            if (ch == 'B' || ch == 'b')
                compare = CompareAge;
            else if (ch == 'C' || ch == 'c')
                compare = CompareGrade;
            else
                compare = CompareName;
            Student.SortAndPrint(students, compare);
            Console.ReadLine();
        }

        static int CompareName(Student s1, Student s2)
        {
            return s1.Name.CompareTo(s2.Name);
        }

        static int CompareAge(Student s1, Student s2)
        {
            return s1.Age - s2.Age;
        }

        static int CompareGrade(Student s1, Student s2)
        {
            return s1.Grade - s2.Grade;
        }
    }

    public class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private int age;
        public int Age
        {
            get { return age; }
        }

        public int Grade { get; set; }

        public Student(string name, int age, int grade)
        {
            this.name = name;
            this.age = age;
            this.Grade = grade;
        }

        public static void SortAndPrint(Student[] students, CompareFunction compare)
        {
            for (int i = students.Length - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                    if (compare(students[j], students[j + 1]) > 0)
                    {
                        Student s = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = s;
                    }
            foreach (Student s in students)
                Console.WriteLine(s);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}岁 {2}年级", name, age, Grade);
        }

        public delegate int CompareFunction(Student s1, Student s2);
    }
}
