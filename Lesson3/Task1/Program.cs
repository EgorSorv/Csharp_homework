Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

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

int number1 = Prompt("Введите число ");
int number2 = ReverseInt(number1);

if (number1 == number2) Console.WriteLine("Это число является палиндромом");
else Console.WriteLine("Это число не является палиндромом");
