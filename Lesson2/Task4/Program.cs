int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int day = Prompt("Введите день недели: ");
while (day > 7 || day < 1) day = Prompt("Такого дня недели не существует. Введите, пожалуйста, корректное значение: ");

if (day == 6 || day == 7) Console.WriteLine("Это выходной день");
else Console.WriteLine("Это рабочий день");
