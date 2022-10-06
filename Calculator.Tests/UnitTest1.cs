namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_Success()
        {
            // ARRANGE
            //var fileService = new FileService();
            var service = new CalculatorService(fileService);

            // ACT
            var result = service.Add(5, 4);

            // ASSERT
            Assert.Equal(8, result);
        }
    }
}