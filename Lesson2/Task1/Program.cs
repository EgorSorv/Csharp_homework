int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = Prompt("Введите положительное трехзначное число: ");
while (number > 999 || number < 100) number = Prompt("Число должно быть положительным и трехзначным: ");

Console.WriteLine($"Втора цифра числа {number} - {number / 10 % 10}");
