using System;
using ActionsTest;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var tb = new TupleBuilder();

            var (first, second) = tb.Build(1, "2");

            Assert.Equal(1, first);
            Assert.Equal("2", second);
        }
    }
}
