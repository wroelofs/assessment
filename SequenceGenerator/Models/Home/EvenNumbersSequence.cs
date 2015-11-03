using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WouterRoelofs.Assessments.SequenceGenerator.Models.Home
{
    public class EvenNumbersSequence : ISequence
    {
        public string Description
        {
            get
            {
                return "All even numbers up to and including the number entered.";
            }
        }

        public IList<string> Sequence { get; private set; }

        public EvenNumbersSequence(int number)
        {
            var numbers = Enumerable.Range(0, number + 1).Where(i => i % 2 == 0);
            Sequence = numbers.Select(i => i.ToString()).ToList();
        }
    }
}