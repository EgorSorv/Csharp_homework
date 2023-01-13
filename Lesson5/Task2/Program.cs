using static System.Console;
using static System.String;

Clear();

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-20, 21);
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

int SumOfNumbersOnUnevenPositions(int[] array)
{   
    int sum = 0;

    for (int i = 0; i < array.Length; i+= 2)
    {
        sum += array[i];
    }

    return sum;
}

int length = Prompt("Введите длину массива: ");
int[] array = CreateArray(length);

WriteLine("Содержание массива:");
Print(array);

WriteLine($"Сумма чисел, находящихся на нечетных позициях в массиве => {SumOfNumbersOnUnevenPositions(array)}");
