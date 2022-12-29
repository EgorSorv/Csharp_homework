int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number1 = Prompt("Введите первое число: ");
int number2 = Prompt("Введите второе число: ");
int number3 = Prompt("Введите третье число: ");
int [] array = {number1, number2, number3};
int max = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
}

if (number1 == number2 && number1 == number3 && number2 == number3) Console.WriteLine("Числа равны");
else Console.WriteLine($"max = {max}");
