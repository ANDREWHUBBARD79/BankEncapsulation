using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class Bank_Account
    {
     public Bank_Account()
        {

        }

        private double balance = 0;

        //Define a method named method that will accept a double
        //And store that value into the balance feild

        //Encapsulation
        public void Deposit(double amount)
        {
            balance = amount;
        }

        //Define a method named GetBalance that 
        //Will return the amount stored in the balance feild
        public double GetBalance()
        {
            return balance;
        }


    }
}
