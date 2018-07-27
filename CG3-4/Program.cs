using System;

namespace CG3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a simple calculator that asks the user to input two different numbers and whether they want to add, 
            //subtract, multiple or divide them.

            //Program key words for the first number, second number, answer and operation.  Using double allows for fractions.
            double firstnumber;
            double secondnumber;
            double answer;
            string operation;
          
            //Ask the user to input the first number.
            Console.WriteLine("Welcome to a simple calculator. Please enter the first number");
            //Print the user input to the console.
            firstnumber = Convert.ToDouble(Console.ReadLine());

            //Ask the user to input the second number.
            Console.WriteLine("Enter the second number");
            //Print the user input to the console.
            secondnumber = Convert.ToDouble(Console.ReadLine());

            //Ask the user to input the operator (x, +, -, or /).  Assumming the user knows symbols for multiplication, division, 
            //subtraction, and addition).
            Console.WriteLine("Enter the operator by typing x, /, +, or -");
            //Print the user input to the console.
            operation = Console.ReadLine();

            //Below calculates and prints the answer to the console depending on which operatior chosen as an equation.
            if (operation == "x")          
                
            {
                answer = firstnumber * secondnumber;
                Console.WriteLine(firstnumber + " x " + secondnumber + " = " + answer);
                Console.ReadLine();

            }

            if (operation == "+")

            {
                 answer = firstnumber + secondnumber;
                 Console.WriteLine(firstnumber + " + " + secondnumber + " = " + answer);
                 Console.ReadLine();

            }

            if (operation == "-")

            {
                answer = firstnumber - secondnumber;
                Console.WriteLine(firstnumber + " - " + secondnumber + " = " + answer);
                Console.ReadLine();
                
            }

            if (operation == "/")

            {
                answer = firstnumber / secondnumber;
                Console.WriteLine(firstnumber  + " / " + secondnumber + " = " + answer);
                Console.ReadLine();
            }
        

            
        












        }
    }
}
