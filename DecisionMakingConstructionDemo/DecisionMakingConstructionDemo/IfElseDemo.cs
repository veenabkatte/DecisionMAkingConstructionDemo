using System;

namespace DecisionMakingConstructionDemo
{
    class IfElseDemo
    {
        static void Main()
        {
            Console.Write("Enter Annual Income:");
            double annualIncome = Convert.ToDouble(Console.ReadLine());
            if (annualIncome >= 280000)
            {
                Console.WriteLine("You are liable to pay I.T.");
            }
            else
            {
                Console.WriteLine("You are not liable to pay I.T.");
            }

            Console.ReadLine();
        }
    }
}
