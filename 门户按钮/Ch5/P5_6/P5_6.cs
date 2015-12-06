using System;

namespace P5_6
{
    class Program
    {
        static void Main()
        {
            Student s1 = new Student(101, "王小红");
            Console.WriteLine(s1);
            Student s2 = new Graduate(101, "王晓红", "张大伟");
            Console.WriteLine(s2);
            Console.WriteLine(s1.Equals(s2));
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

        private int id;
        public int ID
        {
            get { return id; }
        }

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format("学号{0},姓名{1}", id, name);
        }

        public sealed override bool Equals(object obj)
        {
            if (obj is Student && ((Student)obj).id == this.id)
                return true;
            else
                return false;
        }
    }

    public class Graduate : Student
    {
        private string supervisor;
        public string Supervisor
        {
            get { return supervisor; }
            set { supervisor = value; }
        }

        public Graduate(int id, string name)
            : base(id, name)
        { }

        public Graduate(int id, string name, string supervisor)
            : base(id, name)
        {
            this.supervisor = supervisor;
        }

        public override string ToString()
        {
            return base.ToString() + ",导师:" + supervisor;
        }
    }
}
