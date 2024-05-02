using System;

class Program
{
    // Определение enum для дней недели
    enum DaysOfWeek
    {
        Monday = 1,  // Понедельник
        Tuesday,     // Вторник
        Wednesday,   // Среда
        Thursday,    // Четверг
        Friday,      // Пятница
        Saturday,    // Суббота
        Sunday       // Воскресенье
    }

    static void Main()
    {
        Console.WriteLine("Все дни недели:");
        foreach (var day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            Console.WriteLine(day);
        }

        // Получение значения enum по индексу
        int index = 4;  
        DaysOfWeek dayOfWeek = (DaysOfWeek)index;
        Console.WriteLine("\nПоследний день недели с индексом {0} равен: {1}", index, dayOfWeek);

        // Преобразование строки в enum
        string dayString = "Monday";
        if (Enum.TryParse(dayString, out DaysOfWeek parsedDay))
        {
            Console.WriteLine("\nСтрока '{0}' был успешно проанализирован как: {1}", dayString, parsedDay);
        }
        else
        {
            Console.WriteLine("\nСтрока String '{0}' не может быть проанализирована как допустимый день недели.", dayString);
        }

        // Использование enum в условном операторе
        DaysOfWeek today = DaysOfWeek.Wednesday;
        if (today == DaysOfWeek.Wednesday)
        {
            Console.WriteLine("\nСегодня среда!");
        }
        else
        {
            Console.WriteLine("\nСегодня не среда.");
        }
    }
}
