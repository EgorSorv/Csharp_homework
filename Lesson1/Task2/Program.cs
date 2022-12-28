int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number1 = Prompt("Введите первое число: ");
int number2 = Prompt("Введите второе число: ");
int number3 = Prompt("Введите третье число: ");

if (number1 >= number2 && number1 > number3 || number1 > number2 && number1 >= number3) Console.WriteLine($"max = {number1}");
else if (number2 >= number1 && number2 > number3 || number2 > number1 && number2 >= number3) Console.WriteLine($"max = {number2}");
else if (number3 >= number1 && number3 > number2 || number3 > number1 && number3 >= number2) Console.WriteLine($"max = {number3}");
else  Console.WriteLine("Числа равны");
