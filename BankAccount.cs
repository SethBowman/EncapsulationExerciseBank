using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExercise
{
   public class BankAccount
    {


        

        //Field = class local variables
        private double balance = 0;


       
        //Method
        public void Deposit (double amountToDeposit)
        {
            balance += amountToDeposit;
        }



        public double GetBalance()
        {
            return balance;
        }




    }
}
