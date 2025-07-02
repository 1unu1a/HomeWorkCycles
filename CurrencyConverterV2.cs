namespace My.Home.Work.Cycles;

public class CurrencyConverterV2
{
    public enum Currency
    {
        Rub, Usd, Eur
    }
    
    public Dictionary<Currency, float> wallet = new Dictionary<Currency, float>
    {
        [Currency.Rub] = 0,
        [Currency.Usd] = 0,
        [Currency.Eur] = 0
    };
    
    public Dictionary<(Currency from, Currency to), float> exchangeRates = new Dictionary<(Currency, Currency), float>
    {
        [(Currency.Rub, Currency.Usd)] = 0.01266f,
        [(Currency.Usd, Currency.Rub)] = 79f,
        [(Currency.Rub, Currency.Eur)] = 0.0112f,
        [(Currency.Eur, Currency.Rub)] = 89.1f,
        [(Currency.Usd, Currency.Eur)] = 0.91f,
        [(Currency.Eur, Currency.Usd)] = 1.1f
    };
    
    public void ConverterV2()
    {
        Console.WriteLine("Добро пожаловать в обменник валют!");
        
        wallet[Currency.Rub] = ReadValidBalance("рублей");
        wallet[Currency.Usd] = ReadValidBalance("долларов");
        wallet[Currency.Eur] = ReadValidBalance("евро");

        while (true)
        {
            Console.WriteLine("\nВведите валюту, из которой хотите перевести (rub, usd, eur), или exit для выхода:");
            string fromInput = Console.ReadLine().Trim().ToLower();
            if (fromInput == "exit")
                break;

            Console.WriteLine("Введите валюту, в которую хотите перевести:");
            string toInput = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Введите сумму для обмена:");
            if (!float.TryParse(Console.ReadLine(), out float amount))
            {
                Console.WriteLine("Некорректная сумма");
                continue;
            }

            if (!TryParseCurrency(fromInput, out Currency fromCurrency) ||
                !TryParseCurrency(toInput, out Currency toCurrency))
            {
                Console.WriteLine("Одна из валют указана неверно");
                continue;
            }

            if (fromCurrency == toCurrency)
            {
                Console.WriteLine("Нельзя перевести валюту саму в себя");
                continue;
            }

            if (wallet[fromCurrency] < amount)
            {
                Console.WriteLine("Недостаточно средств");
                continue;
            }

            if (!exchangeRates.TryGetValue((fromCurrency, toCurrency), out float rate))
            {
                Console.WriteLine("Курс для этой валютной пары не найден");
                continue;
            }

            wallet[fromCurrency] -= amount;
            wallet[toCurrency] += amount * rate;

            Console.WriteLine("Обмен выполнен успешно");
            Console.WriteLine($"Баланс: Рубли - {wallet[Currency.Rub]:F2}, Доллары - {wallet[Currency.Usd]:F2}, Евро - {wallet[Currency.Eur]:F2}");
        }
    }

    public float ReadValidBalance(string currencyName)
    {

        while (true)
        {
            Console.Write($"Введите баланс {currencyName}: ");
            string input = Console.ReadLine();

            if (float.TryParse(input, out float value) && value >= 0)
                return value;

            Console.WriteLine("Некорректный ввод. Попробуйте ещё раз.");
        }
    }
    public bool TryParseCurrency(string input, out Currency currency)
    {
        return Enum.TryParse(input, true, out currency);
    }
}