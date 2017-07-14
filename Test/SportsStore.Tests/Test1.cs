using System;
using NUnit.Framework;

namespace SportsStore.Tests
{
    [TestFixture]
    public class Test1
    {
        [Test]
        public void t1()
        {
            Assert.That(true,Is.False);
        }
    }
}
