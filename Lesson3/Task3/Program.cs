Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int N = Prompt("Введите число: ");
Console.Write(1);

for (int i = 2; i <= N; i++) Console.Write($", {Math.Pow(i, 3)}");
