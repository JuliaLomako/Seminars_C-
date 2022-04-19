//Задачи Семнара 6

// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.
//A < B + C


//(Важно: Не может быть у треугольника такой стороны которая больше чем сумма двух других сторон) 
//(ВАЖНО: Условие существаания треугольника: одна сторона всегла сторого меньше сумме двух других )



void Triangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    } 

}

Console.WriteLine("Введите первое числа");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе числа");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье числа");
int numC = Convert.ToInt32(Console.ReadLine());
Triangle(numA, numB, numC);


//Задача 2: Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное.

void Binar(int numS)
{
    string answer = "";
    while(numS > 0)
    {
       answer = Convert.ToString(numS%2) + answer;
       numS = numS / 2;
    }
    Console.WriteLine(answer);
}
Console.WriteLine("Введите число");
int Num =Convert.ToInt32(Console.ReadLine());
Binar(Num);

//Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.


void Fibbon(int numA)
{
    int[] array = new int [numA];
    array[0] = 0; 
    array[1] = 1;
    Console.Write("0 1 ");
    for (int i = 2; i < numA; i++)
    {
        array[i] = array[i-1] + array[i-2];
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Fibbon(num);


// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

//Задача 4: Напишите программу, которая будет создавать копию заданного массива 
//с помощью поэлементного копирования (3,4)

int[,] matrix = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = new Random().Next(0,10);
        Console.Write(matrix[i, j] + " ");
    }
Console.WriteLine();
}



//ДОМАШНИЕ ЗАДАЧИ


//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int CountNumbers(int num)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        if (i > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите числа");
int Numbers = Convert.ToInt32(Console.ReadLine());
CountNumbers(Numbers);




//Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, 
//создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.


void PrintMatrix(int[,] mArray)
{

    for (int i = 0; i < mArray.GetLength(0); i++)
    {
        for (int j = 0; j < mArray.GetLength(1); j++)
        {
            Console.Write($"{mArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] FillMatrix(int rows, int columns)
{
    int[,] newMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{newMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите кол-во строк для массива");
int rowsArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов для массива");
int columnArray = Convert.ToInt32(Console.ReadLine());

//не могу вывести на консоль :(( 

FillMatrix(rowsArray, columnArray);
PrintMatrix(mArray);




