using static System.Console;

Clear();

int Prompt(string message)
{
    Write(message);
    int value = Convert.ToInt32(ReadLine());
    return value;
}

double Exponentiation(int a, int b)
{
    return Math.Pow(a, b);
}

int number = Prompt("Введите число: ");
int power = Prompt("Введите степень этого числа: ");

WriteLine($"Число {number} в степени {power} => {Exponentiation(number, power)}");
