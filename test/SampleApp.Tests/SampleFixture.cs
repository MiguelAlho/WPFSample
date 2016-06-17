using NUnit.Framework;
using Ploeh.AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace SampleApp.Tests
{

    [TestFixture]
    public class SampleFixture
    {
        Fixture fixture;
        int num1;
        int num2;

        [SetUp]
        public void ShouldDoSomethingCoolAndWhatNot()
        {
            fixture = new Fixture();
            num1 = fixture.Create<int>();
            num2 = fixture.Create<int>();
        }

        [Test]
        public void DoSomethingActuallySumsStuffUp()
        {
            var result = num1 + num2;
            result.Should().Be(num1 + num2);
        }
    }
}
