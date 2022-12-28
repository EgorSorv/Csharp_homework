int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number1 = Prompt("Введите первое число: ");
int number2 = Prompt("Введите второе число: ");

if (number1 > number2) Console.WriteLine($"max = {number1}, min = {number2}");
else if (number1 < number2)  Console.WriteLine("max = " + number2 + ", min = " + number1);
else  Console.WriteLine("Числа равны");
