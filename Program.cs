namespace My.Home.Work.Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cycles = new MasteringTheCycles();
            cycles.PrintAge();
            
            var control = new OutputControl();
            control.PrintInput();
            
            var subsequence  = new Subsequence();
            subsequence.PrintIncreasing();
            
            var sum = new SumOfNumbers();
            sum.PrintValue();
            
            var convert = new CurrencyConverter();
            convert.Converter();
            
            var currencyV2 = new CurrencyConverterV2();
            currencyV2.ConverterV2();
        }
    }
}