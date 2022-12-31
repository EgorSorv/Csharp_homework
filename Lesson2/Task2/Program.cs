void FillArray(int[] array)
{
    array[0] = new Random().Next(1, 10);
    int length = array.Length;
    int index = 1;

    while (index < 3)
    {
        array[index] = new Random().Next(0, 10);
        index++;
    }
}

int [] array = new int[3];
FillArray(array);

Console.WriteLine($"Сгенерировано число: {array[0]}{array[1]}{array[2]}");
Console.WriteLine($"Преобразованное число: {array[0]}{array[2]}");
