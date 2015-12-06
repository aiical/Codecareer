using System;

namespace P10_1
{
    class Program
    {
        static void Main()
        {
            IPayable[] payers = new IPayable[4];
            payers[0] = new BankAccount(3000);
            payers[1] = new BankAccount(5000);
            payers[2] = new CreditCard(5000);
            payers[3] = new DebitCard((BankAccount)payers[1]);
            foreach (IPayable payer in payers)
            {
                Receive(payer, 1500);
                Receive(payer, 2000);
            }
            Console.ReadLine();
        }

        static void Receive(IPayable payer, decimal money)
        {
            if (payer.Pay(money))
                Console.WriteLine("{0}成功付款{1}元", payer, money);
            else
                Console.WriteLine("{0}付款失败", payer);
        }
    }

    public interface IPayable
    {
        bool Pay(decimal money);
    }

    public class BankAccount : IPayable
    {
        protected decimal balance = 0;
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public BankAccount(decimal balance)
        {
            this.balance = balance;
        }

        public virtual bool Pay(decimal money)
        {
            if (balance >= money)
            {
                balance -= money;
                return true;
            }
            else
                return false;
        }
    }

    public class CreditCard : BankAccount
    {
        private decimal credit;
        public decimal Credit
        {
            get { return credit; }
        }

        public CreditCard(decimal credit) : base(0)
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

    public class DebitCard : IPayable
    {
        private BankAccount account;

        public DebitCard(BankAccount account)
        {
            this.account = account;
        }

        public bool Pay(decimal money)
        {
            return account.Pay(money);
        }
    }
}
