using System;

namespace EncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAcct = new BankAccount();

            Console.WriteLine("Please deposit your money now.");
            double amount = double.Parse(Console.ReadLine());
            
            bankAcct.Deposit(amount);


            Console.WriteLine($"Currently, you have {bankAcct.GetBalance(), 0:c} in your account.");
           







        }
    }
}
