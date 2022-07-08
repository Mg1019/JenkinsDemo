using JenkinsDemo;
using NUnit.Framework;

namespace JenkinsDemoTests
{
    public class When_subtracting
    {
        private SimpleSum _simpleSum;
        private int _result;

        [SetUp]
        public void Setup()
        {
            _simpleSum = new SimpleSum();
            _result = _simpleSum.Add(2, 2);
        }

        [Test]
        public void Should_return_correct_value()
        {
            Assert.AreEqual(0, _result);
        }

    }
}