using static System.Console;

Clear();

int Prompt(string message)
{
    Write(message);
    int value = Convert.ToInt32(ReadLine());
    return value;
}

int SumOfElementsInNumber(int number)
{
    int sum = 0;

    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

int Absolute (int number)
{
    if (number < 0) number = -number;
    return number;
}

int num = Prompt("Введите число: ");
int number = Absolute(num);

WriteLine($" Сумма цифр в числе {num} => {SumOfElementsInNumber(number)}");
