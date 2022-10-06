namespace Calculator
{
    public class CalculatorService
    {
        private IFileService _fileService;

        public CalculatorService(IFileService fileService)
        {
            _fileService = fileService;
        }

        public int Add(int x, int y)
        {
            var result = x + y;
            _fileService.Write(result);

            return result;
        }
    }
}