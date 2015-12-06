using System;

namespace P10_3
{
    public enum Currency
    {
        人民币, 美元, 英镑, 欧元
    }

    public class POS
    {
        private string region;
        public string Region
        {
            get { return region; }
        }

        public POS(string region)
        {
            this.region = region;
        }
    }

    public interface IPayable
    {
        void Pay(decimal money, POS pos);
    }

    public interface IGlobalPayable : IPayable
    {
        void Pay(decimal money, Currency currency, POS pos);
    }

    public class BankCard
    {
        protected string id, region;

        protected decimal balance = 0;
        public decimal Balance
        {
            get { return balance; }
        }

        public BankCard(string id, string region)
        {
            this.id = id;
            this.region = region;
        }
    }

    public class GeneralCard : BankCard, IPayable
    {
        public GeneralCard(string id, string region, decimal money)
            : base(id, region)
        {
            balance = money;
        }

        public void Pay(decimal money, POS pos)
        {
            decimal cost = 0;
            if (this.region != pos.Region)
                cost = money * 0.01M;
            if (balance >= money + cost)
                balance -= (money + cost);
            else
                throw new InvalidOperationException("余额不足");
        }

        public override string ToString()
        {
            return string.Format("银联卡{0}", id);
        }
    }

    public class CreditCard : BankCard, IPayable
    {
        private decimal credit;

        public CreditCard(string id, string region, decimal credit)
            : base(id, region)
        {
            this.credit = credit;
        }

        public void Pay(decimal money, POS pos)
        {
            if (money <= credit + balance)
                balance -= money;
            else
                throw new InvalidOperationException("超出额度");
        }

        public override string ToString()
        {
            return string.Format("信用卡{0}", id);
        }
    }

    public class VisaCard : CreditCard, IPayable, IGlobalPayable
    {
        public VisaCard(string id, string region, decimal credit)
            : base(id, region, credit)
        { }

        public void Pay(decimal money, Currency currency, POS pos)
        {
            decimal rate = 1;
            if (currency == Currency.美元)
                rate = 7;
            else if (currency == Currency.英镑)
                rate = 13;
            else if (currency == Currency.欧元)
                rate = 10;
            base.Pay(rate * money, pos);
        }

        public override string ToString()
        {
            return string.Format("Visa卡{0}", id);
        }
    }
}
