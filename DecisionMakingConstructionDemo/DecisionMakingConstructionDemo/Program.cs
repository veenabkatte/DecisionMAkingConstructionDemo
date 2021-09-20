using System;

namespace DecisionMakingConstructionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Annual Income:");
            double annualIncome = Convert.ToDouble(Console.ReadLine());
            if (annualIncome >= 280000)
            {
                Console.WriteLine("You are liable to pay I.T.");
            }

            Console.ReadLine();
        }
    }
}
