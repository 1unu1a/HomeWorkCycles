namespace My.Home.Work.Cycles;

public class SumOfNumbers
{
    Random rand = new Random();
    public int number;
    public int sum;

    public void PrintValue()
    {
        number = new Random().Next(0, 101);
        Console.WriteLine(number);
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
}