using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresAndAlgorithms
{
    internal class UC_4_BankingCashCounter
    {
        class Account
        {
            public const double defaultBalance = 1000;
            private double _amount;
            public double balance;

            public double Balance
            {
                get { return defaultBalance; }
            }

            public double Amount
            {
                get
                {
                    return _amount;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Please enter an amount greater than 0");
                    }
                    else
                    {
                        _amount = value;
                    }
                }
            }

            public double doDeposit()
            {
                balance += _amount;
                return balance;
            }

            public double doWithdrawl()
            {
                balance -= _amount;

                if (balance < 0)
                {
                    throw new ArgumentException("Withdrawing " + _amount.ToString("C") + " would leave you overdrawn!");
                }
                return balance;
            }
        }
    }
}
