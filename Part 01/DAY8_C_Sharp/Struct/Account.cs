using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_C_Sharp.Struct
{
    internal struct Account
    {
        private int accountid;
        private string accountholder;
        private double balance;

        public Account(int accountid, string accountholder, double balance)
        {
            this.accountid = accountid;
            this.accountholder = accountholder;
            this.balance = balance;
        }

        public int AccountId
        {
            get { return accountid; }
            set { accountid = value; } 
        }

        public string AccountHolder
        {
            get { return accountholder; }
            set { accountholder = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
