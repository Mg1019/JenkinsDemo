using JenkinsDemo;
using NUnit.Framework;

namespace JenkinsDemoTests
{
    public class When_subtracting
    {
        private SimpleSubtract _simpleSubtract;
        private int _result;

        [SetUp]
        public void Setup()
        {
            _simpleSubtract = new SimpleSubtract();
            _result = _simpleSubtract.Subtract(2, 2);
        }

        [Test]
        public void Should_return_correct_value()
        {
            Assert.AreEqual(0, _result);
        }

    }
}