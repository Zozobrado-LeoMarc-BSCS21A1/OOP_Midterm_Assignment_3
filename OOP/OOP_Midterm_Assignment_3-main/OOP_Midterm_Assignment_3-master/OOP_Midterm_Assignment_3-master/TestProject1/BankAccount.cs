using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class BankAccount 
    {

        private int accountNumber;
        private int balance;
        private double interest;

        public BankAccount(int accountNumber, int balance, double interest)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.interest = interest;

        }


        public void Deposit(int money)
        {
            this.balance += money;
        }

        public int GetBalance() { return this.balance; }

        public void Withdraw(int amount)
        {
            if (amount <= this.balance)
            {
                this.balance -= amount;
            }
        }

        public void CalculateInterest()
        {
            int interestAmount = (int)(this.balance * this.interest);
            this.balance += interestAmount;
        }

        public BankAccount(int accountNumber, int initialBalance)
        {

            this.accountNumber = accountNumber;
            this.balance = initialBalance;

        }

        public void Withdraw(int amount, bool isOtherBank)
        {
            int penalty = isOtherBank ? 20 : 0;
            this.balance -= (amount + penalty);

        }

    }
}
