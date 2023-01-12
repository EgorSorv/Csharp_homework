using static System.Console;
using static System.String;

Clear();

int Prompt(string message)
{
    Write(message);
    int value = Convert.ToInt32(ReadLine());
    return value;
}

int[] FillArray(int size = 10, int min = 0, int max = 10)
{
    return Enumerable.Range(1, size)
                     .Select(item => Random.Shared.Next(min, max + 1))
                     .ToArray();
}

void PrintArray(int[] array, string separator = ",")
{
    string output = Join(separator, array);
    WriteLine($"[{output}]");
}

int length = Prompt("Введите количество элементов массива: ");
int minValue = Prompt("Введите минимальный порог случайных значений: ");
int maxValue = Prompt("Введите максимальный порог случайных значений: ");

int[]array = FillArray(length, minValue, maxValue);

WriteLine("Содержание массива:");
PrintArray(array);
