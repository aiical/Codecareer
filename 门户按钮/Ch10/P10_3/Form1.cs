using System;
using System.Windows.Forms;

namespace P10_3
{
    public partial class Form1 : Form
    {
        BankCard[] cards;
        POS pos1, pos2;

        public Form1()
        {
            InitializeComponent();
            cards = new BankCard[4];
            cards[0] = new GeneralCard("g001", "Beijing", 1000);
            cards[1] = new GeneralCard("g002", "Shanghai", 1000);
            cards[2] = new CreditCard("c001", "Beijing", 1000);
            cards[3] = new VisaCard("v001", "Shanghai", 1000);
            pos1 = new POS("Beijing");
            pos2 = new POS("Shanghai");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(BankCard card in cards)
                cmbCard.Items.Add(card);
            for (int i = 0; i < 4; i++)
                cmbCurrency.Items.Add((Currency)i);
            cmbCard.SelectedIndex = cmbCurrency.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            POS pos = radioButton1.Checked ? pos1 : pos2;
            BankCard card = (BankCard)cmbCard.SelectedItem;
            Currency cur = (Currency)cmbCurrency.SelectedIndex;
            try
            {
                if (cur == Currency.人民币)
                    ((IPayable)card).Pay(nudMoney.Value, pos);
                else
                    ((IGlobalPayable)card).Pay(nudMoney.Value, cur, pos);
                MessageBox.Show("消费成功，余额" + card.Balance);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("该卡不支持此项消费");
            }
            catch (Exception exp)
            {
                MessageBox.Show("消费失败: " + exp.Message);
            }
        }
    }
}
