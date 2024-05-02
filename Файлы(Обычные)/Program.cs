using System.Text;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите букву:");
        char letter = Console.ReadLine()[0];

        string input = "C:\\repository\\ООЯП\\Файлы(Обычные)\\sample.txt";
        string output = "C:\\repository\\ООЯП\\Файлы(Обычные)\\output.txt";

        try
        {
            string text = File.ReadAllText(input, Encoding.UTF8);
            Console.WriteLine($"Текст из файла: {text}");

            int count = func(text, letter);
            File.WriteAllText(output, count.ToString());
            Console.WriteLine($"Ответ: {count}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Не удалось найти файл с входн    ыми данными.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    static int func(string text, char letter)
    {
        string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        foreach (string word in words)
        {
            if (word.EndsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
        }
        return count;
    }
}
