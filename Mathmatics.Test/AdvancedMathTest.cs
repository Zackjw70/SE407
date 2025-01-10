using Xunit.Sdk;

namespace Mathmatics.Test
{
    public class AdvancedMathTest : IClassFixture<AdvancedMathTestFixture>
    {
        private AdvancedMathTestFixture _fixture;
        
        
        
        public AdvancedMathTest(AdvancedMathTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Theory]
        [InlineData(5.0, 3.0, 15.0)]
        public void TestArea(double num1, double num2, double expected)
        {
            double result = _fixture.TestObject.Area(num1, num2);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(1.0, 2.0, 3.0, 2.0)]
        public void TestAverage(double num1, double num2, double num3 , double expected)
        {
            List<double> nums = new List<double>();
            nums.Add(num1);
            nums.Add(num2);
            nums.Add(num3);
            double result = _fixture.TestObject.Average(nums);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(2.0, 4.0)]
        public void TestSquare(double num1, double expected)
        {
            double result = _fixture.TestObject.Square(num1);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(3.0, 4.0, 5.0)]
        public void TestPythag(double num1, double num2, double expected)
        {
            double result = _fixture.TestObject.Pythag(num1, num2);
            Assert.Equal(expected, result);
        }
        
    }
}