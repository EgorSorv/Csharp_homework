using static System.Console;
using static System.String;

Clear();

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 100) + new Random().NextDouble();
    return array;
}

void Print(double[] array, string separator = ",")
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

double DifferenceBetweenMaxAndMin(double[] array)
{   
    double diff;
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)  max = array[i];
        else if (array[i] < min) min = array[i];
    }
    diff = max - min;
    return diff;
}

int length = Prompt("Введите длину массива: ");
double[] array = CreateArray(length);

WriteLine("Содержание массива:");
Print(array);

WriteLine($"Разница между максимальным и минимальным значением в массиве => {DifferenceBetweenMaxAndMin(array):F2}");
