int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = Prompt("Введите число: ");
int counter = 2;

if (number < counter)
{
    while (number < counter) number = Prompt("Число долно быть больше 1: ");
    while (counter <= number)
    { 
        Console.Write($"{counter} ");
        counter += 2;
    }
}
else
{
    while (counter <= number)
    { 
        Console.Write($"{counter} ");
        counter += 2;
    }
}
