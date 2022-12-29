int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = Prompt("Введите число: ");

if (number % 2 == 0) Console.WriteLine($"{number} - это чётное число");
else Console.WriteLine($"{number} - это нечётное число");
