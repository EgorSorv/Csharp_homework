Console.Clear();

const int X = 0;
const int Y = 1;
const int Z = 2;

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int [] InputPoint(int point)
{
    int [] answer = new int[3];
    answer[X] = Prompt($"Введите x{point}: ");
    answer[Y] = Prompt($"Введите y{point}: ");
    answer[Z] = Prompt($"Введите z{point}: ");
    return answer;
}

double Power (int arg) 
{
    return Math.Pow(arg, 2);
}

int [] p1 = InputPoint(1);
int [] p2 = InputPoint(2);

double length = Math.Sqrt(Power(p1[X] - p2[X]) + Power(p1[Y] - p2[Y]) + Power(p1[Z] - p2[Z]));

Console.WriteLine($"Расстояние между данными точками: {length:f2}");
