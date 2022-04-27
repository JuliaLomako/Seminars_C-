//Задача 1:Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, 
// k1 = 5, 
// b2 = 4, 
// k2 = 9 -> (0,5; 4,5)

string Peresechenie(double b1, double k1, double b2, double k2)
{
    double xPeres = (double)(b1 - b2) / (k1 - k2);
    double yPeres = k1 * xPeres + b1;
    string result = "" + xPeres + ";" + yPeres;
    return result;
}
Console.WriteLine("Введите b1: ");
int bLine1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1: ");
int kLine1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int bLine2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int kLine2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Peresechenie(bLine1, kLine1, bLine2, kLine2)}");


//Задача 2: Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.

int[,] CreateTriangle(int size)
{
    int[,] triangle = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
    PrintMatrix(triangle);
    return triangle;
}
CreateTriangle(5);

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}



//ДОМАШНЕЕ ЗАДАНИЕ


int Factorial(int n)
{
    int x = 1;

    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

void PascalTriangle()
{
    Console.Write("Введите количество строк для треугольника Паскаля: ");
    int stringTri = Convert.ToInt32(Console.ReadLine());
    int j;
    for (int i = 0; i < stringTri; i++)
    {
        for (j = 0; j <= (stringTri - i); j++)
            Console.Write(" ");

        for (j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j)));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

PascalTriangle();



