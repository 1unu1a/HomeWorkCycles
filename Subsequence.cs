namespace My.Home.Work.Cycles;

public class Subsequence
{
    /* для вывода чилел 5 12 19 26 33 40 47 54 61 68 75 82 89 96 лучше использовать цикл for,
    так как заданы четкие границы цикла */

    public int increasingValue = 96;

    public void PrintIncreasing()
    {
        for (int i = 5; i <= increasingValue; i+=7)
        {
            Console.WriteLine(i);
        }
    }
}