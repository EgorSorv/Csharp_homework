int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = Prompt("Введите число: ");
int counter = 1;

if (number <= counter)
{
    while (number <= counter) number = Prompt("Число долно быть больше 1: ");
    while (counter <= number)
    {
        if (counter % 2 == 0)
        {
            Console.Write($"{counter} ");
            counter++;
        }
        else counter++;
    }
}
else
{
    while (counter <= number)
    {
        if (counter % 2 == 0)
        {
            Console.Write($"{counter} ");
            counter++;
        }
        else counter++;
    }
}
