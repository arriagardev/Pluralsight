using System;

namespace CSModule4
{
    public class Calculator
    {
        public delegate decimal CalculateHandler(decimal x, decimal y);

        //public void Calculate(CalculateHandler operation, decimal x, decimal y)
        //{
        //    decimal result = operation(x, y);
        //    Console.WriteLine("Result: {0}", result);
        //}

        public void Calculate(Action<decimal, decimal> operation, decimal x, decimal y)
        {
            operation(x, y);
            Console.WriteLine("Calculation is complete");
        }

        public void Calculate(Func<decimal, decimal, decimal> operation, decimal x, decimal y)
        {
            decimal result = operation(x, y);
            Console.WriteLine("Result: {0}", result);
        }
    }
}
