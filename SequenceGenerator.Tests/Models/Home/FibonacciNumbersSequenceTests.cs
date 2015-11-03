using Microsoft.VisualStudio.TestTools.UnitTesting;
using WouterRoelofs.Assessments.SequenceGenerator.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WouterRoelofs.Assessments.SequenceGenerator.Tests.Models.Home
{
    [TestClass()]
    public class FibonacciNumbersSequenceTests
    {
        [TestMethod()]
        public void FibonacciNumbersSequenceTest()
        {
            var subject = new FibonacciNumbersSequence(5);
            Assert.IsNotNull(subject);
            Assert.IsNotNull(subject.Description);
            Assert.IsNotNull(subject.Sequence);
            Assert.AreEqual(6, subject.Sequence.Count);
            var expected = new List<string>() { "0", "1", "1", "2", "3", "5" };
            AssertHelper.ListsAreEqual(expected, subject.Sequence);
        }
    }
}