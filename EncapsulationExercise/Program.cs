using System;

namespace EncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {


            //In your BankAccount class, create the following:
            //A private field of type double named balance with a value of 0
            //Define a method named Deposit that will accept a double and store that value in the balance field
            //Define a method named GetBalance that will return the amount stored in the balance field
            //In the Main() method of your application:
            //Create a new instance of the BankAccount class
            //Allow the user of the application to Deposit money
            //Allow the user to retrieve their balance through the console
            //Once finished save your work inside of Visual Studios


            var bankAcct = new BankAccount();

            Console.WriteLine("Please deposit your money now.");
            double amount = double.Parse(Console.ReadLine());
            
            bankAcct.Deposit(amount);


            Console.WriteLine($"Currently, you have {bankAcct.GetBalance(), 0:c} in your account.");
           







        }
    }
}
