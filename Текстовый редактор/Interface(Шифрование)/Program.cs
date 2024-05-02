using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductAnalysis
{
    // Интерфейс шифрования
    public interface IDataEncoder
    {
        string Encode(string value);
        string Decode(string value);
    }

    // Класс шифрования
    public class DataEncoder : IDataEncoder
    {
        public string Encode(string value)
        {
            // Ваш код шифрования (например, сдвиг символов)
            StringBuilder encodedString = new StringBuilder();
            int shift = 3;  // Сдвиг на 3 символа

            foreach (char character in value)
            {
                char shiftedChar = (char)(character + shift);
                encodedString.Append(shiftedChar);
            }

            return encodedString.ToString();
        }

        public string Decode(string value)
        {
            // Ваш код расшифровки (обратный сдвиг символов)
            StringBuilder decodedString = new StringBuilder();
            int shift = 3;  // Обратный сдвиг на 3 символа

            foreach (char character in value)
            {
                char shiftedChar = (char)(character - shift);
                decodedString.Append(shiftedChar);
            }

            return decodedString.ToString();
        }
    }

    // Класс предприятия
    public class Enterprise
    {
        public string Name { get; private set; }
        public double AverageMonthlyProduction { get; private set; }

        private IDataEncoder _encoder;

        public Enterprise(string name, double averageMonthlyProduction, IDataEncoder encoder)
        {
            _encoder = encoder;
            Name = _encoder.Encode(name);
            AverageMonthlyProduction = averageMonthlyProduction;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Предприятие: {_encoder.Decode(Name)}, Среднемесячный объем выпуска: {AverageMonthlyProduction}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDataEncoder encoder = new DataEncoder();
            List<Enterprise> enterprises = new List<Enterprise>
            {
                new Enterprise("Завод А", 500.0, encoder),
                new Enterprise("Завод B", 700.0, encoder),
                new Enterprise("Завод C", 600.0, encoder),
                // Добавьте больше предприятий, если нужно
            };

            // Найдем предприятия с максимальным и минимальным среднегодовым выпуском
            var maxEnterprise = enterprises.OrderByDescending(e => e.AverageMonthlyProduction).First();
            var minEnterprise = enterprises.OrderBy(e => e.AverageMonthlyProduction).First();

            // Вывод информации о предприятиях с максимальным и минимальным среднегодовым выпуском
            Console.WriteLine("Предприятие с максимальным среднегодовым выпуском:");
            maxEnterprise.ShowInfo();
            Console.WriteLine("\nПредприятие с минимальным среднегодовым выпуском:");
            minEnterprise.ShowInfo();
            Console.ReadKey();
        }
    }
}
