using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExercise
{
   public class BankAccount
    {

        //In your BankAccount class, create the following:
        //A private field of type double named balance with a value of 0
        //Define a method named Deposit that will accept a double and store that value in the balance field
        //Define a method named GetBalance that will return the amount stored in the balance field



        //Field = class local variables
        private double balance = 0;


        //Example of a Property
        //public double Balance { get; set; }



        //Method
        public void Deposit (double amountToDeposit)
        {
            balance += amountToDeposit;
        }


        //Method
        public double GetBalance()
        {
            return balance;
        }




    }
}
