using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WouterRoelofs.Assessments.SequenceGenerator.Tests
{
    internal static class AssertHelper
    {
        /// <summary>
        /// Assert two IList's are equal by comparing their item count and looping over each item to check their equality. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        public static void ListsAreEqual<T>(IList<T> expected, IList<T> actual)
        {
            Assert.IsNotNull(expected);
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected.ElementAt(i), actual.ElementAt(i));
            }
        }
    }
}
