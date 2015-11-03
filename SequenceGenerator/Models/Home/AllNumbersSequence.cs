using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WouterRoelofs.Assessments.SequenceGenerator.Models.Home
{
    public class AllNumbersSequence : ISequence
    {
        public string Description
        {
            get
            {
                return "All numbers up to and including the number entered.";
            }
        }

        public IList<string> Sequence { get; private set; }

        public AllNumbersSequence(int number)
        {
            var numbers = Enumerable.Range(0, number + 1);
            Sequence = numbers.Select(i => i.ToString()).ToList();
        }
    }
}