using static System.Console;
using static System.String;

Clear();

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(100, 1000);
    return array;
}

void Print(int[] array, string separator = ",")
{
    string output = Join(separator, array);
    WriteLine($"[{output}]");
}

int Prompt(string message)
{
    Write(message);
    int value = Convert.ToInt32(ReadLine());
    return value;
}

int CounterOfEvenNumbers(int[] array)
{   
    int counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) counter++;
    }

    return counter;
}

int length = Prompt("Введите длину массива: ");
int[] array = CreateArray(length);

WriteLine("Содержание массива:");
Print(array);

WriteLine($"Количество четных чисел в массиве => {CounterOfEvenNumbers(array)}");
