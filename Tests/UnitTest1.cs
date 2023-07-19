namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_1_and_1_equal_2()
        {
            Assert.Equal(2, Domain.Calc.Sum(1,1));
        }

        [Fact]
        public void Sum_1_and_1__not_equal_1()
        {
            Assert.NotEqual(2, Domain.Calc.Sum(1, 1));
        }
    }
}