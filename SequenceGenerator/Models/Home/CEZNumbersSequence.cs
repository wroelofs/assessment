using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WouterRoelofs.Assessments.SequenceGenerator.Models.Home
{
    public class CEZNumbersSequence : ISequence
    {
        public string Description
        {
            get
            {
                return "All numbers up to and including the number entered, but C when multiple of 3, E when multiple of 5 and Z when multiple of both 3 and 5.";
            }
        }

        public IList<string> Sequence { get; private set; }

        public CEZNumbersSequence(int number)
        {
            Sequence = new List<string>();
            for (int i = 0; i <= number; i++)
            {
                string stringToAdd = i.ToString();
                if (i % 3 == 0)
                {
                    stringToAdd = "C";
                }
                if (i % 5 == 0)
                {
                    stringToAdd = "E";
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    stringToAdd = "Z";
                }
                Sequence.Add(stringToAdd);
            }
        }
    }
}