namespace My.Home.Work.Cycles;

public class CurrencyConverter
{
    public const string CommandRubToUsd = "1";
    public const string CommandUsdToRub = "2";
    public const string CommandRubToEur = "3";
    public const string CommandEurToRub = "4";
    public const string CommandUsdToEur = "5";
    public const string CommandEurToUsd = "6";
    public const string CommandExit = "7";
    
    const float RubToUsd = 0.01266f;
    const float UsdToRub = 79f;
    const float RubToEur = 0.0112f;
    const float UsdToEur = 0.91f;
    const float EurToUsd = 1.1f;
    const float EurToRub = 89.1f;
    
    public float rublesInWallet;
    public float dollarsInWallet;
    public float eurosInWallet;

    public float exchangeCurrencyCount;

    public string desiredOperation;

    public void Converter()
    {
        Console.WriteLine("Добро пожаловать в обменник валют!");
        
        Console.WriteLine("Введите баланс рублей: ");
        rublesInWallet = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("Введите баланс долларов: ");
        dollarsInWallet = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("Введите баланс евро: ");
        eurosInWallet = Convert.ToSingle(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("Выберите необходимую операцию");
            Console.WriteLine($"{CommandRubToUsd} - обменять рубли на доллары");
            Console.WriteLine($"{CommandUsdToRub} - обменять доллары на рубли");
            Console.WriteLine($"{CommandRubToEur} - обменять рубли на евро");
            Console.WriteLine($"{CommandEurToRub} - обменять евро на рубли");
            Console.WriteLine($"{CommandUsdToEur} - обменять доллары на евро");
            Console.WriteLine($"{CommandEurToUsd} - обменять евро на доллары");
            Console.WriteLine($"{CommandExit} - выход");

            Console.WriteLine("Ваш выбор: ");
            desiredOperation = Console.ReadLine();
            if (desiredOperation == CommandExit)
            {
                Console.WriteLine("Выход");
                break;
            }

            Console.WriteLine("Введите сумму для конвертации: ");
            exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
            bool operationSuccess = false;
            

            switch (desiredOperation)
            {
                case CommandRubToUsd:
                    if (rublesInWallet >= exchangeCurrencyCount)
                    {
                        rublesInWallet -= exchangeCurrencyCount;
                        dollarsInWallet += exchangeCurrencyCount * RubToUsd;
                        operationSuccess = true;
                    }

                    break;
                case CommandUsdToRub:
                    if (dollarsInWallet >= exchangeCurrencyCount)
                    {
                        dollarsInWallet -= exchangeCurrencyCount;
                        rublesInWallet += exchangeCurrencyCount * UsdToRub;
                        operationSuccess = true;
                    }

                    break;
                case CommandRubToEur:
                    if (rublesInWallet >= exchangeCurrencyCount)
                    {
                        rublesInWallet -= exchangeCurrencyCount;
                        eurosInWallet += exchangeCurrencyCount * RubToEur;
                        operationSuccess = true;
                    }

                    break;
                case CommandEurToRub:
                    if (eurosInWallet >= exchangeCurrencyCount)
                    {
                        eurosInWallet -= exchangeCurrencyCount;
                        rublesInWallet += exchangeCurrencyCount * EurToRub;
                        operationSuccess = true;
                    }

                    break;
                case CommandUsdToEur:
                    if (dollarsInWallet >= exchangeCurrencyCount)
                    {
                        dollarsInWallet -= exchangeCurrencyCount;
                        eurosInWallet += exchangeCurrencyCount * UsdToEur;
                        operationSuccess = true;
                    }

                    break;
                case CommandEurToUsd:
                    if (eurosInWallet >= exchangeCurrencyCount)
                    {
                        eurosInWallet -= exchangeCurrencyCount;
                        dollarsInWallet += exchangeCurrencyCount * EurToUsd;
                        operationSuccess = true;
                    }

                    break;
                default:
                    Console.WriteLine("Неверная операция");
                    break;

            }
            if (operationSuccess)
            {
                Console.WriteLine("Операция выполнена успешно");
                Console.WriteLine($"Ваш баланс: Рубли - {rublesInWallet:F2}, Доллары - {dollarsInWallet:F2}, Евро - {eurosInWallet:F2}");
            }
            else if (desiredOperation == CommandRubToUsd || desiredOperation == CommandRubToEur ||
                     desiredOperation == CommandUsdToRub
                     || desiredOperation == CommandUsdToEur || desiredOperation == CommandEurToRub ||
                     desiredOperation == CommandEurToUsd)
            {
                Console.WriteLine("Недостаточно средств для конвертации");
            }
        }
    }
}