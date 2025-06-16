namespace My.Home.Work.Cycles;

public class MasteringTheCycles
{
    public int age;

    public void PrintAge()
    {
        Console.Write("Введите ваш возраст: ");
        age = Convert.ToInt32(Console.ReadLine());

        while (age > 0)
        {
            Console.WriteLine("С днем рождения!");
            age--;
        }
    }
}