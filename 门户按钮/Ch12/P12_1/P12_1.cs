using System;
using System.Text;

namespace P12_1
{
    class Program
    {
        static void Main()
        {
            Student[] students = { "王小红", "周军", "方小白", "吴杨" };
            students[1].Birthday = new DateTime(1992, 12, 10);
            students[1].Gender = true;
            students[2].Grade = 2;
            students[2].Class = 3;
            students[3].Gender = false;
            students[3].Grade = 1;
            foreach (Student s in students)
                Console.WriteLine(s.GetInformation());
            Console.ReadLine();
        }
    }

    public class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        public DateTime? Birthday;
        public bool? Gender;
        public int? Grade;
        public int? Class;

        public Student(string name)
        {
            this.name = name;
        }

        public string GetInformation()
        {
            StringBuilder sb1 = new StringBuilder("姓名:");
            sb1.Append(name);
            if (Birthday.HasValue)
            {
                sb1.Append(" 年龄");
                sb1.Append(DateTime.Now.Year - Birthday.Value.Year);
            }
            if (Gender.HasValue)
                sb1.Append(Gender.Value ? " 男 " : " 女 ");
            if (Grade.HasValue)
            {
                sb1.Append(Grade.Value);
                sb1.Append("年级");
            }
            if (Class.HasValue)
            {
                sb1.Append(Class.Value);
                sb1.Append("班");
            }
            return sb1.ToString();
        }

        public override string ToString()
        {
            return name.ToString();
        }

        public static implicit operator Student(string name)
        {
            return new Student(name);
        }
    }
}
