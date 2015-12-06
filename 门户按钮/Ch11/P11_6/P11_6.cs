using System;

namespace P11_6
{
    class Program
    {
        static void Main()
        {
            Contact c1 = new Contact("张大强");
            c1[0] = "010-88664321";
            c1[1] = "13011110234";
            ((IItems<Email>)c1)[0] = new Email("zhangdaqiang", "hstu.edu.cn");
            ((IItems<Email>)c1)[1] = new Email("daqiangzhang", "soft.cn");
            ((IItems<Address>)c1)[0] = new Address("湖北", "武汉", "科技路", 19);
        }
    }

    public interface IItems<T>
    {
        T this[int index] { get; set; }
    }

    public class Contact : IItems<Email>, IItems<string>, IItems<Address>
    {
        private string _name;
        private string[] _phones;
        private Email[] _emails;
        private Address[] _addresses;

        public string Name
        {
            get { return _name; }
        }

        public string this[int index]
        {
            get { return _phones[index]; }
            set { _phones[index] = value; }
        }

        Email IItems<Email>.this[int index]
        {
            get { return _emails[index]; }
            set { _emails[index] = value; }
        }

        Address IItems<Address>.this[int index]
        {
            get { return _addresses[index]; }
            set { _addresses[index] = value; }
        }

        public Contact(string name)
        {
            _name = name;
            _phones = new string[5];
            _emails = new Email[3];
            _addresses = new Address[3];
        }
    }

    public struct Email
    {
        public string Username, Domain;

        public Email(string username, string domain)
        {
            Username = username;
            Domain = domain;
        }

        public override string ToString()
        {
            return string.Format("{0}@{1}", Username, Domain);
        }
    }

    public struct Address
    {
        public string Province, City, Street;
        public int No;

        public Address(string province, string city, string street, int no)
        {
            Province = province;
            City = city;
            Street = street;
            No = no;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}{2}{3}号", Province, City, Street, No);
        }
    }
}
