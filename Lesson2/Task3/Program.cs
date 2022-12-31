int ReverseInt(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result * 10 + number % 10;
        number /= 10;
    }
    return result;
}

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = Prompt("Введите число: ");

if (number / 10 < 10) Console.WriteLine($"У числа {number} нет третьей цифры");
else Console.WriteLine($"Третья цифра числа {number} - {ReverseInt(number) / 10 / 10 % 10}");
