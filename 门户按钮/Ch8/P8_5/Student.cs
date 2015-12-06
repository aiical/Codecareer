using System;

namespace P8_5
{
    [Serializable()]
    public class Student
    {
        private int id;
        public int ID //学号
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name //姓名
        {
            get { return name; }
            set { name = value; }
        }

        private bool gender;
        public bool Gender //性别
        {
            get { return gender; }
            set { gender = value; }
        }

        private string department;
        public string Department //院系
        {
            get { return department; }
            set { department = value; }
        }

        private byte grade;
        public byte Grade //年级
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    [Serializable()]
    public class Graduate : Student
    {
        private string supervisor;
        public string Supervisor //导师
        {
            get { return supervisor; }
            set { supervisor = value; }
        }

        public Graduate(int id, string name, string supervisor)
            : base(id, name)
        {
            this.supervisor = supervisor;
        }
    }
}
