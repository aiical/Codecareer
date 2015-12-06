using System;

namespace P10_2
{
    class Program
    {
        static void Main()
        {
            BankAccount a1 = new BankAccount(1000, true);
            IPayable p1 = a1;
            Console.WriteLine("p1付款1100: " + (p1.Pay(1100) ? "成功" : "失败"));
            Console.WriteLine("a1付款1100: " + (a1.Pay(1100) ? "成功" : "失败"));
            a1 = new CreditCard(1000);
            Console.WriteLine("a1付款1100: " + (a1.Pay(1100) ? "成功" : "失败"));
            Console.ReadLine();
        }
    }

    public interface IPayable
    {
        bool Pay(decimal money);
    }

    public class BankAccount : IPayable
    {
        private bool vip = false;
        protected decimal balance = 0;
        
        public BankAccount(decimal balance, bool vip)
        {
            this.balance = balance;
            this.vip = vip;
        }

        bool IPayable.Pay(decimal money)
        {
            if (balance >= money)
            {
                balance -= money;
                return true;
            }
            else
                return false;
        }

        public virtual bool Pay(decimal money)
        {
            IPayable p1 = (IPayable)this;
            if(!vip)
                return p1.Pay(money);
            else
                return p1.Pay(money * 0.9M);
        }
    }

    public class CreditCard : BankAccount
    {
        private decimal credit;

        public CreditCard(decimal credit)
            : base(0, true)
        {
            this.credit = credit;
        }

        public override bool Pay(decimal money)
        {
            if (money <= credit + balance)
            {
                balance -= money;
                return true;
            }
            else
                return false;
        }
    }
}
