//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

double[] FindPointIntersection(double b1, double k1, double b2, double k2)
{
    double[] coords = new double[2];
    coords[0] = (b2-b1)/(k1-k2);
    coords[1] = k1 * coords[0] + b1;
    return coords;
}

bool IsParrallelLines (double b1, double k1, double b2, double k2)
{
    return (b1 * k2 == b2 * k1);
}

void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

double k1 = Prompt("Введите значение к1: ");
double b1 = Prompt("Введите значение b1: ");
double k2 = Prompt("Введите значение к2: ");
double b2 = Prompt("Введите значение b2: ");

if (!IsParrallelLines(b1,k1,b2,k2))
{
    double[] coordinats = FindPointIntersection(b1,k1,b2,k2);
    PrintArray(coordinats);
}
else
{
    System.Console.WriteLine("Прямые параллельны друг другу!");
}
