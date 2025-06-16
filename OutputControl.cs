namespace My.Home.Work.Cycles;

public class OutputControl
{
    public string input;

    public void PrintInput()
    {
        Console.Write("Введите слово или exit для выхода: ");
        
        while ((input = Console.ReadLine()) != "exit" )
        {
            Console.WriteLine($"Вы ввели {input}");
            Console.WriteLine("Введите следующее слово или exit для выхода: ");
        }
        Console.WriteLine("Программа завершена");
    }
}