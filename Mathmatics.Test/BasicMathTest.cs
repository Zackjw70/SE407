namespace Mathmatics.Test
{
    public class BasicMathTest : IClassFixture<BasicMathTestFixture>
    {
        private BasicMathTestFixture _fixture;
        public BasicMathTest(BasicMathTestFixture fixture) {
            _fixture = fixture;
        }

        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(10, 5, 15)]
        [InlineData(2, 2, 4)]
        [InlineData(10000, 567, 10567)]
        public void TestAddTwoNumbers(int num1, int num2, int expected)
        {

            int result = _fixture.TestObject.Add(num1, num2);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestSubtractTwoNumbers()
        {
            int result = _fixture.TestObject.Subtract(5, 3);
            Assert.Equal(2, result);
        }
        [Fact]
        public void TestMultiplyTwoNumbers()
        {
            int result = _fixture.TestObject.Multiply(5, 3);
            Assert.Equal(15, result);
        }
        [Fact]
        public void TestDivideTwoNumbers()
        {
            int result = _fixture.TestObject.Divide(6, 3);
            Assert.Equal(2, result);
        }
        
    }
}