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

            var t = tb.Build(1, "2");

            Assert.Equal(1, t.Item1);
            Assert.Equal("2", t.Item2);
        }

        [Fact]
        public void Test2()
        {
            var tb = new TupleBuilder();

            var (first, second, third) = tb.Build(1, "2", true);

            Assert.Equal(1, first);
            Assert.Equal("2", second);
            Assert.True(third);
        }
    }
}
