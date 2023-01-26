using static System.Console;
using static System.String;

Clear();

double Prompt(string message)
{
    Write(message);
    double value = Convert.ToDouble(ReadLine());
    return value;
}

void Print(double[] array, string separator = ";")
{
    string output = Join(separator, array);
    WriteLine($"({output})");
}

double[] IntersectionOfTwoLines(double b1, double k1, double b2, double k2)
{
    double [] result = new double [2];

    result[0] = Math.Round((b2 - b1) / (k1 - k2), 2);
    result[1] = Math.Round(k1 * result[0] + b1, 2);

    return result;
}

bool CheckForParallel(double k1, double k2)
{
    if (k1 == k2) return true;
    else return false;
}

WriteLine("Найти пересечение прямых типа y = k1 * x + b1 и y = k2 * x + b2");

double b1 = Prompt("Задайте b1: ");
double k1 = Prompt("Задайте k1: ");
double b2 = Prompt("Задайте b2: ");
double k2 = Prompt("Задайте k2: ");

if (CheckForParallel(k1, k2) == true) WriteLine("Прямые параллельны");
else
{
    Write("Точка пересечения прямых => ");
    Print(IntersectionOfTwoLines(b1, k1, b2, k2));
}
