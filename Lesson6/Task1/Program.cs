using static System.Console;

Clear();

int Prompt(string message)
{
    Write(message);
    int value = Convert.ToInt32(ReadLine());
    return value;
}

int[] InputNumbers(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(ReadLine());
    }
    
    return array;
}

int PositiveCounter(int[] array)
{
    int counter = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }

    return counter;
}

int length = Prompt("Введите количество чисел: ");

WriteLine();
WriteLine("Введите эти числа:");
WriteLine();

int[] inputNumbers = InputNumbers(length);

WriteLine($"Чисел больше 0 => {PositiveCounter(inputNumbers)}");
