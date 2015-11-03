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
    public class EvenNumbersSequenceTests
    {
        [TestMethod()]
        public void EvenNumbersSequenceTest()
        {
            var subject = new EvenNumbersSequence(5);
            Assert.IsNotNull(subject);
            Assert.IsNotNull(subject.Description);
            Assert.IsNotNull(subject.Sequence);
            Assert.AreEqual(3, subject.Sequence.Count);
            var expected = new List<string>() { "0", "2", "4" };
            AssertHelper.ListsAreEqual(expected, subject.Sequence);
        }
    }
}