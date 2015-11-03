using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WouterRoelofs.Assessments.SequenceGenerator.Models.Home
{
    public class FibonacciNumbersSequence : ISequence
    {
        public string Description
        {
            get
            {
                return "All fibonacci numbers up to and including the number entered.";
            }
        }

        public IList<string> Sequence { get; private set; }

        public FibonacciNumbersSequence(int number)
        {
            Sequence = new List<string>();
            for (int i = 0; i <= number; i++) // Use number as maximum index of fibonacci number to calculate. It will always break before that.
            {
                int fibonacci = Fibonacci(i);
                if (fibonacci > number)
                {
                    break;
                }
                else
                {
                    Sequence.Add(fibonacci.ToString());
                }
            }
        }

        private int Fibonacci(int input)
        {
            if (input == 0) return 0;
            if (input == 1) return 1;
            return Fibonacci(input - 2) + Fibonacci(input - 1);
        }
    }
}