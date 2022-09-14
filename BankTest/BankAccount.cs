namespace BankTest
{
    internal class BankAccount
    {
        private string v;
        private double beginningBalance;

        public BankAccount(string v, double beginningBalance)
        {
            this.v = v;
            this.beginningBalance = beginningBalance;
        }
    }
}