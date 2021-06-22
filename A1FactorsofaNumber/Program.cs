using System;

namespace A1FactorsofaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; 
            

            Console.Write("\nEnter a number you want to find the factors for:  "); // prompt user to enter a number
            num = Convert.ToInt32(Console.ReadLine()); // converts the string (variable) into an integer

            for (int i = 1; i <= num; i++) // this loops checks from 1 until the number entered

                
                {
                if(num % i == 0)  // this compute the given number modular to the value of (i) which is 
                                  // the factorial and it loops until it reaches the number entered and find if it
                                  // has no remainder to find the factorial numbers
                    {
                    Console.Write("\nThe factors of: " + Convert.ToString(num) + "\t" + Convert.ToString(i));// print the result the
                    //factorial number and converts the integer into a string.
                    }
                }
        }
    }
}
