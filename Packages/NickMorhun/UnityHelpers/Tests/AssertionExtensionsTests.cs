using System;
using NUnit.Framework;

namespace UnityHelpers.Tests
{
    public class AssertionExtensionsTests
    {
        [Test]
        public void NotNull_WhenArgumentIsNull_ThrowsArgumentNullException()
        {
            object argument = null;
            Assert.Throws<ArgumentNullException>(() => argument.NotNull(nameof(argument)));
        }

        [Test]
        public void NotNull_WhenArgumentIsNotNull_ReturnsArgument()
        {
            var argument = new object();
            Assert.AreSame(argument, argument.NotNull(nameof(argument)));
        }
    }
}
